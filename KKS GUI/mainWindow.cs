using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.IO;


namespace KKS_GUI
{
    delegate void testDelegate(double[] input);
    
    //Класс mainWindow
    public partial class mainWindow : Form
    {

        
        private networkSetupDialog networkDialog = new networkSetupDialog();   //Инициализация диалогового окна настроек
        private AboutBox1 aboutDialog = new AboutBox1();  //Инициализация окна About
        static public TcpClient sock = new TcpClient();   //Инициализация сокета

        public Thread SetConnection = new Thread(openConnection);   //Поток для установки соединения


        //Главное окно
        public mainWindow()
        {
            configVariables.configRead();

            InitializeComponent();

            if (configVariables.AutoConnect)
                connectionPreparations();
        }

        //Подключение или отключение из меню "Файл"
        private void подключитьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((!sock.Connected) && (!SetConnection.IsAlive))
            {
                подключитьсяToolStripMenuItem.Text = "Отключиться";
                SetConnection = null;
                SetConnection = new Thread(openConnection);
                SetConnection.Start();
                if (checkBox1.Checked)
                {
                    button_QBER.Enabled = false;
                    button_QBER_OK.Enabled = false;
                    configVariables.manualMode = true;
                }
                else
                {
                    button_QBER.Enabled = true;
                    button_QBER_OK.Enabled = true;
                    configVariables.manualMode = false;
                }
            }
            else
            {
                closeTransmissionSequence(); //Останавливает передачу данных, сбрасывает флаги
                
                подключитьсяToolStripMenuItem.Text = "Подключиться";

                if (checkBox1.Checked && configVariables.operateFlag)
                {
                    button_QBER.Enabled = true;
                    button_QBER_OK.Enabled = true;
                    configVariables.manualMode = true;
                }
                else
                {
                    button_QBER.Enabled = false;
                    button_QBER_OK.Enabled = false;
                    configVariables.manualMode = false;
                }
            };
        }

        //Закрытие программы из меню "Файл"
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeTransmissionSequence();  //Останавливает передачу данных, сбрасывает флаги
            Application.Exit();
        }


        //Закрытие потока передачи данных и установки соединения
        private static void closeTransmissionSequence()
        {
            configVariables.operateFlag = false; //Флаг остановки передачи данных
            configVariables.conenctionFlag = false; //Флаг остановки инициализации подключения
            toolStripStatusLabel1.Text = "Состояние подключения: [Соединение отсутствует]";

            sock.Close();
            sock = new TcpClient();  //После закрытия соединения уничтожается экземпляр sock, поэтому так надо
            menuBar.Invoke(new Action(() => подключитьсяToolStripMenuItem.Text = "Подключиться"));


        }

        //Вызов диалогового окна настроек сети из меню "Настройки"
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {    
            networkDialog.ShowDialog();
        }

        //Установка соединения (*ПОТОК*)
        static public void openConnection()
        {
            int conFail = 0; //Инициализация счётчика неудачных попыток подключения
            configVariables.conenctionFlag = true; //Флаг цикла установки соединения
            while (configVariables.conenctionFlag)
            {
                toolStripStatusLabel1.Text = "Состояние подключения: [Установка соединения (" + conFail + ")]";
                try
                {
                    sock.Connect(configVariables.BobAdress, configVariables.BobPort); //Подключение по сокету      
                }

                catch (SocketException e)
                {
                    conFail++;  //Подсчет кол-ва неудачных подключений    
                }


               if (conFail==10)  //Процедуре даётся 10 попыток на подключение
                {
                    closeTransmissionSequence();
                    
                }

               if (sock.Connected)
                {
                    toolStripStatusLabel1.Text = "Состояние подключения: [Соединение установлено]";
                    configVariables.conenctionFlag = false;
                    //Thread.Sleep(5000);
                    try
                    {
                        operateKKS();
                    }//Соединение установлено - запуск цикла передачи данных
                    catch (System.IO.IOException connectionException)
                    {
                        MessageBox.Show(connectionException.Message, "Ошибка соединения");
                        closeTransmissionSequence();
                    }
                    catch (System.ComponentModel.InvalidAsynchronousStateException)
                    {
                        //Do nothing! Because it's right! 
                    }
                }
            }
        }


        //Процесс передачи режимов в KKS
        static public void operateKKS()
        {
            configVariables.operateFlag = true;
            int kksMode = 0;  //Инициализация режима для отправки

            while (configVariables.operateFlag)
            {
                if (configVariables.manualMode)
                {
                    //Отправка кода режима
                    NetworkStream stream = sock.GetStream();
                    if (configVariables.operateFlag) tabMain.Invoke(new Action(() => kksMode = tabMain.SelectedIndex));
                    byte[] data = System.Text.Encoding.ASCII.GetBytes(kksMode.ToString());
                    if (configVariables.operateFlag)
                        stream.Write(data, 0, data.Length);
                    stream.Flush();


                    //Получение данных по режиму
                    data = new byte[4];
                    //Получение ответа
                    string responseData = String.Empty;  //Строка для хранения ответа от сервера

                    //Получение и обработка данных (отрисовка)
                    if (configVariables.operateFlag)
                    {
                        Int32 bytes = 0;
                        getData(ref stream, ref data, 4, 0, ref bytes); //Получение указанного кол-ва байт с сокета (размер строки)
                        int rsp = BitConverter.ToInt32(data, 0);  
                        data = new byte[rsp];

                        getData(ref stream, ref data, rsp, 0, ref bytes);  //Получение строки с данными для дальнейшей обработки

                        responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);  //Перевод из system.Byte в string
                        if (configVariables.log)                                              //Вывод полученных данных по сокету в файл, duh...
                            arrayToFile(DateTime.Now.ToString()+" "+rsp.ToString() + " bytes: " + responseData, "modeAnswer.txt");

                        if (configVariables.operateFlag) dataSort(kksMode, responseData);     //Обработка и вывод полученных данных
                        Thread.Sleep(configVariables.delay);                                  //Задержка между процедурами отправки режимов
                        stream.Flush();                                                       //Чистка сокета от ненужных остаточных данных (часть байт от предыдущего режима)
                    }

                }
            }
        }



        //Сохранение полученного массива в файл, для дальнейшей обработки
        public static void arrayToFile(string input, string path)
        {
            File.AppendAllText(path, input+Environment.NewLine);  //Запись строки в файл
           
        }

        //Процедура приёма и обработки с сокета
        public static void getData(ref NetworkStream _stream, ref byte[] _data, int counter, int offset, ref Int32 _bytes)
        {
            _bytes = 0;
            while ((counter > 0) && ((_bytes = _stream.Read(_data, offset, counter)) > 0) && configVariables.operateFlag)
            {
                offset += _bytes;
                counter -= _bytes;
            };
        }


        //Дробит строку на элементы
        public static void stringSeparator(string input, ref double[] output)
        {
            char separator = ' ';
            input = input.Replace('.',',');
            string[] separatedString = input.Split(separator);
            for (int i=0; i < input.Split(separator).Length-1; i++) //почему -1? почему считает длину на 1 больше?
            {
                output[i] = Convert.ToDouble(separatedString[i]);
            }
        }

        //Делегат для обработки и вывода режима "Статус"
        static void proc(double[] input)
        {
            keyGenValueLabel.Text = Math.Round((input[0]/1024),3).ToString()+" kbit/s";
            qberValueLabel.Text = Math.Round((input[1]*100),3).ToString()+"%";

            if ((input[1]) >= 6.5e-02)
            {
                arrayToFile(DateTime.Now.ToString() + " Ключ отброшен", "modeAnswer.txt");
                arrayToFile("", "modeAnswer.txt");
                siftedKeyLengthValueLabel.Text = "Ключ отброшен";
            }
            else
            {
                arrayToFile(DateTime.Now.ToString() + " Ключ принят", "modeAnswer.txt");
                arrayToFile("", "modeAnswer.txt");
                siftedKeyLengthValueLabel.Text = "Ключ принят";
            }

            statusChart.Series["Скорость генерации ключа"].Points.DataBindY(configVariables.status1GraphArray);
            statusChart.Series["QBER"].Points.DataBindY(configVariables.status2GraphArray);
        }

        //Создание потоков и прочие процедуры для установки соединения
        public void connectionPreparations()
        {
            if ((!sock.Connected) && (!SetConnection.IsAlive))
            {
                подключитьсяToolStripMenuItem.Text = "Отключиться";
                SetConnection = null;
                SetConnection = new Thread(openConnection);
                SetConnection.Start();
                if (checkBox1.Checked)
                {
                    button_QBER.Enabled = false;
                    button_QBER_OK.Enabled = false;
                    configVariables.manualMode = true;
                }
                else
                {
                    button_QBER.Enabled = true;
                    button_QBER_OK.Enabled = true;
                    configVariables.manualMode = false;
                }
            }
            else
            {
                closeTransmissionSequence(); //Останавливает передачу данных, сбрасывает флаги

                подключитьсяToolStripMenuItem.Text = "Подключиться";

                if (checkBox1.Checked && configVariables.operateFlag)
                {
                    button_QBER.Enabled = true;
                    button_QBER_OK.Enabled = true;
                    configVariables.manualMode = true;
                }
                else
                {
                    button_QBER.Enabled = false;
                    button_QBER_OK.Enabled = false;
                    configVariables.manualMode = false;
                }
            };
        }

        //Процедура вывода данных: mode - текущий режим; data -  данные для вывода (разделитель элементов " ")
        public static void dataSort(int mode, string data)
        {
            switch (mode)
            {
                
                case 0:
                    {
                        double[] result = new double[3];
                        stringSeparator(data, ref result);
                        testDelegate go = new testDelegate(proc);
                        if (tabMain.InvokeRequired)
                            tabMain.Invoke(go, result);
                        for (int i=0; i<configVariables.status1GraphArray.Length-1; i++)
                            {
                                configVariables.status1GraphArray[i] = configVariables.status1GraphArray[i + 1];
                                configVariables.status2GraphArray[i] = configVariables.status2GraphArray[i + 1];
                            }
                            configVariables.status1GraphArray[configVariables.status1GraphArray.Length - 1] = result[0]/1024;
                            configVariables.status2GraphArray[configVariables.status2GraphArray.Length - 1] = result[1]*100;             
                        break;
                    }
                case 1:
                    {
                        double[] result = new double[132];
                        stringSeparator(data, ref result);

                        double[] main_data = new double[128];
                        double[] basis = new double[128];
                        double[] main_basis = new double[128];

                        for (int i=0; i<128; i++)
                        {
                            if ((i == result[129]) || (i == result[130]) || (i == result[131]))
                                basis[i] = result[i];
                            else
                                if (i == result[128]) main_basis[i] = result[i];
                                   else
                                      main_data[i] = result[i];
                        }


                        chartCalib.Invoke(new Action(() => chartCalib.Series["seriesCalib"].Points.DataBindY(main_data)));

                       
                        chartCalib.Invoke(new Action(() => chartCalib.Series["seriesBasis"].Points.DataBindY(basis)));

                        chartCalib.Invoke(new Action(() => chartCalib.Series["seriesMainBasis"].Points.DataBindY(main_basis)));

                        chartCalib.Invoke(new Action(() => chartCalib.Series["seriesMainBasis"].Points[Convert.ToInt32(result[128])].Label = "0"));

                        for (int i = 1; i < 4; i++)
                        {
                            chartCalib.Invoke(new Action(() => chartCalib.Series["seriesBasis"].Points[Convert.ToInt32(result[128+i])].Label = i.ToString()));
                        }
                        break;
                    }
                case 2:
                    {
                        double[] result = new double[1024];
                        stringSeparator(data, ref result);
                        chartPyrk.Invoke(new Action(() => chartPyrk.Series["seriesPyrk"].Points.DataBindY(result)));
                        break;
                    }
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutDialog.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked && configVariables.operateFlag)
            {
                button_QBER.Enabled = true;
                button_QBER_OK.Enabled = true;
                configVariables.manualMode = false;
            }
            else
            {
                button_QBER.Enabled = false;
                button_QBER_OK.Enabled = false;
                configVariables.manualMode = true;
            }
        }

        private void button_QBER_OK_Click(object sender, EventArgs e)
        {
            NetworkStream stream = sock.GetStream();
            byte[] qo_data = System.Text.Encoding.ASCII.GetBytes("3");
            if (configVariables.operateFlag)
                stream.Write(qo_data, 0, qo_data.Length);
        }

        private void button_QBER_Click(object sender, EventArgs e)
        {
            NetworkStream stream = sock.GetStream();
            byte[] q_data = System.Text.Encoding.ASCII.GetBytes("4");
            if (configVariables.operateFlag)
                stream.Write(q_data, 0, q_data.Length);
        }

        private void Form_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            closeTransmissionSequence();
        }
    }

    //Все переменные из конфига
    public class configVariables
    {
        //Инициализация переменных конфига
        static public string AliceAdress, BobAdress;   //Адреса Алисы и Боба
        static public int AlicePort, BobPort;   //Порты Алисы и Боба, режим работы программы
        static public int graphBufferCounter = 0;
        static public double[] status1GraphArray = new double[300];
        static public double[] status2GraphArray = new double[300];
        static public double[] status3GraphArray = new double[300];
        static public bool AutoConnect;   //Автоматическое подключение при запуске программы
        static public bool operateFlag = false, conenctionFlag = true, manualMode = false, log; //Флаги остановки передачи данных и установки подключения
        static public int delay;

        //Процедура чтения значений из файла
        static public void configRead()
        {
            System.IO.StreamReader configFile = new System.IO.StreamReader (@"./config.cfg");

            AliceAdress = configFile.ReadLine();
            AlicePort = Convert.ToInt32(configFile.ReadLine());
            BobAdress = configFile.ReadLine();
            BobPort = Convert.ToInt32(configFile.ReadLine());
            AutoConnect = Convert.ToBoolean(configFile.ReadLine());
            delay = Convert.ToInt32(configFile.ReadLine());
            log = Convert.ToBoolean(configFile.ReadLine());

            configFile.Close();
        }

        //Процедура записи конфига в файл
        static public void configWrite()
        {
            System.IO.StreamWriter configFile = new System.IO.StreamWriter(@"./config.cfg", false);

            configFile.WriteLine(AliceAdress);
            configFile.WriteLine(AlicePort);
            configFile.WriteLine(BobAdress);
            configFile.WriteLine(BobPort);
            configFile.WriteLine(AutoConnect);
            configFile.WriteLine(delay);
            configFile.WriteLine(log);

            configFile.Close();
        }
    }
}


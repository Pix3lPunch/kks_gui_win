using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KKS_GUI
{
    //Основной класс диалоговго окна настроек сети
    public partial class networkSetupDialog : Form
    {
        public networkSetupDialog()
        {
            InitializeComponent();

            //Заполнение полей из confgiVariables
            configVariables.configRead();
            textBoxAliceAdress.Text = configVariables.AliceAdress;
            textBoxAlicePort.Text = configVariables.AlicePort.ToString();
            textBoxBobAdress.Text = configVariables.BobAdress;
            textBoxBobPort.Text = configVariables.BobPort.ToString();
            checkBox1.Checked = configVariables.AutoConnect;
        }

        //Нажатие кнопки "OK"
        private void buttonOK_Click(object sender, EventArgs e)
        {
            //Сохранение изменений в переменных класса configVariables
            configVariables.AliceAdress = textBoxAliceAdress.Text;
            configVariables.AlicePort = Convert.ToInt32(textBoxAlicePort.Text);
            configVariables.BobAdress = textBoxBobAdress.Text;
            configVariables.BobPort = Convert.ToInt32(textBoxBobPort.Text);
            configVariables.AutoConnect = checkBox1.Checked;

            //Сохранение полей конфига в файл
            configVariables.configWrite();

            //Закрыть окно
            this.Close();        
        }

        //Нажатие кнопки "Отмена"
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            //Заполнение полей из confgiVariables
            textBoxAliceAdress.Text = configVariables.AliceAdress;
            textBoxAlicePort.Text = configVariables.AlicePort.ToString();
            textBoxBobAdress.Text = configVariables.BobAdress;
            textBoxBobPort.Text = configVariables.BobPort.ToString();
            checkBox1.Checked = configVariables.AutoConnect;
        }
    }
}

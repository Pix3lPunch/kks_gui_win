namespace KKS_GUI
{
    partial class mainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                closeTransmissionSequence();
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            menuBar = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            подключитьсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            tabMain = new System.Windows.Forms.TabControl();
            this.tabPageStatus = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            rawKeyLengthLabel = new System.Windows.Forms.Label();
            siftedKeyLengthValueLabel = new System.Windows.Forms.Label();
            this.qberLabel = new System.Windows.Forms.Label();
            qberValueLabel = new System.Windows.Forms.Label();
            this.keyGenSpeedLabel = new System.Windows.Forms.Label();
            keyGenValueLabel = new System.Windows.Forms.Label();
            statusChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button_QBER_OK = new System.Windows.Forms.Button();
            this.button_QBER = new System.Windows.Forms.Button();
            this.tabPageCallibration = new System.Windows.Forms.TabPage();
            chartCalib = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPagePyrk = new System.Windows.Forms.TabPage();
            chartPyrk = new System.Windows.Forms.DataVisualization.Charting.Chart();
            menuBar.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.tableLayoutMain.SuspendLayout();
            tabMain.SuspendLayout();
            this.tabPageStatus.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(statusChart)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabPageCallibration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(chartCalib)).BeginInit();
            this.tabPagePyrk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(chartPyrk)).BeginInit();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            menuBar.ImageScalingSize = new System.Drawing.Size(32, 32);
            menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            menuBar.Location = new System.Drawing.Point(0, 0);
            menuBar.Name = "menuBar";
            menuBar.Size = new System.Drawing.Size(1254, 40);
            menuBar.TabIndex = 0;
            menuBar.Text = "menuBar";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            подключитьсяToolStripMenuItem,
            this.toolStripSeparator1,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(83, 36);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // подключитьсяToolStripMenuItem
            // 
            подключитьсяToolStripMenuItem.Name = "подключитьсяToolStripMenuItem";
            подключитьсяToolStripMenuItem.Size = new System.Drawing.Size(276, 38);
            подключитьсяToolStripMenuItem.Text = "Подключиться";
            подключитьсяToolStripMenuItem.Click += new System.EventHandler(подключитьсяToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(273, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(276, 38);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(145, 36);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(287, 38);
            this.toolStripMenuItem2.Text = "Настройки сети";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(179, 36);
            this.оПрограммеToolStripMenuItem.Text = "О Программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // statusBar
            // 
            this.statusBar.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            toolStripStatusLabel1});
            this.statusBar.Location = new System.Drawing.Point(0, 761);
            this.statusBar.Name = "statusBar";
            this.statusBar.Padding = new System.Windows.Forms.Padding(0, 0, 14, 0);
            this.statusBar.Size = new System.Drawing.Size(1254, 37);
            this.statusBar.TabIndex = 1;
            this.statusBar.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new System.Drawing.Size(588, 32);
            toolStripStatusLabel1.Text = "Состояние подключения: [Соединение отсутствует]";
            // 
            // tableLayoutMain
            // 
            this.tableLayoutMain.AutoSize = true;
            this.tableLayoutMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutMain.ColumnCount = 1;
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutMain.Controls.Add(tabMain, 0, 0);
            this.tableLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutMain.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutMain.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutMain.Name = "tableLayoutMain";
            this.tableLayoutMain.RowCount = 1;
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutMain.Size = new System.Drawing.Size(1254, 800);
            this.tableLayoutMain.TabIndex = 3;
            // 
            // tabMain
            // 
            tabMain.Controls.Add(this.tabPageStatus);
            tabMain.Controls.Add(this.tabPageCallibration);
            tabMain.Controls.Add(this.tabPagePyrk);
            tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            tabMain.Location = new System.Drawing.Point(4, 4);
            tabMain.Margin = new System.Windows.Forms.Padding(4);
            tabMain.Name = "tabMain";
            tabMain.RightToLeft = System.Windows.Forms.RightToLeft.No;
            tabMain.SelectedIndex = 0;
            tabMain.Size = new System.Drawing.Size(1246, 713);
            tabMain.TabIndex = 2;
            // 
            // tabPageStatus
            // 
            this.tabPageStatus.Controls.Add(this.tableLayoutPanel1);
            this.tabPageStatus.Location = new System.Drawing.Point(8, 39);
            this.tabPageStatus.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageStatus.Name = "tabPageStatus";
            this.tabPageStatus.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageStatus.Size = new System.Drawing.Size(1230, 666);
            this.tabPageStatus.TabIndex = 0;
            this.tabPageStatus.Text = "Статус";
            this.tabPageStatus.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(statusChart, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1222, 658);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(rawKeyLengthLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(siftedKeyLengthValueLabel, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.qberLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(qberValueLabel, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.keyGenSpeedLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(keyGenValueLabel, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1214, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // rawKeyLengthLabel
            // 
            rawKeyLengthLabel.AutoSize = true;
            rawKeyLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            rawKeyLengthLabel.Location = new System.Drawing.Point(4, 66);
            rawKeyLengthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            rawKeyLengthLabel.Name = "rawKeyLengthLabel";
            rawKeyLengthLabel.Size = new System.Drawing.Size(168, 25);
            rawKeyLengthLabel.TabIndex = 2;
            rawKeyLengthLabel.Text = "Статус ключа:";
            // 
            // siftedKeyLengthValueLabel
            // 
            siftedKeyLengthValueLabel.AutoSize = true;
            siftedKeyLengthValueLabel.Location = new System.Drawing.Point(407, 66);
            siftedKeyLengthValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            siftedKeyLengthValueLabel.Name = "siftedKeyLengthValueLabel";
            siftedKeyLengthValueLabel.Size = new System.Drawing.Size(42, 25);
            siftedKeyLengthValueLabel.TabIndex = 5;
            siftedKeyLengthValueLabel.Text = "n/a";
            // 
            // qberLabel
            // 
            this.qberLabel.AutoSize = true;
            this.qberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.qberLabel.Location = new System.Drawing.Point(4, 33);
            this.qberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.qberLabel.Name = "qberLabel";
            this.qberLabel.Size = new System.Drawing.Size(184, 25);
            this.qberLabel.TabIndex = 1;
            this.qberLabel.Text = "QBER:";
            // 
            // qberValueLabel
            // 
            qberValueLabel.AutoSize = true;
            qberValueLabel.Location = new System.Drawing.Point(407, 33);
            qberValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            qberValueLabel.Name = "qberValueLabel";
            qberValueLabel.Size = new System.Drawing.Size(42, 25);
            qberValueLabel.TabIndex = 4;
            qberValueLabel.Text = "n/a";
            // 
            // keyGenSpeedLabel
            // 
            this.keyGenSpeedLabel.AutoSize = true;
            this.keyGenSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.keyGenSpeedLabel.Location = new System.Drawing.Point(4, 0);
            this.keyGenSpeedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.keyGenSpeedLabel.Name = "keyGenSpeedLabel";
            this.keyGenSpeedLabel.Size = new System.Drawing.Size(395, 25);
            this.keyGenSpeedLabel.TabIndex = 0;
            this.keyGenSpeedLabel.Text = "Скорость генерации ключа:";
            // 
            // keyGenValueLabel
            // 
            keyGenValueLabel.AutoSize = true;
            keyGenValueLabel.Location = new System.Drawing.Point(407, 0);
            keyGenValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            keyGenValueLabel.Name = "keyGenValueLabel";
            keyGenValueLabel.Size = new System.Drawing.Size(42, 25);
            keyGenValueLabel.TabIndex = 3;
            keyGenValueLabel.Text = "n/a";
            // 
            // statusChart
            // 
            chartArea1.Name = "keygenArea";
            chartArea2.Name = "qberArea";
            statusChart.ChartAreas.Add(chartArea1);
            statusChart.ChartAreas.Add(chartArea2);
            statusChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            statusChart.Legends.Add(legend1);
            statusChart.Location = new System.Drawing.Point(4, 112);
            statusChart.Margin = new System.Windows.Forms.Padding(4);
            statusChart.Name = "statusChart";
            series1.ChartArea = "keygenArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Скорость генерации ключа";
            series2.ChartArea = "qberArea";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "QBER";
            statusChart.Series.Add(series1);
            statusChart.Series.Add(series2);
            statusChart.Size = new System.Drawing.Size(1214, 441);
            statusChart.Series["Скорость генерации ключа"].BorderWidth = 3;
            statusChart.Series["QBER"].BorderWidth = 3;
            statusChart.Series["QBER"].Color = System.Drawing.Color.SeaGreen;
            statusChart.TabIndex = 1;
            statusChart.Text = "График Статуса";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.checkBox1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button_QBER_OK, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.button_QBER, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 560);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1216, 95);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox1.Location = new System.Drawing.Point(3, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(281, 89);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Авто";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button_QBER_OK
            // 
            this.button_QBER_OK.AutoSize = true;
            this.button_QBER_OK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_QBER_OK.Location = new System.Drawing.Point(290, 3);
            this.button_QBER_OK.Name = "button_QBER_OK";
            this.button_QBER_OK.Size = new System.Drawing.Size(458, 89);
            this.button_QBER_OK.TabIndex = 1;
            this.button_QBER_OK.Text = "QBER OK";
            this.button_QBER_OK.UseVisualStyleBackColor = true;
            this.button_QBER_OK.Click += new System.EventHandler(this.button_QBER_OK_Click);

            // 
            // button_QBER
            // 
            this.button_QBER.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_QBER.Location = new System.Drawing.Point(754, 3);
            this.button_QBER.Name = "button_QBER";
            this.button_QBER.Size = new System.Drawing.Size(459, 89);
            this.button_QBER.TabIndex = 2;
            this.button_QBER.Text = "QBER";
            this.button_QBER.UseVisualStyleBackColor = true;
            this.button_QBER.Click += new System.EventHandler(this.button_QBER_Click);

            this.button_QBER_OK.Enabled = false;
            this.button_QBER.Enabled = false;
            // 
            // tabPageCallibration
            // 
            this.tabPageCallibration.Controls.Add(chartCalib);
            this.tabPageCallibration.Location = new System.Drawing.Point(8, 39);
            this.tabPageCallibration.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageCallibration.Name = "tabPageCallibration";
            this.tabPageCallibration.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageCallibration.Size = new System.Drawing.Size(1230, 666);
            this.tabPageCallibration.TabIndex = 1;
            this.tabPageCallibration.Text = "Калибровка";
            this.tabPageCallibration.UseVisualStyleBackColor = true;
            // 
            // chartCalib
            // 
            chartArea3.Name = "ChartArea1";
            chartCalib.ChartAreas.Add(chartArea3);
            chartCalib.Dock = System.Windows.Forms.DockStyle.Fill;
            chartCalib.Location = new System.Drawing.Point(4, 4);
            chartCalib.Margin = new System.Windows.Forms.Padding(4);
            chartCalib.Name = "chartCalib";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series3.Name = "seriesCalib";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series4.Name = "seriesBasis";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series5.Name = "seriesMainBasis";
            chartCalib.Series.Add(series3);
            chartCalib.Series.Add(series4);
            chartCalib.Series.Add(series5);
            chartCalib.Size = new System.Drawing.Size(1222, 658);
            chartCalib.TabIndex = 0;
            chartCalib.Text = "Калибровочный график";
            // 
            // tabPagePyrk
            // 
            this.tabPagePyrk.Controls.Add(chartPyrk);
            this.tabPagePyrk.Location = new System.Drawing.Point(8, 39);
            this.tabPagePyrk.Margin = new System.Windows.Forms.Padding(4);
            this.tabPagePyrk.Name = "tabPagePyrk";
            this.tabPagePyrk.Padding = new System.Windows.Forms.Padding(4);
            this.tabPagePyrk.Size = new System.Drawing.Size(1230, 666);
            this.tabPagePyrk.TabIndex = 2;
            this.tabPagePyrk.Text = "Контраст";
            this.tabPagePyrk.UseVisualStyleBackColor = true;
            // 
            // chartPyrk
            // 
            chartArea4.Name = "ChartArea1";
            chartPyrk.ChartAreas.Add(chartArea4);
            chartPyrk.Dock = System.Windows.Forms.DockStyle.Fill;
            chartPyrk.Location = new System.Drawing.Point(4, 4);
            chartPyrk.Margin = new System.Windows.Forms.Padding(4);
            chartPyrk.Name = "chartPyrk";
            series6.ChartArea = "ChartArea1";
            series6.Name = "seriesPyrk";
            chartPyrk.Series.Add(series6);
            chartPyrk.Size = new System.Drawing.Size(1222, 658);
            chartPyrk.TabIndex = 0;
            chartPyrk.Text = "Пырк график";
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 798);
            this.Controls.Add(this.tableLayoutMain);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(menuBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = menuBar;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainWindow";
            this.Text = "KKS GUI";
            menuBar.ResumeLayout(false);
            menuBar.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.tableLayoutMain.ResumeLayout(false);
            tabMain.ResumeLayout(false);
            this.tabPageStatus.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(statusChart)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tabPageCallibration.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(chartCalib)).EndInit();
            this.tabPagePyrk.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(chartPyrk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form_Closing);

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutMain;
        private System.Windows.Forms.Label keyGenSpeedLabel;
        private System.Windows.Forms.TabPage tabPageCallibration;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TabPage tabPageStatus;
        private System.Windows.Forms.TabPage tabPagePyrk;
        static private System.Windows.Forms.Label rawKeyLengthLabel;
        private System.Windows.Forms.Label qberLabel;
        static public System.Windows.Forms.Label siftedKeyLengthValueLabel;
        static public System.Windows.Forms.Label qberValueLabel;
        static private System.Windows.Forms.MenuStrip menuBar;
        static private System.Windows.Forms.ToolStripMenuItem подключитьсяToolStripMenuItem;
        static public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        static private System.Windows.Forms.TabControl tabMain;
        static public System.Windows.Forms.Label keyGenValueLabel;
        static private System.Windows.Forms.DataVisualization.Charting.Chart chartCalib;
        static private System.Windows.Forms.DataVisualization.Charting.Chart chartPyrk;
        static private System.Windows.Forms.DataVisualization.Charting.Chart statusChart;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button_QBER_OK;
        private System.Windows.Forms.Button button_QBER;
    }
}


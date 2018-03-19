namespace KKS_GUI
{
    partial class networkSetupDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupAlice = new System.Windows.Forms.GroupBox();
            this.textBoxAlicePort = new System.Windows.Forms.TextBox();
            this.textBoxAliceAdress = new System.Windows.Forms.TextBox();
            this.labelAlicePort = new System.Windows.Forms.Label();
            this.labelAliceAdress = new System.Windows.Forms.Label();
            this.groupBob = new System.Windows.Forms.GroupBox();
            this.textBoxBobPort = new System.Windows.Forms.TextBox();
            this.textBoxBobAdress = new System.Windows.Forms.TextBox();
            this.labelBobPort = new System.Windows.Forms.Label();
            this.labelBobAdress = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupAlice.SuspendLayout();
            this.groupBob.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupAlice
            // 
            this.groupAlice.Controls.Add(this.textBoxAlicePort);
            this.groupAlice.Controls.Add(this.textBoxAliceAdress);
            this.groupAlice.Controls.Add(this.labelAlicePort);
            this.groupAlice.Controls.Add(this.labelAliceAdress);
            this.groupAlice.Location = new System.Drawing.Point(12, 12);
            this.groupAlice.Name = "groupAlice";
            this.groupAlice.Size = new System.Drawing.Size(328, 168);
            this.groupAlice.TabIndex = 0;
            this.groupAlice.TabStop = false;
            this.groupAlice.Text = "Алиса";
            // 
            // textBoxAlicePort
            // 
            this.textBoxAlicePort.Location = new System.Drawing.Point(106, 105);
            this.textBoxAlicePort.Name = "textBoxAlicePort";
            this.textBoxAlicePort.Size = new System.Drawing.Size(190, 31);
            this.textBoxAlicePort.TabIndex = 3;
            // 
            // textBoxAliceAdress
            // 
            this.textBoxAliceAdress.Location = new System.Drawing.Point(106, 45);
            this.textBoxAliceAdress.Name = "textBoxAliceAdress";
            this.textBoxAliceAdress.Size = new System.Drawing.Size(190, 31);
            this.textBoxAliceAdress.TabIndex = 2;
            // 
            // labelAlicePort
            // 
            this.labelAlicePort.AutoSize = true;
            this.labelAlicePort.Location = new System.Drawing.Point(21, 108);
            this.labelAlicePort.Name = "labelAlicePort";
            this.labelAlicePort.Size = new System.Drawing.Size(67, 25);
            this.labelAlicePort.TabIndex = 1;
            this.labelAlicePort.Text = "Порт:";
            // 
            // labelAliceAdress
            // 
            this.labelAliceAdress.AutoSize = true;
            this.labelAliceAdress.Location = new System.Drawing.Point(21, 48);
            this.labelAliceAdress.Name = "labelAliceAdress";
            this.labelAliceAdress.Size = new System.Drawing.Size(79, 25);
            this.labelAliceAdress.TabIndex = 0;
            this.labelAliceAdress.Text = "Адрес:";
            // 
            // groupBob
            // 
            this.groupBob.Controls.Add(this.textBoxBobPort);
            this.groupBob.Controls.Add(this.textBoxBobAdress);
            this.groupBob.Controls.Add(this.labelBobPort);
            this.groupBob.Controls.Add(this.labelBobAdress);
            this.groupBob.Location = new System.Drawing.Point(373, 12);
            this.groupBob.Name = "groupBob";
            this.groupBob.Size = new System.Drawing.Size(328, 168);
            this.groupBob.TabIndex = 4;
            this.groupBob.TabStop = false;
            this.groupBob.Text = "Боб";
            // 
            // textBoxBobPort
            // 
            this.textBoxBobPort.Location = new System.Drawing.Point(106, 105);
            this.textBoxBobPort.Name = "textBoxBobPort";
            this.textBoxBobPort.Size = new System.Drawing.Size(190, 31);
            this.textBoxBobPort.TabIndex = 3;
            // 
            // textBoxBobAdress
            // 
            this.textBoxBobAdress.Location = new System.Drawing.Point(106, 45);
            this.textBoxBobAdress.Name = "textBoxBobAdress";
            this.textBoxBobAdress.Size = new System.Drawing.Size(190, 31);
            this.textBoxBobAdress.TabIndex = 2;
            // 
            // labelBobPort
            // 
            this.labelBobPort.AutoSize = true;
            this.labelBobPort.Location = new System.Drawing.Point(21, 108);
            this.labelBobPort.Name = "labelBobPort";
            this.labelBobPort.Size = new System.Drawing.Size(67, 25);
            this.labelBobPort.TabIndex = 1;
            this.labelBobPort.Text = "Порт:";
            // 
            // labelBobAdress
            // 
            this.labelBobAdress.AutoSize = true;
            this.labelBobAdress.Location = new System.Drawing.Point(21, 48);
            this.labelBobAdress.Name = "labelBobAdress";
            this.labelBobAdress.Size = new System.Drawing.Size(79, 25);
            this.labelBobAdress.TabIndex = 0;
            this.labelBobAdress.Text = "Адрес:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(24, 206);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(596, 29);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Автоматическое подключение при запуске программы";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(735, 24);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(170, 45);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(735, 87);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(170, 45);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // networkSetupDialog
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(926, 265);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBob);
            this.Controls.Add(this.groupAlice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "networkSetupDialog";
            this.Text = "Настройки сети";
            this.groupAlice.ResumeLayout(false);
            this.groupAlice.PerformLayout();
            this.groupBob.ResumeLayout(false);
            this.groupBob.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupAlice;
        private System.Windows.Forms.Label labelAliceAdress;
        private System.Windows.Forms.TextBox textBoxAlicePort;
        private System.Windows.Forms.TextBox textBoxAliceAdress;
        private System.Windows.Forms.Label labelAlicePort;
        private System.Windows.Forms.GroupBox groupBob;
        private System.Windows.Forms.TextBox textBoxBobPort;
        private System.Windows.Forms.TextBox textBoxBobAdress;
        private System.Windows.Forms.Label labelBobPort;
        private System.Windows.Forms.Label labelBobAdress;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
    }
}
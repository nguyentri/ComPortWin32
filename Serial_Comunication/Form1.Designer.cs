namespace Serial_Comunication
{
    partial class Form1
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
            this.buttonSend = new System.Windows.Forms.Button();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.comboBoxParity = new System.Windows.Forms.ComboBox();
            this.comboBoxStopB = new System.Windows.Forms.ComboBox();
            this.comboBoxBaudR = new System.Windows.Forms.ComboBox();
            this.richTextBoxSend = new System.Windows.Forms.RichTextBox();
            this.buttonReload = new System.Windows.Forms.Button();
            this.richTextBoxReceive = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxDataB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(12, 113);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(97, 34);
            this.buttonSend.TabIndex = 0;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(245, 16);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(97, 21);
            this.comboBoxPort.TabIndex = 1;
            // 
            // comboBoxParity
            // 
            this.comboBoxParity.FormattingEnabled = true;
            this.comboBoxParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.comboBoxParity.Location = new System.Drawing.Point(12, 62);
            this.comboBoxParity.Name = "comboBoxParity";
            this.comboBoxParity.Size = new System.Drawing.Size(97, 21);
            this.comboBoxParity.TabIndex = 2;
            // 
            // comboBoxStopB
            // 
            this.comboBoxStopB.FormattingEnabled = true;
            this.comboBoxStopB.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.comboBoxStopB.Location = new System.Drawing.Point(12, 38);
            this.comboBoxStopB.Name = "comboBoxStopB";
            this.comboBoxStopB.Size = new System.Drawing.Size(97, 21);
            this.comboBoxStopB.TabIndex = 3;
            // 
            // comboBoxBaudR
            // 
            this.comboBoxBaudR.FormattingEnabled = true;
            this.comboBoxBaudR.Items.AddRange(new object[] {
            "75",
            "110",
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.comboBoxBaudR.Location = new System.Drawing.Point(12, 13);
            this.comboBoxBaudR.Name = "comboBoxBaudR";
            this.comboBoxBaudR.Size = new System.Drawing.Size(97, 21);
            this.comboBoxBaudR.TabIndex = 4;
            // 
            // richTextBoxSend
            // 
            this.richTextBoxSend.Location = new System.Drawing.Point(12, 153);
            this.richTextBoxSend.Name = "richTextBoxSend";
            this.richTextBoxSend.Size = new System.Drawing.Size(181, 78);
            this.richTextBoxSend.TabIndex = 6;
            this.richTextBoxSend.Text = "";
            // 
            // buttonReload
            // 
            this.buttonReload.Location = new System.Drawing.Point(360, 18);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(70, 19);
            this.buttonReload.TabIndex = 7;
            this.buttonReload.Text = "reload";
            this.buttonReload.UseVisualStyleBackColor = true;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // richTextBoxReceive
            // 
            this.richTextBoxReceive.Location = new System.Drawing.Point(223, 153);
            this.richTextBoxReceive.Name = "richTextBoxReceive";
            this.richTextBoxReceive.Size = new System.Drawing.Size(177, 77);
            this.richTextBoxReceive.TabIndex = 8;
            this.richTextBoxReceive.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Send data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Received data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Baud Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Stop bits";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Parity";
            // 
            // comboBoxDataB
            // 
            this.comboBoxDataB.FormattingEnabled = true;
            this.comboBoxDataB.Items.AddRange(new object[] {
            "7",
            "8"});
            this.comboBoxDataB.Location = new System.Drawing.Point(12, 86);
            this.comboBoxDataB.Name = "comboBoxDataB";
            this.comboBoxDataB.Size = new System.Drawing.Size(97, 21);
            this.comboBoxDataB.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Data bits";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 262);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxDataB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxReceive);
            this.Controls.Add(this.buttonReload);
            this.Controls.Add(this.richTextBoxSend);
            this.Controls.Add(this.comboBoxBaudR);
            this.Controls.Add(this.comboBoxStopB);
            this.Controls.Add(this.comboBoxParity);
            this.Controls.Add(this.comboBoxPort);
            this.Controls.Add(this.buttonSend);
            this.Name = "Form1";
            this.Text = "Form1";
           
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.ComboBox comboBoxParity;
        private System.Windows.Forms.ComboBox comboBoxStopB;
        private System.Windows.Forms.ComboBox comboBoxBaudR;
        private System.Windows.Forms.RichTextBox richTextBoxSend;
        private System.Windows.Forms.Button buttonReload;
        private System.Windows.Forms.RichTextBox richTextBoxReceive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxDataB;
        private System.Windows.Forms.Label label6;
    }
}


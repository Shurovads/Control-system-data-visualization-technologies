namespace Laba2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.BtnClose = new System.Windows.Forms.Button();
            this.richText = new System.Windows.Forms.ListBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.myTimer = new System.Windows.Forms.Timer(this.components);
            this.txtStartIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.myPort = new System.Windows.Forms.TextBox();
            this.portClient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.videoBox = new System.Windows.Forms.PictureBox();
            this.loadVideo_Btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackBarHeight = new System.Windows.Forms.TrackBar();
            this.labelHeight = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.labelHorizent = new System.Windows.Forms.Label();
            this.labelOnMe = new System.Windows.Forms.Label();
            this.debugModeCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.videoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(119, 7);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(101, 35);
            this.BtnClose.TabIndex = 13;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Visible = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // richText
            // 
            this.richText.FormattingEnabled = true;
            this.richText.HorizontalScrollbar = true;
            this.richText.ItemHeight = 16;
            this.richText.Location = new System.Drawing.Point(12, 48);
            this.richText.Name = "richText";
            this.richText.Size = new System.Drawing.Size(338, 116);
            this.richText.TabIndex = 14;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 8);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(101, 34);
            this.btnConnect.TabIndex = 19;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // myTimer
            // 
            this.myTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtStartIP
            // 
            this.txtStartIP.Location = new System.Drawing.Point(21, 607);
            this.txtStartIP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStartIP.Name = "txtStartIP";
            this.txtStartIP.ReadOnly = true;
            this.txtStartIP.Size = new System.Drawing.Size(100, 22);
            this.txtStartIP.TabIndex = 2;
            this.txtStartIP.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 610);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "IP";
            this.label1.Visible = false;
            // 
            // myPort
            // 
            this.myPort.Location = new System.Drawing.Point(21, 650);
            this.myPort.Name = "myPort";
            this.myPort.ReadOnly = true;
            this.myPort.Size = new System.Drawing.Size(100, 22);
            this.myPort.TabIndex = 15;
            this.myPort.Text = "7777";
            this.myPort.Visible = false;
            // 
            // portClient
            // 
            this.portClient.Location = new System.Drawing.Point(155, 636);
            this.portClient.Name = "portClient";
            this.portClient.ReadOnly = true;
            this.portClient.Size = new System.Drawing.Size(100, 22);
            this.portClient.TabIndex = 16;
            this.portClient.Text = "8888";
            this.portClient.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 631);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "MyPort";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 617);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Port";
            this.label3.Visible = false;
            // 
            // videoBox
            // 
            this.videoBox.Location = new System.Drawing.Point(370, 7);
            this.videoBox.Name = "videoBox";
            this.videoBox.Size = new System.Drawing.Size(686, 646);
            this.videoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.videoBox.TabIndex = 20;
            this.videoBox.TabStop = false;
            // 
            // loadVideo_Btn
            // 
            this.loadVideo_Btn.Location = new System.Drawing.Point(12, 170);
            this.loadVideo_Btn.Name = "loadVideo_Btn";
            this.loadVideo_Btn.Size = new System.Drawing.Size(109, 36);
            this.loadVideo_Btn.TabIndex = 21;
            this.loadVideo_Btn.Text = "loadVideo";
            this.loadVideo_Btn.UseVisualStyleBackColor = true;
            this.loadVideo_Btn.Click += new System.EventHandler(this.loadVideo_Btn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trackBarHeight
            // 
            this.trackBarHeight.Location = new System.Drawing.Point(15, 271);
            this.trackBarHeight.Maximum = 20;
            this.trackBarHeight.Minimum = -20;
            this.trackBarHeight.Name = "trackBarHeight";
            this.trackBarHeight.Size = new System.Drawing.Size(182, 56);
            this.trackBarHeight.TabIndex = 23;
            this.trackBarHeight.Value = 1;
            this.trackBarHeight.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(12, 252);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(61, 16);
            this.labelHeight.TabIndex = 24;
            this.labelHeight.Text = "Высота: ";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 349);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Minimum = -20;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(179, 56);
            this.trackBar1.TabIndex = 25;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll_1);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(12, 427);
            this.trackBar2.Maximum = 20;
            this.trackBar2.Minimum = -20;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(179, 56);
            this.trackBar2.TabIndex = 26;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // labelHorizent
            // 
            this.labelHorizent.AutoSize = true;
            this.labelHorizent.Location = new System.Drawing.Point(12, 330);
            this.labelHorizent.Name = "labelHorizent";
            this.labelHorizent.Size = new System.Drawing.Size(72, 16);
            this.labelHorizent.TabIndex = 27;
            this.labelHorizent.Text = "Горизонт:";
            // 
            // labelOnMe
            // 
            this.labelOnMe.AutoSize = true;
            this.labelOnMe.Location = new System.Drawing.Point(9, 408);
            this.labelOnMe.Name = "labelOnMe";
            this.labelOnMe.Size = new System.Drawing.Size(63, 16);
            this.labelOnMe.TabIndex = 28;
            this.labelOnMe.Text = "На меня:";
            // 
            // debugModeCheckBox
            // 
            this.debugModeCheckBox.AutoSize = true;
            this.debugModeCheckBox.Location = new System.Drawing.Point(15, 213);
            this.debugModeCheckBox.Name = "debugModeCheckBox";
            this.debugModeCheckBox.Size = new System.Drawing.Size(159, 20);
            this.debugModeCheckBox.TabIndex = 29;
            this.debugModeCheckBox.Text = "Отладочный режим ";
            this.debugModeCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 756);
            this.Controls.Add(this.debugModeCheckBox);
            this.Controls.Add(this.labelOnMe);
            this.Controls.Add(this.labelHorizent);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.trackBarHeight);
            this.Controls.Add(this.loadVideo_Btn);
            this.Controls.Add(this.videoBox);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.portClient);
            this.Controls.Add(this.myPort);
            this.Controls.Add(this.richText);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStartIP);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "ShurovaDS221-328";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.videoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.ListBox richText;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Timer myTimer;
        private System.Windows.Forms.TextBox txtStartIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox myPort;
        private System.Windows.Forms.TextBox portClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox videoBox;
        private System.Windows.Forms.Button loadVideo_Btn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar trackBarHeight;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label labelHorizent;
        private System.Windows.Forms.Label labelOnMe;
        private System.Windows.Forms.CheckBox debugModeCheckBox;
    }
}


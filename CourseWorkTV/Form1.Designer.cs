namespace CourseWorkTV
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.loadVideo_Btn = new System.Windows.Forms.Button();
            this.videoBox = new System.Windows.Forms.PictureBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.button_SaveVideo = new System.Windows.Forms.Button();
            this.buttonStopVideo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.videoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // loadVideo_Btn
            // 
            this.loadVideo_Btn.Location = new System.Drawing.Point(12, 12);
            this.loadVideo_Btn.Name = "loadVideo_Btn";
            this.loadVideo_Btn.Size = new System.Drawing.Size(98, 23);
            this.loadVideo_Btn.TabIndex = 0;
            this.loadVideo_Btn.Text = "Start Video";
            this.loadVideo_Btn.UseVisualStyleBackColor = true;
            this.loadVideo_Btn.Click += new System.EventHandler(this.loadVideo_Btn_Click);
            // 
            // videoBox
            // 
            this.videoBox.Location = new System.Drawing.Point(12, 70);
            this.videoBox.Name = "videoBox";
            this.videoBox.Size = new System.Drawing.Size(939, 661);
            this.videoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.videoBox.TabIndex = 1;
            this.videoBox.TabStop = false;
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(299, 12);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(93, 23);
            this.startBtn.TabIndex = 3;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // button_SaveVideo
            // 
            this.button_SaveVideo.Location = new System.Drawing.Point(135, 12);
            this.button_SaveVideo.Name = "button_SaveVideo";
            this.button_SaveVideo.Size = new System.Drawing.Size(107, 23);
            this.button_SaveVideo.TabIndex = 4;
            this.button_SaveVideo.Text = "Save Video";
            this.button_SaveVideo.UseVisualStyleBackColor = true;
            this.button_SaveVideo.Click += new System.EventHandler(this.button_SaveVideo_Click);
            // 
            // buttonStopVideo
            // 
            this.buttonStopVideo.Location = new System.Drawing.Point(135, 42);
            this.buttonStopVideo.Name = "buttonStopVideo";
            this.buttonStopVideo.Size = new System.Drawing.Size(107, 23);
            this.buttonStopVideo.TabIndex = 5;
            this.buttonStopVideo.Text = "Stop Video";
            this.buttonStopVideo.UseVisualStyleBackColor = true;
            this.buttonStopVideo.Click += new System.EventHandler(this.buttonStopVideo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 738);
            this.Controls.Add(this.buttonStopVideo);
            this.Controls.Add(this.button_SaveVideo);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.videoBox);
            this.Controls.Add(this.loadVideo_Btn);
            this.Name = "Form1";
            this.Text = "Курсовая работа Шурова Дарья 221-327 6 семестр";
            ((System.ComponentModel.ISupportInitialize)(this.videoBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button loadVideo_Btn;
        private System.Windows.Forms.PictureBox videoBox;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button button_SaveVideo;
        private System.Windows.Forms.Button buttonStopVideo;
    }
}


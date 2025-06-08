namespace Laba3
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
            this.createBtn = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.histBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.analiseDataBttn = new System.Windows.Forms.Button();
            this.txtStep = new System.Windows.Forms.TextBox();
            this.btnSetStep = new System.Windows.Forms.Button();
            this.btnAnimate = new System.Windows.Forms.Button();
            this.openGLControl1 = new SharpGL.OpenGLControl();
            this.buttonRenderVoxels = new System.Windows.Forms.Button();
            this.buttonShowPoints = new System.Windows.Forms.Button();
            this.btnShowSurface = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(12, 40);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(104, 31);
            this.createBtn.TabIndex = 0;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(12, 77);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(104, 32);
            this.loadBtn.TabIndex = 1;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(12, 12);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(104, 22);
            this.txtCount.TabIndex = 2;
            // 
            // histBtn
            // 
            this.histBtn.Location = new System.Drawing.Point(13, 116);
            this.histBtn.Name = "histBtn";
            this.histBtn.Size = new System.Drawing.Size(103, 35);
            this.histBtn.TabIndex = 3;
            this.histBtn.Text = "Histogramm";
            this.histBtn.UseVisualStyleBackColor = true;
            this.histBtn.Click += new System.EventHandler(this.histBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(122, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 250);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // analiseDataBttn
            // 
            this.analiseDataBttn.Location = new System.Drawing.Point(12, 158);
            this.analiseDataBttn.Name = "analiseDataBttn";
            this.analiseDataBttn.Size = new System.Drawing.Size(104, 39);
            this.analiseDataBttn.TabIndex = 5;
            this.analiseDataBttn.Text = "Analise Data";
            this.analiseDataBttn.UseVisualStyleBackColor = true;
            this.analiseDataBttn.Click += new System.EventHandler(this.analiseDataBttn_Click);
            // 
            // txtStep
            // 
            this.txtStep.Location = new System.Drawing.Point(13, 204);
            this.txtStep.Name = "txtStep";
            this.txtStep.Size = new System.Drawing.Size(100, 22);
            this.txtStep.TabIndex = 6;
            // 
            // btnSetStep
            // 
            this.btnSetStep.Location = new System.Drawing.Point(13, 233);
            this.btnSetStep.Name = "btnSetStep";
            this.btnSetStep.Size = new System.Drawing.Size(100, 29);
            this.btnSetStep.TabIndex = 7;
            this.btnSetStep.Text = "SetStep";
            this.btnSetStep.UseVisualStyleBackColor = true;
            this.btnSetStep.Click += new System.EventHandler(this.btnSetStep_Click);
            // 
            // btnAnimate
            // 
            this.btnAnimate.Location = new System.Drawing.Point(13, 269);
            this.btnAnimate.Name = "btnAnimate";
            this.btnAnimate.Size = new System.Drawing.Size(100, 35);
            this.btnAnimate.TabIndex = 8;
            this.btnAnimate.Text = "Animate";
            this.btnAnimate.UseVisualStyleBackColor = true;
            this.btnAnimate.Click += new System.EventHandler(this.btnAnimate_Click);
            // 
            // openGLControl1
            // 
            this.openGLControl1.DrawFPS = false;
            this.openGLControl1.Location = new System.Drawing.Point(427, 13);
            this.openGLControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.openGLControl1.Name = "openGLControl1";
            this.openGLControl1.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLControl1.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.openGLControl1.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openGLControl1.Size = new System.Drawing.Size(360, 250);
            this.openGLControl1.TabIndex = 9;
            this.openGLControl1.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLControl1_OpenGLDraw);
            this.openGLControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.openGLControl_MouseDown);
            this.openGLControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.openGLControl_MouseMove);
            this.openGLControl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.openGLControl_MouseUp);
            // 
            // buttonRenderVoxels
            // 
            this.buttonRenderVoxels.Location = new System.Drawing.Point(13, 311);
            this.buttonRenderVoxels.Name = "buttonRenderVoxels";
            this.buttonRenderVoxels.Size = new System.Drawing.Size(103, 31);
            this.buttonRenderVoxels.TabIndex = 10;
            this.buttonRenderVoxels.Text = "RenderVoxels";
            this.buttonRenderVoxels.UseVisualStyleBackColor = true;
            this.buttonRenderVoxels.Click += new System.EventHandler(this.buttonRenderVoxels_Click);
            // 
            // buttonShowPoints
            // 
            this.buttonShowPoints.Location = new System.Drawing.Point(13, 349);
            this.buttonShowPoints.Name = "buttonShowPoints";
            this.buttonShowPoints.Size = new System.Drawing.Size(100, 38);
            this.buttonShowPoints.TabIndex = 11;
            this.buttonShowPoints.Text = "Show Points";
            this.buttonShowPoints.UseVisualStyleBackColor = true;
            this.buttonShowPoints.Click += new System.EventHandler(this.buttonShowPoints_Click);
            // 
            // btnShowSurface
            // 
            this.btnShowSurface.Location = new System.Drawing.Point(12, 393);
            this.btnShowSurface.Name = "btnShowSurface";
            this.btnShowSurface.Size = new System.Drawing.Size(101, 40);
            this.btnShowSurface.TabIndex = 13;
            this.btnShowSurface.Text = "ShowSurface";
            this.btnShowSurface.UseVisualStyleBackColor = true;
            this.btnShowSurface.Click += new System.EventHandler(this.btnShowSurface_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(202, 306);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 40);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 523);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnShowSurface);
            this.Controls.Add(this.buttonShowPoints);
            this.Controls.Add(this.buttonRenderVoxels);
            this.Controls.Add(this.openGLControl1);
            this.Controls.Add(this.btnAnimate);
            this.Controls.Add(this.btnSetStep);
            this.Controls.Add(this.txtStep);
            this.Controls.Add(this.analiseDataBttn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.histBtn);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.createBtn);
            this.Name = "Form1";
            this.Text = "ShurovaDS221-327Laba3";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Button histBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button analiseDataBttn;
        private System.Windows.Forms.TextBox txtStep;
        private System.Windows.Forms.Button btnSetStep;
        private System.Windows.Forms.Button btnAnimate;
        private SharpGL.OpenGLControl openGLControl1;
        private System.Windows.Forms.Button buttonRenderVoxels;
        private System.Windows.Forms.Button buttonShowPoints;
        private System.Windows.Forms.Button btnShowSurface;
        private System.Windows.Forms.Button btnSave;
    }
}


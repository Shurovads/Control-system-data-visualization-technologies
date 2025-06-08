namespace Lab2_VD
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
            this.txtCount = new System.Windows.Forms.TextBox();
            this.buttonGeneret = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.textSigma = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDrawCloud = new System.Windows.Forms.Button();
            this.btnDrawPerspective = new System.Windows.Forms.Button();
            this.dataGridViewRotation = new System.Windows.Forms.DataGridView();
            this.btnMatrix = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRotation)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(13, 36);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(100, 22);
            this.txtCount.TabIndex = 0;
            // 
            // buttonGeneret
            // 
            this.buttonGeneret.Location = new System.Drawing.Point(12, 108);
            this.buttonGeneret.Name = "buttonGeneret";
            this.buttonGeneret.Size = new System.Drawing.Size(100, 30);
            this.buttonGeneret.TabIndex = 1;
            this.buttonGeneret.Text = "Создать";
            this.buttonGeneret.UseVisualStyleBackColor = true;
            this.buttonGeneret.Click += new System.EventHandler(this.btnGenerateParametric_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(11, 255);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(100, 29);
            this.buttonLoad.TabIndex = 2;
            this.buttonLoad.Text = "Загрузить ";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // textSigma
            // 
            this.textSigma.Location = new System.Drawing.Point(12, 80);
            this.textSigma.Name = "textSigma";
            this.textSigma.Size = new System.Drawing.Size(100, 22);
            this.textSigma.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(251, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(630, 600);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Count";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sigma";
            // 
            // btnDrawCloud
            // 
            this.btnDrawCloud.Location = new System.Drawing.Point(11, 144);
            this.btnDrawCloud.Name = "btnDrawCloud";
            this.btnDrawCloud.Size = new System.Drawing.Size(172, 46);
            this.btnDrawCloud.TabIndex = 7;
            this.btnDrawCloud.Text = "Прямая проекция ";
            this.btnDrawCloud.UseVisualStyleBackColor = true;
            this.btnDrawCloud.Click += new System.EventHandler(this.btnDrawCloud_Click);
            // 
            // btnDrawPerspective
            // 
            this.btnDrawPerspective.Location = new System.Drawing.Point(11, 196);
            this.btnDrawPerspective.Name = "btnDrawPerspective";
            this.btnDrawPerspective.Size = new System.Drawing.Size(172, 53);
            this.btnDrawPerspective.TabIndex = 8;
            this.btnDrawPerspective.Text = "В перспективе";
            this.btnDrawPerspective.UseVisualStyleBackColor = true;
            this.btnDrawPerspective.Click += new System.EventHandler(this.btnDrawPerspective_Click);
            // 
            // dataGridViewRotation
            // 
            this.dataGridViewRotation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRotation.Location = new System.Drawing.Point(5, 304);
            this.dataGridViewRotation.Name = "dataGridViewRotation";
            this.dataGridViewRotation.RowHeadersWidth = 51;
            this.dataGridViewRotation.RowTemplate.Height = 24;
            this.dataGridViewRotation.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewRotation.TabIndex = 9;
            // 
            // btnMatrix
            // 
            this.btnMatrix.Location = new System.Drawing.Point(4, 460);
            this.btnMatrix.Name = "btnMatrix";
            this.btnMatrix.Size = new System.Drawing.Size(108, 46);
            this.btnMatrix.TabIndex = 10;
            this.btnMatrix.Text = "Матрица поворота";
            this.btnMatrix.UseVisualStyleBackColor = true;
            this.btnMatrix.Click += new System.EventHandler(this.btnMatrix_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(129, 461);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(116, 45);
            this.SaveBtn.TabIndex = 11;
            this.SaveBtn.Text = "Сохранить ";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 825);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.btnMatrix);
            this.Controls.Add(this.dataGridViewRotation);
            this.Controls.Add(this.btnDrawPerspective);
            this.Controls.Add(this.btnDrawCloud);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textSigma);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonGeneret);
            this.Controls.Add(this.txtCount);
            this.Name = "Form1";
            this.Text = "ShurovaDS221-327";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRotation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Button buttonGeneret;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.TextBox textSigma;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDrawCloud;
        private System.Windows.Forms.Button btnDrawPerspective;
        private System.Windows.Forms.DataGridView dataGridViewRotation;
        private System.Windows.Forms.Button btnMatrix;
        private System.Windows.Forms.Button SaveBtn;
    }
}


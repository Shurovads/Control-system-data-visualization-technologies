namespace Lab1_VD
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.chartData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBoxView = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.dataGridViewProfile1 = new System.Windows.Forms.DataGridView();
            this.buttonTransform = new System.Windows.Forms.Button();
            this.dataGridViewProfile2 = new System.Windows.Forms.DataGridView();
            this.buttonAnalyze = new System.Windows.Forms.Button();
            this.buttonStats = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfile1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfile2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(12, 26);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(100, 22);
            this.textBoxCount.TabIndex = 0;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(12, 54);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(121, 32);
            this.buttonGenerate.TabIndex = 1;
            this.buttonGenerate.Text = "CountPoints";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // chartData
            // 
            chartArea4.AxisX.Interval = 0.1D;
            chartArea4.AxisX.Maximum = 1D;
            chartArea4.AxisX.Minimum = 0D;
            chartArea4.AxisY.Interval = 0.1D;
            chartArea4.AxisY.Maximum = 1D;
            chartArea4.AxisY.Minimum = 0D;
            chartArea4.Name = "ChartArea1";
            this.chartData.ChartAreas.Add(chartArea4);
            this.chartData.Location = new System.Drawing.Point(179, 41);
            this.chartData.Name = "chartData";
            series4.ChartArea = "ChartArea1";
            series4.IsVisibleInLegend = false;
            series4.Name = "Series1";
            this.chartData.Series.Add(series4);
            this.chartData.Size = new System.Drawing.Size(383, 353);
            this.chartData.TabIndex = 2;
            this.chartData.Text = "chart1";
            // 
            // comboBoxView
            // 
            this.comboBoxView.FormattingEnabled = true;
            this.comboBoxView.Location = new System.Drawing.Point(12, 92);
            this.comboBoxView.Name = "comboBoxView";
            this.comboBoxView.Size = new System.Drawing.Size(143, 24);
            this.comboBoxView.TabIndex = 3;
            this.comboBoxView.SelectedIndexChanged += new System.EventHandler(this.comboBoxView_SelectedIndexChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 251);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(87, 35);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(12, 292);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(87, 35);
            this.buttonLoad.TabIndex = 5;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // dataGridViewProfile1
            // 
            this.dataGridViewProfile1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProfile1.Location = new System.Drawing.Point(595, 41);
            this.dataGridViewProfile1.Name = "dataGridViewProfile1";
            this.dataGridViewProfile1.RowHeadersWidth = 51;
            this.dataGridViewProfile1.RowTemplate.Height = 24;
            this.dataGridViewProfile1.Size = new System.Drawing.Size(287, 204);
            this.dataGridViewProfile1.TabIndex = 6;
            // 
            // buttonTransform
            // 
            this.buttonTransform.Location = new System.Drawing.Point(12, 207);
            this.buttonTransform.Name = "buttonTransform";
            this.buttonTransform.Size = new System.Drawing.Size(88, 38);
            this.buttonTransform.TabIndex = 7;
            this.buttonTransform.Text = "Изменить";
            this.buttonTransform.UseVisualStyleBackColor = true;
            this.buttonTransform.Click += new System.EventHandler(this.buttonTransform_Click);
            // 
            // dataGridViewProfile2
            // 
            this.dataGridViewProfile2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProfile2.Location = new System.Drawing.Point(595, 264);
            this.dataGridViewProfile2.Name = "dataGridViewProfile2";
            this.dataGridViewProfile2.RowHeadersWidth = 51;
            this.dataGridViewProfile2.RowTemplate.Height = 24;
            this.dataGridViewProfile2.Size = new System.Drawing.Size(287, 204);
            this.dataGridViewProfile2.TabIndex = 8;
            // 
            // buttonAnalyze
            // 
            this.buttonAnalyze.Location = new System.Drawing.Point(12, 122);
            this.buttonAnalyze.Name = "buttonAnalyze";
            this.buttonAnalyze.Size = new System.Drawing.Size(100, 35);
            this.buttonAnalyze.TabIndex = 9;
            this.buttonAnalyze.Text = "Анализ";
            this.buttonAnalyze.UseVisualStyleBackColor = true;
            this.buttonAnalyze.Click += new System.EventHandler(this.buttonAnalyze_Click);
            // 
            // buttonStats
            // 
            this.buttonStats.Location = new System.Drawing.Point(12, 163);
            this.buttonStats.Name = "buttonStats";
            this.buttonStats.Size = new System.Drawing.Size(100, 39);
            this.buttonStats.TabIndex = 17;
            this.buttonStats.Text = "Статистика ";
            this.buttonStats.UseVisualStyleBackColor = true;
            this.buttonStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 452);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 483);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 962);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStats);
            this.Controls.Add(this.buttonAnalyze);
            this.Controls.Add(this.dataGridViewProfile2);
            this.Controls.Add(this.buttonTransform);
            this.Controls.Add(this.dataGridViewProfile1);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.comboBoxView);
            this.Controls.Add(this.chartData);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.textBoxCount);
            this.Name = "Form1";
            this.Text = "ShurovaDS221-327";
            ((System.ComponentModel.ISupportInitialize)(this.chartData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfile1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfile2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartData;
        private System.Windows.Forms.ComboBox comboBoxView;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.DataGridView dataGridViewProfile1;
        private System.Windows.Forms.Button buttonTransform;
        private System.Windows.Forms.DataGridView dataGridViewProfile2;
        private System.Windows.Forms.Button buttonAnalyze;
        private System.Windows.Forms.Button buttonStats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}


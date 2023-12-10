
namespace Tyuiu.PoznyakIA.Sprint6.Task5.V26
{
    partial class FormMain_PIA
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelUP_PIA = new System.Windows.Forms.Panel();
            this.buttonReference_PIA = new System.Windows.Forms.Button();
            this.buttonOpenFile_PIA = new System.Windows.Forms.Button();
            this.buttonDone_PIA = new System.Windows.Forms.Button();
            this.groupBoxUslovie_PIA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_PIA = new System.Windows.Forms.TextBox();
            this.panelRight_PIA = new System.Windows.Forms.Panel();
            this.chartFunction_PIA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelLeft_PIA = new System.Windows.Forms.Panel();
            this.groupBoxVivod_PIA = new System.Windows.Forms.GroupBox();
            this.dataGridViewNums_PIA = new System.Windows.Forms.DataGridView();
            this.panelUP_PIA.SuspendLayout();
            this.groupBoxUslovie_PIA.SuspendLayout();
            this.panelRight_PIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_PIA)).BeginInit();
            this.panelLeft_PIA.SuspendLayout();
            this.groupBoxVivod_PIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums_PIA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUP_PIA
            // 
            this.panelUP_PIA.BackColor = System.Drawing.Color.Aqua;
            this.panelUP_PIA.Controls.Add(this.buttonReference_PIA);
            this.panelUP_PIA.Controls.Add(this.buttonOpenFile_PIA);
            this.panelUP_PIA.Controls.Add(this.buttonDone_PIA);
            this.panelUP_PIA.Controls.Add(this.groupBoxUslovie_PIA);
            this.panelUP_PIA.Location = new System.Drawing.Point(0, 1);
            this.panelUP_PIA.Name = "panelUP_PIA";
            this.panelUP_PIA.Size = new System.Drawing.Size(799, 95);
            this.panelUP_PIA.TabIndex = 0;
            // 
            // buttonReference_PIA
            // 
            this.buttonReference_PIA.Location = new System.Drawing.Point(695, 11);
            this.buttonReference_PIA.Name = "buttonReference_PIA";
            this.buttonReference_PIA.Size = new System.Drawing.Size(76, 64);
            this.buttonReference_PIA.TabIndex = 3;
            this.buttonReference_PIA.Text = "Справка";
            this.buttonReference_PIA.UseVisualStyleBackColor = true;
            this.buttonReference_PIA.Click += new System.EventHandler(this.buttonReference_PIA_Click);
            // 
            // buttonOpenFile_PIA
            // 
            this.buttonOpenFile_PIA.Location = new System.Drawing.Point(603, 11);
            this.buttonOpenFile_PIA.Name = "buttonOpenFile_PIA";
            this.buttonOpenFile_PIA.Size = new System.Drawing.Size(86, 64);
            this.buttonOpenFile_PIA.TabIndex = 2;
            this.buttonOpenFile_PIA.Text = "Открыть файл";
            this.buttonOpenFile_PIA.UseVisualStyleBackColor = true;
            this.buttonOpenFile_PIA.Click += new System.EventHandler(this.buttonOpenFile_PIA_Click);
            // 
            // buttonDone_PIA
            // 
            this.buttonDone_PIA.Location = new System.Drawing.Point(488, 11);
            this.buttonDone_PIA.Name = "buttonDone_PIA";
            this.buttonDone_PIA.Size = new System.Drawing.Size(109, 64);
            this.buttonDone_PIA.TabIndex = 1;
            this.buttonDone_PIA.Text = "Выполнить";
            this.buttonDone_PIA.UseVisualStyleBackColor = true;
            this.buttonDone_PIA.Click += new System.EventHandler(this.buttonDone_PIA_Click);
            // 
            // groupBoxUslovie_PIA
            // 
            this.groupBoxUslovie_PIA.Controls.Add(this.textBoxTask_PIA);
            this.groupBoxUslovie_PIA.Location = new System.Drawing.Point(3, 0);
            this.groupBoxUslovie_PIA.Name = "groupBoxUslovie_PIA";
            this.groupBoxUslovie_PIA.Size = new System.Drawing.Size(479, 89);
            this.groupBoxUslovie_PIA.TabIndex = 0;
            this.groupBoxUslovie_PIA.TabStop = false;
            this.groupBoxUslovie_PIA.Text = "Условие:";
            // 
            // textBoxTask_PIA
            // 
            this.textBoxTask_PIA.BackColor = System.Drawing.Color.Cyan;
            this.textBoxTask_PIA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_PIA.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask_PIA.Multiline = true;
            this.textBoxTask_PIA.Name = "textBoxTask_PIA";
            this.textBoxTask_PIA.Size = new System.Drawing.Size(467, 64);
            this.textBoxTask_PIA.TabIndex = 0;
            this.textBoxTask_PIA.Text = "Прочитать данные из файла InPutFileTask5V26.txt.Вывести все числа, кратные 5. Пос" +
    "троить диаграмму по этим значениям.";
            // 
            // panelRight_PIA
            // 
            this.panelRight_PIA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panelRight_PIA.Controls.Add(this.chartFunction_PIA);
            this.panelRight_PIA.Location = new System.Drawing.Point(261, 96);
            this.panelRight_PIA.Name = "panelRight_PIA";
            this.panelRight_PIA.Size = new System.Drawing.Size(538, 354);
            this.panelRight_PIA.TabIndex = 1;
            // 
            // chartFunction_PIA
            // 
            this.chartFunction_PIA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            chartArea2.Name = "ChartArea1";
            this.chartFunction_PIA.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chartFunction_PIA.Legends.Add(legend2);
            this.chartFunction_PIA.Location = new System.Drawing.Point(0, 0);
            this.chartFunction_PIA.Name = "chartFunction_PIA";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartFunction_PIA.Series.Add(series2);
            this.chartFunction_PIA.Size = new System.Drawing.Size(538, 354);
            this.chartFunction_PIA.TabIndex = 0;
            this.chartFunction_PIA.Text = "chart1";
            // 
            // panelLeft_PIA
            // 
            this.panelLeft_PIA.BackColor = System.Drawing.Color.Lime;
            this.panelLeft_PIA.Controls.Add(this.groupBoxVivod_PIA);
            this.panelLeft_PIA.Location = new System.Drawing.Point(0, 96);
            this.panelLeft_PIA.Name = "panelLeft_PIA";
            this.panelLeft_PIA.Size = new System.Drawing.Size(262, 354);
            this.panelLeft_PIA.TabIndex = 2;
            // 
            // groupBoxVivod_PIA
            // 
            this.groupBoxVivod_PIA.Controls.Add(this.dataGridViewNums_PIA);
            this.groupBoxVivod_PIA.Location = new System.Drawing.Point(3, 3);
            this.groupBoxVivod_PIA.Name = "groupBoxVivod_PIA";
            this.groupBoxVivod_PIA.Size = new System.Drawing.Size(252, 348);
            this.groupBoxVivod_PIA.TabIndex = 0;
            this.groupBoxVivod_PIA.TabStop = false;
            this.groupBoxVivod_PIA.Text = "Вывод:";
            // 
            // dataGridViewNums_PIA
            // 
            this.dataGridViewNums_PIA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNums_PIA.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewNums_PIA.Name = "dataGridViewNums_PIA";
            this.dataGridViewNums_PIA.Size = new System.Drawing.Size(240, 323);
            this.dataGridViewNums_PIA.TabIndex = 1;
            // 
            // FormMain_PIA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelLeft_PIA);
            this.Controls.Add(this.panelRight_PIA);
            this.Controls.Add(this.panelUP_PIA);
            this.Name = "FormMain_PIA";
            this.Text = "Спринт 6 | Таск 5 | Вариант 26 | Позняк И.А";
            this.panelUP_PIA.ResumeLayout(false);
            this.groupBoxUslovie_PIA.ResumeLayout(false);
            this.groupBoxUslovie_PIA.PerformLayout();
            this.panelRight_PIA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_PIA)).EndInit();
            this.panelLeft_PIA.ResumeLayout(false);
            this.groupBoxVivod_PIA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums_PIA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUP_PIA;
        private System.Windows.Forms.Button buttonReference_PIA;
        private System.Windows.Forms.Button buttonOpenFile_PIA;
        private System.Windows.Forms.Button buttonDone_PIA;
        private System.Windows.Forms.GroupBox groupBoxUslovie_PIA;
        private System.Windows.Forms.TextBox textBoxTask_PIA;
        private System.Windows.Forms.Panel panelRight_PIA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_PIA;
        private System.Windows.Forms.Panel panelLeft_PIA;
        private System.Windows.Forms.GroupBox groupBoxVivod_PIA;
        private System.Windows.Forms.DataGridView dataGridViewNums_PIA;
    }
}


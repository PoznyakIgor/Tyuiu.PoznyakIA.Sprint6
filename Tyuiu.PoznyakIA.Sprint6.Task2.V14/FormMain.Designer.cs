
namespace Tyuiu.PoznyakIA.Sprint6.Task2.V14
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxUslovie_PIA = new System.Windows.Forms.GroupBox();
            this.textBoxZadanie_PIA = new System.Windows.Forms.TextBox();
            this.groupBoxVvod_PIA = new System.Windows.Forms.GroupBox();
            this.textBoxNumberEnd_PIA = new System.Windows.Forms.TextBox();
            this.textBoxNumberStart_PIA = new System.Windows.Forms.TextBox();
            this.textBoxKonec_PIA = new System.Windows.Forms.TextBox();
            this.textBoxStart_PIA = new System.Windows.Forms.TextBox();
            this.groupBoxVivod_PIA = new System.Windows.Forms.GroupBox();
            this.textBoxResultat_PIA = new System.Windows.Forms.TextBox();
            this.dataGridViewFunction_PIA = new System.Windows.Forms.DataGridView();
            this.buttonDone_PIA = new System.Windows.Forms.Button();
            this.buttonReference_PIA = new System.Windows.Forms.Button();
            this.chartFunction_PIA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ColumnViewX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVievFX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBoxFormula_PIA = new System.Windows.Forms.PictureBox();
            this.groupBoxUslovie_PIA.SuspendLayout();
            this.groupBoxVvod_PIA.SuspendLayout();
            this.groupBoxVivod_PIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_PIA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_PIA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_PIA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxUslovie_PIA
            // 
            this.groupBoxUslovie_PIA.Controls.Add(this.pictureBoxFormula_PIA);
            this.groupBoxUslovie_PIA.Controls.Add(this.textBoxZadanie_PIA);
            this.groupBoxUslovie_PIA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxUslovie_PIA.Name = "groupBoxUslovie_PIA";
            this.groupBoxUslovie_PIA.Size = new System.Drawing.Size(747, 221);
            this.groupBoxUslovie_PIA.TabIndex = 0;
            this.groupBoxUslovie_PIA.TabStop = false;
            this.groupBoxUslovie_PIA.Text = "Условие";
            // 
            // textBoxZadanie_PIA
            // 
            this.textBoxZadanie_PIA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxZadanie_PIA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxZadanie_PIA.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxZadanie_PIA.Location = new System.Drawing.Point(6, 19);
            this.textBoxZadanie_PIA.Multiline = true;
            this.textBoxZadanie_PIA.Name = "textBoxZadanie_PIA";
            this.textBoxZadanie_PIA.Size = new System.Drawing.Size(211, 196);
            this.textBoxZadanie_PIA.TabIndex = 0;
            this.textBoxZadanie_PIA.Text = "Вывести таблицу значений функции:\r\nЗначения занести в график";
            // 
            // groupBoxVvod_PIA
            // 
            this.groupBoxVvod_PIA.Controls.Add(this.textBoxNumberEnd_PIA);
            this.groupBoxVvod_PIA.Controls.Add(this.textBoxNumberStart_PIA);
            this.groupBoxVvod_PIA.Controls.Add(this.textBoxKonec_PIA);
            this.groupBoxVvod_PIA.Controls.Add(this.textBoxStart_PIA);
            this.groupBoxVvod_PIA.Location = new System.Drawing.Point(12, 239);
            this.groupBoxVvod_PIA.Name = "groupBoxVvod_PIA";
            this.groupBoxVvod_PIA.Size = new System.Drawing.Size(371, 81);
            this.groupBoxVvod_PIA.TabIndex = 0;
            this.groupBoxVvod_PIA.TabStop = false;
            this.groupBoxVvod_PIA.Text = "Ввод данных";
            // 
            // textBoxNumberEnd_PIA
            // 
            this.textBoxNumberEnd_PIA.Location = new System.Drawing.Point(249, 42);
            this.textBoxNumberEnd_PIA.Name = "textBoxNumberEnd_PIA";
            this.textBoxNumberEnd_PIA.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumberEnd_PIA.TabIndex = 3;
            this.textBoxNumberEnd_PIA.TextChanged += new System.EventHandler(this.textBoxNumberEnd_PIA_TextChanged);
            // 
            // textBoxNumberStart_PIA
            // 
            this.textBoxNumberStart_PIA.Location = new System.Drawing.Point(117, 42);
            this.textBoxNumberStart_PIA.Name = "textBoxNumberStart_PIA";
            this.textBoxNumberStart_PIA.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumberStart_PIA.TabIndex = 2;
            // 
            // textBoxKonec_PIA
            // 
            this.textBoxKonec_PIA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxKonec_PIA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxKonec_PIA.Location = new System.Drawing.Point(249, 16);
            this.textBoxKonec_PIA.Name = "textBoxKonec_PIA";
            this.textBoxKonec_PIA.Size = new System.Drawing.Size(100, 13);
            this.textBoxKonec_PIA.TabIndex = 1;
            this.textBoxKonec_PIA.Text = "Конец шага:";
            // 
            // textBoxStart_PIA
            // 
            this.textBoxStart_PIA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxStart_PIA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStart_PIA.Location = new System.Drawing.Point(117, 16);
            this.textBoxStart_PIA.Name = "textBoxStart_PIA";
            this.textBoxStart_PIA.Size = new System.Drawing.Size(100, 13);
            this.textBoxStart_PIA.TabIndex = 0;
            this.textBoxStart_PIA.Text = "Старт шага:";
            // 
            // groupBoxVivod_PIA
            // 
            this.groupBoxVivod_PIA.Controls.Add(this.chartFunction_PIA);
            this.groupBoxVivod_PIA.Controls.Add(this.textBoxResultat_PIA);
            this.groupBoxVivod_PIA.Controls.Add(this.dataGridViewFunction_PIA);
            this.groupBoxVivod_PIA.Location = new System.Drawing.Point(765, 12);
            this.groupBoxVivod_PIA.Name = "groupBoxVivod_PIA";
            this.groupBoxVivod_PIA.Size = new System.Drawing.Size(541, 308);
            this.groupBoxVivod_PIA.TabIndex = 0;
            this.groupBoxVivod_PIA.TabStop = false;
            this.groupBoxVivod_PIA.Text = "Вывод данных";
            // 
            // textBoxResultat_PIA
            // 
            this.textBoxResultat_PIA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxResultat_PIA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResultat_PIA.Location = new System.Drawing.Point(6, 19);
            this.textBoxResultat_PIA.Name = "textBoxResultat_PIA";
            this.textBoxResultat_PIA.Size = new System.Drawing.Size(100, 13);
            this.textBoxResultat_PIA.TabIndex = 1;
            this.textBoxResultat_PIA.Text = "Результат:";
            // 
            // dataGridViewFunction_PIA
            // 
            this.dataGridViewFunction_PIA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_PIA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnViewX,
            this.ColumnVievFX});
            this.dataGridViewFunction_PIA.Location = new System.Drawing.Point(6, 38);
            this.dataGridViewFunction_PIA.Name = "dataGridViewFunction_PIA";
            this.dataGridViewFunction_PIA.RowHeadersVisible = false;
            this.dataGridViewFunction_PIA.Size = new System.Drawing.Size(100, 251);
            this.dataGridViewFunction_PIA.TabIndex = 0;
            // 
            // buttonDone_PIA
            // 
            this.buttonDone_PIA.BackColor = System.Drawing.Color.Lime;
            this.buttonDone_PIA.Location = new System.Drawing.Point(572, 239);
            this.buttonDone_PIA.Name = "buttonDone_PIA";
            this.buttonDone_PIA.Size = new System.Drawing.Size(181, 81);
            this.buttonDone_PIA.TabIndex = 1;
            this.buttonDone_PIA.Text = "Выполнить";
            this.buttonDone_PIA.UseVisualStyleBackColor = false;
            this.buttonDone_PIA.Click += new System.EventHandler(this.buttonDone_PIA_Click);
            this.buttonDone_PIA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_PIA_MouseDown);
            this.buttonDone_PIA.MouseEnter += new System.EventHandler(this.buttonDone_PIA_MouseEnter);
            this.buttonDone_PIA.MouseLeave += new System.EventHandler(this.buttonDone_PIA_MouseLeave);
            // 
            // buttonReference_PIA
            // 
            this.buttonReference_PIA.BackColor = System.Drawing.Color.Aqua;
            this.buttonReference_PIA.Location = new System.Drawing.Point(421, 239);
            this.buttonReference_PIA.Name = "buttonReference_PIA";
            this.buttonReference_PIA.Size = new System.Drawing.Size(106, 81);
            this.buttonReference_PIA.TabIndex = 2;
            this.buttonReference_PIA.Text = "Справка";
            this.buttonReference_PIA.UseVisualStyleBackColor = false;
            this.buttonReference_PIA.Click += new System.EventHandler(this.buttonReference_PIA_Click);
            this.buttonReference_PIA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonReference_PIA_MouseDown);
            this.buttonReference_PIA.MouseEnter += new System.EventHandler(this.buttonReference_PIA_MouseEnter);
            this.buttonReference_PIA.MouseLeave += new System.EventHandler(this.buttonReference_PIA_MouseLeave);
            // 
            // chartFunction_PIA
            // 
            chartArea10.Name = "ChartArea1";
            this.chartFunction_PIA.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.chartFunction_PIA.Legends.Add(legend10);
            this.chartFunction_PIA.Location = new System.Drawing.Point(123, 38);
            this.chartFunction_PIA.Name = "chartFunction_PIA";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series10.IsVisibleInLegend = false;
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            this.chartFunction_PIA.Series.Add(series10);
            this.chartFunction_PIA.Size = new System.Drawing.Size(412, 251);
            this.chartFunction_PIA.TabIndex = 2;
            this.chartFunction_PIA.Text = "chart1";
            // 
            // ColumnViewX
            // 
            this.ColumnViewX.HeaderText = "X";
            this.ColumnViewX.Name = "ColumnViewX";
            this.ColumnViewX.Width = 50;
            // 
            // ColumnVievFX
            // 
            this.ColumnVievFX.HeaderText = "F(X)";
            this.ColumnVievFX.Name = "ColumnVievFX";
            this.ColumnVievFX.Width = 50;
            // 
            // pictureBoxFormula_PIA
            // 
            this.pictureBoxFormula_PIA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_PIA.Image")));
            this.pictureBoxFormula_PIA.Location = new System.Drawing.Point(223, 19);
            this.pictureBoxFormula_PIA.Name = "pictureBoxFormula_PIA";
            this.pictureBoxFormula_PIA.Size = new System.Drawing.Size(247, 38);
            this.pictureBoxFormula_PIA.TabIndex = 1;
            this.pictureBoxFormula_PIA.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 332);
            this.Controls.Add(this.buttonReference_PIA);
            this.Controls.Add(this.buttonDone_PIA);
            this.Controls.Add(this.groupBoxVvod_PIA);
            this.Controls.Add(this.groupBoxVivod_PIA);
            this.Controls.Add(this.groupBoxUslovie_PIA);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таст 2 | Вариант 14 | Позняк И.А.";
            this.groupBoxUslovie_PIA.ResumeLayout(false);
            this.groupBoxUslovie_PIA.PerformLayout();
            this.groupBoxVvod_PIA.ResumeLayout(false);
            this.groupBoxVvod_PIA.PerformLayout();
            this.groupBoxVivod_PIA.ResumeLayout(false);
            this.groupBoxVivod_PIA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_PIA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_PIA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_PIA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUslovie_PIA;
        private System.Windows.Forms.TextBox textBoxZadanie_PIA;
        private System.Windows.Forms.GroupBox groupBoxVvod_PIA;
        private System.Windows.Forms.TextBox textBoxNumberEnd_PIA;
        private System.Windows.Forms.TextBox textBoxNumberStart_PIA;
        private System.Windows.Forms.TextBox textBoxKonec_PIA;
        private System.Windows.Forms.TextBox textBoxStart_PIA;
        private System.Windows.Forms.GroupBox groupBoxVivod_PIA;
        private System.Windows.Forms.TextBox textBoxResultat_PIA;
        private System.Windows.Forms.DataGridView dataGridViewFunction_PIA;
        private System.Windows.Forms.Button buttonDone_PIA;
        private System.Windows.Forms.Button buttonReference_PIA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_PIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnViewX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVievFX;
        private System.Windows.Forms.PictureBox pictureBoxFormula_PIA;
    }
}


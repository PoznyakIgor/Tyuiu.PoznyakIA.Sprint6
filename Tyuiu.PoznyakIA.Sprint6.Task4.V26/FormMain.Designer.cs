
namespace Tyuiu.PoznyakIA.Sprint6.Task4.V26
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_PIA));
            this.groupBoxUslovie_PIA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_PIA = new System.Windows.Forms.TextBox();
            this.groupBoxVivod_PIA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_PIA = new System.Windows.Forms.TextBox();
            this.groupBoxVvod_PIA = new System.Windows.Forms.GroupBox();
            this.textBoxVinStart_PIA = new System.Windows.Forms.TextBox();
            this.textBoxVinEnd_PIA = new System.Windows.Forms.TextBox();
            this.textBoxKonecShaga_PIA = new System.Windows.Forms.TextBox();
            this.textBoxStartShaga_PIA = new System.Windows.Forms.TextBox();
            this.buttonSave_PIA = new System.Windows.Forms.Button();
            this.buttonDone_PIA = new System.Windows.Forms.Button();
            this.buttonReference_PIA = new System.Windows.Forms.Button();
            this.chartFunction_PIA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelLeft_PIA = new System.Windows.Forms.Panel();
            this.panelRight_PIA = new System.Windows.Forms.Panel();
            this.panelUp_PIA = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxUslovie_PIA.SuspendLayout();
            this.groupBoxVivod_PIA.SuspendLayout();
            this.groupBoxVvod_PIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_PIA)).BeginInit();
            this.panelUp_PIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxUslovie_PIA
            // 
            this.groupBoxUslovie_PIA.BackColor = System.Drawing.Color.Aqua;
            this.groupBoxUslovie_PIA.Controls.Add(this.pictureBox1);
            this.groupBoxUslovie_PIA.Controls.Add(this.textBoxTask_PIA);
            this.groupBoxUslovie_PIA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxUslovie_PIA.Name = "groupBoxUslovie_PIA";
            this.groupBoxUslovie_PIA.Size = new System.Drawing.Size(404, 100);
            this.groupBoxUslovie_PIA.TabIndex = 0;
            this.groupBoxUslovie_PIA.TabStop = false;
            this.groupBoxUslovie_PIA.Text = "Условие:";
            // 
            // textBoxTask_PIA
            // 
            this.textBoxTask_PIA.BackColor = System.Drawing.Color.Aqua;
            this.textBoxTask_PIA.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask_PIA.Multiline = true;
            this.textBoxTask_PIA.Name = "textBoxTask_PIA";
            this.textBoxTask_PIA.Size = new System.Drawing.Size(215, 75);
            this.textBoxTask_PIA.TabIndex = 0;
            this.textBoxTask_PIA.Text = "Вывести в таблицу значения функции:\r\nна заданном диапазоне  [-5; 5]\r\nс шагом 1. П" +
    "роизвести проверку деления на ноль.";
            // 
            // groupBoxVivod_PIA
            // 
            this.groupBoxVivod_PIA.BackColor = System.Drawing.Color.Lime;
            this.groupBoxVivod_PIA.Controls.Add(this.textBoxResult_PIA);
            this.groupBoxVivod_PIA.Location = new System.Drawing.Point(12, 118);
            this.groupBoxVivod_PIA.Name = "groupBoxVivod_PIA";
            this.groupBoxVivod_PIA.Size = new System.Drawing.Size(221, 431);
            this.groupBoxVivod_PIA.TabIndex = 0;
            this.groupBoxVivod_PIA.TabStop = false;
            this.groupBoxVivod_PIA.Text = "Вывод:";
            // 
            // textBoxResult_PIA
            // 
            this.textBoxResult_PIA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult_PIA.Location = new System.Drawing.Point(3, 16);
            this.textBoxResult_PIA.Multiline = true;
            this.textBoxResult_PIA.Name = "textBoxResult_PIA";
            this.textBoxResult_PIA.ReadOnly = true;
            this.textBoxResult_PIA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_PIA.Size = new System.Drawing.Size(215, 412);
            this.textBoxResult_PIA.TabIndex = 0;
            // 
            // groupBoxVvod_PIA
            // 
            this.groupBoxVvod_PIA.BackColor = System.Drawing.Color.Aqua;
            this.groupBoxVvod_PIA.Controls.Add(this.textBoxVinStart_PIA);
            this.groupBoxVvod_PIA.Controls.Add(this.textBoxVinEnd_PIA);
            this.groupBoxVvod_PIA.Controls.Add(this.textBoxKonecShaga_PIA);
            this.groupBoxVvod_PIA.Controls.Add(this.textBoxStartShaga_PIA);
            this.groupBoxVvod_PIA.Location = new System.Drawing.Point(422, 12);
            this.groupBoxVvod_PIA.Name = "groupBoxVvod_PIA";
            this.groupBoxVvod_PIA.Size = new System.Drawing.Size(239, 100);
            this.groupBoxVvod_PIA.TabIndex = 0;
            this.groupBoxVvod_PIA.TabStop = false;
            this.groupBoxVvod_PIA.Text = "Ввод данных:";
            // 
            // textBoxVinStart_PIA
            // 
            this.textBoxVinStart_PIA.Location = new System.Drawing.Point(6, 46);
            this.textBoxVinStart_PIA.Name = "textBoxVinStart_PIA";
            this.textBoxVinStart_PIA.Size = new System.Drawing.Size(100, 20);
            this.textBoxVinStart_PIA.TabIndex = 3;
            // 
            // textBoxVinEnd_PIA
            // 
            this.textBoxVinEnd_PIA.Location = new System.Drawing.Point(112, 46);
            this.textBoxVinEnd_PIA.Name = "textBoxVinEnd_PIA";
            this.textBoxVinEnd_PIA.Size = new System.Drawing.Size(100, 20);
            this.textBoxVinEnd_PIA.TabIndex = 2;
            // 
            // textBoxKonecShaga_PIA
            // 
            this.textBoxKonecShaga_PIA.BackColor = System.Drawing.Color.Aqua;
            this.textBoxKonecShaga_PIA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxKonecShaga_PIA.Location = new System.Drawing.Point(112, 27);
            this.textBoxKonecShaga_PIA.Name = "textBoxKonecShaga_PIA";
            this.textBoxKonecShaga_PIA.Size = new System.Drawing.Size(100, 13);
            this.textBoxKonecShaga_PIA.TabIndex = 1;
            this.textBoxKonecShaga_PIA.Text = "Конец шага:";
            // 
            // textBoxStartShaga_PIA
            // 
            this.textBoxStartShaga_PIA.BackColor = System.Drawing.Color.Aqua;
            this.textBoxStartShaga_PIA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStartShaga_PIA.Location = new System.Drawing.Point(6, 27);
            this.textBoxStartShaga_PIA.Name = "textBoxStartShaga_PIA";
            this.textBoxStartShaga_PIA.Size = new System.Drawing.Size(100, 13);
            this.textBoxStartShaga_PIA.TabIndex = 0;
            this.textBoxStartShaga_PIA.Text = "Старт шага:";
            // 
            // buttonSave_PIA
            // 
            this.buttonSave_PIA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonSave_PIA.Location = new System.Drawing.Point(772, 31);
            this.buttonSave_PIA.Name = "buttonSave_PIA";
            this.buttonSave_PIA.Size = new System.Drawing.Size(91, 54);
            this.buttonSave_PIA.TabIndex = 1;
            this.buttonSave_PIA.Text = "Сохранить";
            this.buttonSave_PIA.UseVisualStyleBackColor = false;
            this.buttonSave_PIA.Click += new System.EventHandler(this.buttonSave_PIA_Click);
            // 
            // buttonDone_PIA
            // 
            this.buttonDone_PIA.BackColor = System.Drawing.Color.Lime;
            this.buttonDone_PIA.Location = new System.Drawing.Point(667, 31);
            this.buttonDone_PIA.Name = "buttonDone_PIA";
            this.buttonDone_PIA.Size = new System.Drawing.Size(99, 54);
            this.buttonDone_PIA.TabIndex = 2;
            this.buttonDone_PIA.Text = "Выполнить";
            this.buttonDone_PIA.UseVisualStyleBackColor = false;
            this.buttonDone_PIA.Click += new System.EventHandler(this.buttonDone_PIA_Click);
            // 
            // buttonReference_PIA
            // 
            this.buttonReference_PIA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonReference_PIA.Location = new System.Drawing.Point(869, 31);
            this.buttonReference_PIA.Name = "buttonReference_PIA";
            this.buttonReference_PIA.Size = new System.Drawing.Size(65, 54);
            this.buttonReference_PIA.TabIndex = 3;
            this.buttonReference_PIA.Text = "Справка";
            this.buttonReference_PIA.UseVisualStyleBackColor = false;
            this.buttonReference_PIA.Click += new System.EventHandler(this.buttonReference_PIA_Click);
            // 
            // chartFunction_PIA
            // 
            this.chartFunction_PIA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            chartArea4.Name = "ChartArea1";
            this.chartFunction_PIA.ChartAreas.Add(chartArea4);
            legend4.Enabled = false;
            legend4.Name = "Legend1";
            this.chartFunction_PIA.Legends.Add(legend4);
            this.chartFunction_PIA.Location = new System.Drawing.Point(239, 118);
            this.chartFunction_PIA.Name = "chartFunction_PIA";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartFunction_PIA.Series.Add(series4);
            this.chartFunction_PIA.Size = new System.Drawing.Size(695, 431);
            this.chartFunction_PIA.TabIndex = 4;
            this.chartFunction_PIA.Text = "chartFunction";
            title4.Name = "TitleFunction_PIA";
            title4.Text = "График функции";
            this.chartFunction_PIA.Titles.Add(title4);
            // 
            // panelLeft_PIA
            // 
            this.panelLeft_PIA.BackColor = System.Drawing.Color.Lime;
            this.panelLeft_PIA.Location = new System.Drawing.Point(1, 112);
            this.panelLeft_PIA.Name = "panelLeft_PIA";
            this.panelLeft_PIA.Size = new System.Drawing.Size(232, 448);
            this.panelLeft_PIA.TabIndex = 5;
            // 
            // panelRight_PIA
            // 
            this.panelRight_PIA.BackColor = System.Drawing.Color.Maroon;
            this.panelRight_PIA.Location = new System.Drawing.Point(232, 111);
            this.panelRight_PIA.Name = "panelRight_PIA";
            this.panelRight_PIA.Size = new System.Drawing.Size(726, 448);
            this.panelRight_PIA.TabIndex = 0;
            // 
            // panelUp_PIA
            // 
            this.panelUp_PIA.BackColor = System.Drawing.Color.Aqua;
            this.panelUp_PIA.Controls.Add(this.panelRight_PIA);
            this.panelUp_PIA.Location = new System.Drawing.Point(1, 1);
            this.panelUp_PIA.Name = "panelUp_PIA";
            this.panelUp_PIA.Size = new System.Drawing.Size(958, 111);
            this.panelUp_PIA.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(227, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 33);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormMain_PIA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 561);
            this.Controls.Add(this.chartFunction_PIA);
            this.Controls.Add(this.buttonReference_PIA);
            this.Controls.Add(this.buttonDone_PIA);
            this.Controls.Add(this.buttonSave_PIA);
            this.Controls.Add(this.groupBoxVivod_PIA);
            this.Controls.Add(this.groupBoxVvod_PIA);
            this.Controls.Add(this.groupBoxUslovie_PIA);
            this.Controls.Add(this.panelUp_PIA);
            this.Controls.Add(this.panelLeft_PIA);
            this.MinimumSize = new System.Drawing.Size(975, 600);
            this.Name = "FormMain_PIA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 26 | Позняк И.А.";
            this.groupBoxUslovie_PIA.ResumeLayout(false);
            this.groupBoxUslovie_PIA.PerformLayout();
            this.groupBoxVivod_PIA.ResumeLayout(false);
            this.groupBoxVivod_PIA.PerformLayout();
            this.groupBoxVvod_PIA.ResumeLayout(false);
            this.groupBoxVvod_PIA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_PIA)).EndInit();
            this.panelUp_PIA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUslovie_PIA;
        private System.Windows.Forms.TextBox textBoxTask_PIA;
        private System.Windows.Forms.GroupBox groupBoxVivod_PIA;
        private System.Windows.Forms.GroupBox groupBoxVvod_PIA;
        private System.Windows.Forms.TextBox textBoxResult_PIA;
        private System.Windows.Forms.TextBox textBoxVinStart_PIA;
        private System.Windows.Forms.TextBox textBoxVinEnd_PIA;
        private System.Windows.Forms.TextBox textBoxKonecShaga_PIA;
        private System.Windows.Forms.TextBox textBoxStartShaga_PIA;
        private System.Windows.Forms.Button buttonSave_PIA;
        private System.Windows.Forms.Button buttonDone_PIA;
        private System.Windows.Forms.Button buttonReference_PIA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_PIA;
        private System.Windows.Forms.Panel panelUp_PIA;
        private System.Windows.Forms.Panel panelLeft_PIA;
        private System.Windows.Forms.Panel panelRight_PIA;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


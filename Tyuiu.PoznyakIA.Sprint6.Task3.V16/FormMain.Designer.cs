
namespace Tyuiu.PoznyakIA.Sprint6.Task3.V16
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxUslovie_PIA = new System.Windows.Forms.GroupBox();
            this.textBoxZadanie_PIA = new System.Windows.Forms.TextBox();
            this.buttonDone_PIA = new System.Windows.Forms.Button();
            this.buttonReference_PIA = new System.Windows.Forms.Button();
            this.groupBoxResultat_PIA = new System.Windows.Forms.GroupBox();
            this.dataGridViewMatrix_PIA = new System.Windows.Forms.DataGridView();
            this.ColumnTroyan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPompeya = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGots = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAvrelya = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxChtoDelat_PIA = new System.Windows.Forms.TextBox();
            this.pictureBoxMatrica_PIA = new System.Windows.Forms.PictureBox();
            this.groupBoxUslovie_PIA.SuspendLayout();
            this.groupBoxResultat_PIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_PIA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMatrica_PIA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxUslovie_PIA
            // 
            this.groupBoxUslovie_PIA.Controls.Add(this.pictureBoxMatrica_PIA);
            this.groupBoxUslovie_PIA.Controls.Add(this.textBoxChtoDelat_PIA);
            this.groupBoxUslovie_PIA.Controls.Add(this.textBoxZadanie_PIA);
            this.groupBoxUslovie_PIA.Location = new System.Drawing.Point(0, 12);
            this.groupBoxUslovie_PIA.Name = "groupBoxUslovie_PIA";
            this.groupBoxUslovie_PIA.Size = new System.Drawing.Size(279, 281);
            this.groupBoxUslovie_PIA.TabIndex = 0;
            this.groupBoxUslovie_PIA.TabStop = false;
            this.groupBoxUslovie_PIA.Text = "Условие";
            // 
            // textBoxZadanie_PIA
            // 
            this.textBoxZadanie_PIA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxZadanie_PIA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxZadanie_PIA.Location = new System.Drawing.Point(12, 19);
            this.textBoxZadanie_PIA.Name = "textBoxZadanie_PIA";
            this.textBoxZadanie_PIA.Size = new System.Drawing.Size(262, 13);
            this.textBoxZadanie_PIA.TabIndex = 0;
            this.textBoxZadanie_PIA.Text = "Дана матрица 5 на 5 элементов.\r\n\r\n";
            // 
            // buttonDone_PIA
            // 
            this.buttonDone_PIA.Location = new System.Drawing.Point(422, 270);
            this.buttonDone_PIA.Name = "buttonDone_PIA";
            this.buttonDone_PIA.Size = new System.Drawing.Size(75, 23);
            this.buttonDone_PIA.TabIndex = 1;
            this.buttonDone_PIA.Text = "Выполнить";
            this.buttonDone_PIA.UseVisualStyleBackColor = true;
            this.buttonDone_PIA.Click += new System.EventHandler(this.buttonDone_PIA_Click);
            // 
            // buttonReference_PIA
            // 
            this.buttonReference_PIA.Location = new System.Drawing.Point(392, 270);
            this.buttonReference_PIA.Name = "buttonReference_PIA";
            this.buttonReference_PIA.Size = new System.Drawing.Size(24, 23);
            this.buttonReference_PIA.TabIndex = 2;
            this.buttonReference_PIA.Text = "?";
            this.buttonReference_PIA.UseVisualStyleBackColor = true;
            this.buttonReference_PIA.Click += new System.EventHandler(this.buttonReference_PIA_Click);
            // 
            // groupBoxResultat_PIA
            // 
            this.groupBoxResultat_PIA.Controls.Add(this.dataGridViewMatrix_PIA);
            this.groupBoxResultat_PIA.Location = new System.Drawing.Point(285, 12);
            this.groupBoxResultat_PIA.Name = "groupBoxResultat_PIA";
            this.groupBoxResultat_PIA.Size = new System.Drawing.Size(212, 246);
            this.groupBoxResultat_PIA.TabIndex = 3;
            this.groupBoxResultat_PIA.TabStop = false;
            this.groupBoxResultat_PIA.Text = "Результат";
            // 
            // dataGridViewMatrix_PIA
            // 
            this.dataGridViewMatrix_PIA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_PIA.ColumnHeadersVisible = false;
            this.dataGridViewMatrix_PIA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTroyan,
            this.ColumnPompeya,
            this.ColumnGots,
            this.ColumnPia,
            this.ColumnAvrelya});
            this.dataGridViewMatrix_PIA.Location = new System.Drawing.Point(14, 29);
            this.dataGridViewMatrix_PIA.Name = "dataGridViewMatrix_PIA";
            this.dataGridViewMatrix_PIA.ReadOnly = true;
            this.dataGridViewMatrix_PIA.RowHeadersVisible = false;
            this.dataGridViewMatrix_PIA.Size = new System.Drawing.Size(192, 211);
            this.dataGridViewMatrix_PIA.TabIndex = 2;
            // 
            // ColumnTroyan
            // 
            this.ColumnTroyan.HeaderText = "1";
            this.ColumnTroyan.Name = "ColumnTroyan";
            this.ColumnTroyan.ReadOnly = true;
            this.ColumnTroyan.Width = 30;
            // 
            // ColumnPompeya
            // 
            this.ColumnPompeya.HeaderText = "2";
            this.ColumnPompeya.Name = "ColumnPompeya";
            this.ColumnPompeya.ReadOnly = true;
            this.ColumnPompeya.Width = 30;
            // 
            // ColumnGots
            // 
            this.ColumnGots.HeaderText = "3";
            this.ColumnGots.Name = "ColumnGots";
            this.ColumnGots.ReadOnly = true;
            this.ColumnGots.Width = 30;
            // 
            // ColumnPia
            // 
            this.ColumnPia.HeaderText = "4";
            this.ColumnPia.Name = "ColumnPia";
            this.ColumnPia.ReadOnly = true;
            this.ColumnPia.Width = 30;
            // 
            // ColumnAvrelya
            // 
            this.ColumnAvrelya.HeaderText = "5";
            this.ColumnAvrelya.Name = "ColumnAvrelya";
            this.ColumnAvrelya.ReadOnly = true;
            this.ColumnAvrelya.Width = 30;
            // 
            // textBoxChtoDelat_PIA
            // 
            this.textBoxChtoDelat_PIA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxChtoDelat_PIA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxChtoDelat_PIA.Location = new System.Drawing.Point(12, 192);
            this.textBoxChtoDelat_PIA.Name = "textBoxChtoDelat_PIA";
            this.textBoxChtoDelat_PIA.Size = new System.Drawing.Size(261, 13);
            this.textBoxChtoDelat_PIA.TabIndex = 1;
            this.textBoxChtoDelat_PIA.Text = "Заменить четные значения в третьей строке на 0";
            // 
            // pictureBoxMatrica_PIA
            // 
            this.pictureBoxMatrica_PIA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMatrica_PIA.Image")));
            this.pictureBoxMatrica_PIA.Location = new System.Drawing.Point(12, 38);
            this.pictureBoxMatrica_PIA.Name = "pictureBoxMatrica_PIA";
            this.pictureBoxMatrica_PIA.Size = new System.Drawing.Size(150, 148);
            this.pictureBoxMatrica_PIA.TabIndex = 2;
            this.pictureBoxMatrica_PIA.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 305);
            this.Controls.Add(this.groupBoxResultat_PIA);
            this.Controls.Add(this.buttonReference_PIA);
            this.Controls.Add(this.buttonDone_PIA);
            this.Controls.Add(this.groupBoxUslovie_PIA);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 16 | Позняк И.А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxUslovie_PIA.ResumeLayout(false);
            this.groupBoxUslovie_PIA.PerformLayout();
            this.groupBoxResultat_PIA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_PIA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMatrica_PIA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUslovie_PIA;
        private System.Windows.Forms.TextBox textBoxZadanie_PIA;
        private System.Windows.Forms.Button buttonDone_PIA;
        private System.Windows.Forms.Button buttonReference_PIA;
        private System.Windows.Forms.PictureBox pictureBoxMatrica_PIA;
        private System.Windows.Forms.TextBox textBoxChtoDelat_PIA;
        private System.Windows.Forms.GroupBox groupBoxResultat_PIA;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_PIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTroyan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPompeya;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGots;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAvrelya;
    }
}



namespace Tyuiu.PoznyakIA.Sprint6.Task1.V29
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
            this.groupBoxVvod_PIA = new System.Windows.Forms.GroupBox();
            this.groupBoxVivod_PIA = new System.Windows.Forms.GroupBox();
            this.buttonDone_PIA = new System.Windows.Forms.Button();
            this.buttonReference_PIA = new System.Windows.Forms.Button();
            this.textBoxZadanie_PIA = new System.Windows.Forms.TextBox();
            this.textBoxResultat_PIA = new System.Windows.Forms.TextBox();
            this.textBoxStartShaga_PIA = new System.Windows.Forms.TextBox();
            this.textBoxKonec_PIA = new System.Windows.Forms.TextBox();
            this.textBoxNumberStart_PIA = new System.Windows.Forms.TextBox();
            this.textBoxNumberEnd_PIA = new System.Windows.Forms.TextBox();
            this.textBoxResult_PIA = new System.Windows.Forms.TextBox();
            this.pictureBoxFormula_PIA = new System.Windows.Forms.PictureBox();
            this.groupBoxUslovie_PIA.SuspendLayout();
            this.groupBoxVvod_PIA.SuspendLayout();
            this.groupBoxVivod_PIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_PIA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxUslovie_PIA
            // 
            this.groupBoxUslovie_PIA.Controls.Add(this.pictureBoxFormula_PIA);
            this.groupBoxUslovie_PIA.Controls.Add(this.textBoxZadanie_PIA);
            this.groupBoxUslovie_PIA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxUslovie_PIA.Name = "groupBoxUslovie_PIA";
            this.groupBoxUslovie_PIA.Size = new System.Drawing.Size(688, 271);
            this.groupBoxUslovie_PIA.TabIndex = 0;
            this.groupBoxUslovie_PIA.TabStop = false;
            this.groupBoxUslovie_PIA.Text = "Условие:";
            // 
            // groupBoxVvod_PIA
            // 
            this.groupBoxVvod_PIA.Controls.Add(this.textBoxNumberEnd_PIA);
            this.groupBoxVvod_PIA.Controls.Add(this.textBoxNumberStart_PIA);
            this.groupBoxVvod_PIA.Controls.Add(this.textBoxKonec_PIA);
            this.groupBoxVvod_PIA.Controls.Add(this.textBoxStartShaga_PIA);
            this.groupBoxVvod_PIA.Location = new System.Drawing.Point(12, 289);
            this.groupBoxVvod_PIA.Name = "groupBoxVvod_PIA";
            this.groupBoxVvod_PIA.Size = new System.Drawing.Size(371, 74);
            this.groupBoxVvod_PIA.TabIndex = 0;
            this.groupBoxVvod_PIA.TabStop = false;
            this.groupBoxVvod_PIA.Text = "Ввод данных:";
            // 
            // groupBoxVivod_PIA
            // 
            this.groupBoxVivod_PIA.Controls.Add(this.textBoxResult_PIA);
            this.groupBoxVivod_PIA.Controls.Add(this.textBoxResultat_PIA);
            this.groupBoxVivod_PIA.Location = new System.Drawing.Point(706, 12);
            this.groupBoxVivod_PIA.Name = "groupBoxVivod_PIA";
            this.groupBoxVivod_PIA.Size = new System.Drawing.Size(240, 351);
            this.groupBoxVivod_PIA.TabIndex = 0;
            this.groupBoxVivod_PIA.TabStop = false;
            this.groupBoxVivod_PIA.Text = "Вывод данных:";
            // 
            // buttonDone_PIA
            // 
            this.buttonDone_PIA.BackColor = System.Drawing.Color.Green;
            this.buttonDone_PIA.Location = new System.Drawing.Point(502, 310);
            this.buttonDone_PIA.Name = "buttonDone_PIA";
            this.buttonDone_PIA.Size = new System.Drawing.Size(198, 53);
            this.buttonDone_PIA.TabIndex = 1;
            this.buttonDone_PIA.Text = "Выполнить";
            this.buttonDone_PIA.UseVisualStyleBackColor = false;
            this.buttonDone_PIA.Click += new System.EventHandler(this.buttonDone_PIA_Click);
            // 
            // buttonReference_PIA
            // 
            this.buttonReference_PIA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonReference_PIA.Location = new System.Drawing.Point(389, 310);
            this.buttonReference_PIA.Name = "buttonReference_PIA";
            this.buttonReference_PIA.Size = new System.Drawing.Size(107, 53);
            this.buttonReference_PIA.TabIndex = 2;
            this.buttonReference_PIA.Text = "Справка";
            this.buttonReference_PIA.UseVisualStyleBackColor = false;
            this.buttonReference_PIA.Click += new System.EventHandler(this.buttonReference_PIA_Click);
            // 
            // textBoxZadanie_PIA
            // 
            this.textBoxZadanie_PIA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxZadanie_PIA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxZadanie_PIA.Location = new System.Drawing.Point(6, 25);
            this.textBoxZadanie_PIA.Multiline = true;
            this.textBoxZadanie_PIA.Name = "textBoxZadanie_PIA";
            this.textBoxZadanie_PIA.ReadOnly = true;
            this.textBoxZadanie_PIA.Size = new System.Drawing.Size(201, 240);
            this.textBoxZadanie_PIA.TabIndex = 0;
            this.textBoxZadanie_PIA.Text = "Вывод таблицы значений функции:\r\nРезультат вывести в виде таблицы.";
            // 
            // textBoxResultat_PIA
            // 
            this.textBoxResultat_PIA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxResultat_PIA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResultat_PIA.Location = new System.Drawing.Point(6, 19);
            this.textBoxResultat_PIA.Name = "textBoxResultat_PIA";
            this.textBoxResultat_PIA.ReadOnly = true;
            this.textBoxResultat_PIA.Size = new System.Drawing.Size(100, 13);
            this.textBoxResultat_PIA.TabIndex = 0;
            this.textBoxResultat_PIA.Text = "Результат:";
            // 
            // textBoxStartShaga_PIA
            // 
            this.textBoxStartShaga_PIA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxStartShaga_PIA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStartShaga_PIA.Location = new System.Drawing.Point(107, 12);
            this.textBoxStartShaga_PIA.Name = "textBoxStartShaga_PIA";
            this.textBoxStartShaga_PIA.ReadOnly = true;
            this.textBoxStartShaga_PIA.Size = new System.Drawing.Size(100, 13);
            this.textBoxStartShaga_PIA.TabIndex = 0;
            this.textBoxStartShaga_PIA.Text = "Старт шага:";
            // 
            // textBoxKonec_PIA
            // 
            this.textBoxKonec_PIA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxKonec_PIA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxKonec_PIA.Location = new System.Drawing.Point(265, 12);
            this.textBoxKonec_PIA.Name = "textBoxKonec_PIA";
            this.textBoxKonec_PIA.ReadOnly = true;
            this.textBoxKonec_PIA.Size = new System.Drawing.Size(100, 13);
            this.textBoxKonec_PIA.TabIndex = 1;
            this.textBoxKonec_PIA.Text = "Конец шага:";
            // 
            // textBoxNumberStart_PIA
            // 
            this.textBoxNumberStart_PIA.Location = new System.Drawing.Point(107, 38);
            this.textBoxNumberStart_PIA.Name = "textBoxNumberStart_PIA";
            this.textBoxNumberStart_PIA.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumberStart_PIA.TabIndex = 2;
            // 
            // textBoxNumberEnd_PIA
            // 
            this.textBoxNumberEnd_PIA.Location = new System.Drawing.Point(265, 38);
            this.textBoxNumberEnd_PIA.Name = "textBoxNumberEnd_PIA";
            this.textBoxNumberEnd_PIA.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumberEnd_PIA.TabIndex = 3;
            // 
            // textBoxResult_PIA
            // 
            this.textBoxResult_PIA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxResult_PIA.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_PIA.Location = new System.Drawing.Point(6, 38);
            this.textBoxResult_PIA.Multiline = true;
            this.textBoxResult_PIA.Name = "textBoxResult_PIA";
            this.textBoxResult_PIA.ReadOnly = true;
            this.textBoxResult_PIA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_PIA.Size = new System.Drawing.Size(228, 307);
            this.textBoxResult_PIA.TabIndex = 1;
            // 
            // pictureBoxFormula_PIA
            // 
            this.pictureBoxFormula_PIA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_PIA.Image")));
            this.pictureBoxFormula_PIA.Location = new System.Drawing.Point(213, 19);
            this.pictureBoxFormula_PIA.Name = "pictureBoxFormula_PIA";
            this.pictureBoxFormula_PIA.Size = new System.Drawing.Size(323, 44);
            this.pictureBoxFormula_PIA.TabIndex = 1;
            this.pictureBoxFormula_PIA.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 375);
            this.Controls.Add(this.buttonReference_PIA);
            this.Controls.Add(this.buttonDone_PIA);
            this.Controls.Add(this.groupBoxVvod_PIA);
            this.Controls.Add(this.groupBoxVivod_PIA);
            this.Controls.Add(this.groupBoxUslovie_PIA);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 29 | Позняк И.А.";
            this.groupBoxUslovie_PIA.ResumeLayout(false);
            this.groupBoxUslovie_PIA.PerformLayout();
            this.groupBoxVvod_PIA.ResumeLayout(false);
            this.groupBoxVvod_PIA.PerformLayout();
            this.groupBoxVivod_PIA.ResumeLayout(false);
            this.groupBoxVivod_PIA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_PIA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUslovie_PIA;
        private System.Windows.Forms.GroupBox groupBoxVvod_PIA;
        private System.Windows.Forms.GroupBox groupBoxVivod_PIA;
        private System.Windows.Forms.PictureBox pictureBoxFormula_PIA;
        private System.Windows.Forms.TextBox textBoxZadanie_PIA;
        private System.Windows.Forms.TextBox textBoxNumberEnd_PIA;
        private System.Windows.Forms.TextBox textBoxNumberStart_PIA;
        private System.Windows.Forms.TextBox textBoxKonec_PIA;
        private System.Windows.Forms.TextBox textBoxStartShaga_PIA;
        private System.Windows.Forms.TextBox textBoxResult_PIA;
        private System.Windows.Forms.TextBox textBoxResultat_PIA;
        private System.Windows.Forms.Button buttonDone_PIA;
        private System.Windows.Forms.Button buttonReference_PIA;
    }
}


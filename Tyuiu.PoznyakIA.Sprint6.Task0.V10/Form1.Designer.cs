
namespace Tyuiu.PoznyakIA.Sprint6.Task0.V10
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBoxUslovie_PIA = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxTask_PIA = new System.Windows.Forms.TextBox();
            this.groupBoxResultBox_PIA = new System.Windows.Forms.GroupBox();
            this.textBoxResultat_PIA = new System.Windows.Forms.TextBox();
            this.textBoxResult_PIA = new System.Windows.Forms.TextBox();
            this.groupBoxVod_PIA = new System.Windows.Forms.GroupBox();
            this.textBoxPeremenayaX_PIA = new System.Windows.Forms.TextBox();
            this.buttonQueshion_PIA = new System.Windows.Forms.Button();
            this.buttonComplete_PIA = new System.Windows.Forms.Button();
            this.textBoxWinX_PIA = new System.Windows.Forms.TextBox();
            this.groupBoxUslovie_PIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxResultBox_PIA.SuspendLayout();
            this.groupBoxVod_PIA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUslovie_PIA
            // 
            this.groupBoxUslovie_PIA.Controls.Add(this.pictureBox1);
            this.groupBoxUslovie_PIA.Controls.Add(this.textBoxTask_PIA);
            this.groupBoxUslovie_PIA.Location = new System.Drawing.Point(12, 0);
            this.groupBoxUslovie_PIA.Name = "groupBoxUslovie_PIA";
            this.groupBoxUslovie_PIA.Size = new System.Drawing.Size(776, 226);
            this.groupBoxUslovie_PIA.TabIndex = 0;
            this.groupBoxUslovie_PIA.TabStop = false;
            this.groupBoxUslovie_PIA.Text = "Условие";
            this.groupBoxUslovie_PIA.Enter += new System.EventHandler(this.groupBoxUslovie_PIA_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(452, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 36);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxTask_PIA
            // 
            this.textBoxTask_PIA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_PIA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_PIA.Location = new System.Drawing.Point(18, 45);
            this.textBoxTask_PIA.Multiline = true;
            this.textBoxTask_PIA.Name = "textBoxTask_PIA";
            this.textBoxTask_PIA.ReadOnly = true;
            this.textBoxTask_PIA.Size = new System.Drawing.Size(428, 160);
            this.textBoxTask_PIA.TabIndex = 3;
            this.textBoxTask_PIA.Text = "Вычислить выражение по формуле при X=2";
            // 
            // groupBoxResultBox_PIA
            // 
            this.groupBoxResultBox_PIA.Controls.Add(this.textBoxResultat_PIA);
            this.groupBoxResultBox_PIA.Controls.Add(this.textBoxResult_PIA);
            this.groupBoxResultBox_PIA.Location = new System.Drawing.Point(527, 232);
            this.groupBoxResultBox_PIA.Name = "groupBoxResultBox_PIA";
            this.groupBoxResultBox_PIA.Size = new System.Drawing.Size(261, 126);
            this.groupBoxResultBox_PIA.TabIndex = 0;
            this.groupBoxResultBox_PIA.TabStop = false;
            this.groupBoxResultBox_PIA.Text = "Вывод данных";
            // 
            // textBoxResultat_PIA
            // 
            this.textBoxResultat_PIA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxResultat_PIA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResultat_PIA.Location = new System.Drawing.Point(15, 57);
            this.textBoxResultat_PIA.Name = "textBoxResultat_PIA";
            this.textBoxResultat_PIA.ReadOnly = true;
            this.textBoxResultat_PIA.Size = new System.Drawing.Size(100, 13);
            this.textBoxResultat_PIA.TabIndex = 2;
            this.textBoxResultat_PIA.Text = "Результат:";
            // 
            // textBoxResult_PIA
            // 
            this.textBoxResult_PIA.Location = new System.Drawing.Point(15, 76);
            this.textBoxResult_PIA.Name = "textBoxResult_PIA";
            this.textBoxResult_PIA.ReadOnly = true;
            this.textBoxResult_PIA.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult_PIA.TabIndex = 3;
            // 
            // groupBoxVod_PIA
            // 
            this.groupBoxVod_PIA.Controls.Add(this.textBoxWinX_PIA);
            this.groupBoxVod_PIA.Controls.Add(this.textBoxPeremenayaX_PIA);
            this.groupBoxVod_PIA.Location = new System.Drawing.Point(3, 232);
            this.groupBoxVod_PIA.Name = "groupBoxVod_PIA";
            this.groupBoxVod_PIA.Size = new System.Drawing.Size(518, 126);
            this.groupBoxVod_PIA.TabIndex = 0;
            this.groupBoxVod_PIA.TabStop = false;
            this.groupBoxVod_PIA.Text = "Ввод данных";
            // 
            // textBoxPeremenayaX_PIA
            // 
            this.textBoxPeremenayaX_PIA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxPeremenayaX_PIA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPeremenayaX_PIA.Location = new System.Drawing.Point(27, 57);
            this.textBoxPeremenayaX_PIA.Name = "textBoxPeremenayaX_PIA";
            this.textBoxPeremenayaX_PIA.ReadOnly = true;
            this.textBoxPeremenayaX_PIA.Size = new System.Drawing.Size(100, 13);
            this.textBoxPeremenayaX_PIA.TabIndex = 1;
            this.textBoxPeremenayaX_PIA.Text = "Переменная X:";
            // 
            // buttonQueshion_PIA
            // 
            this.buttonQueshion_PIA.Location = new System.Drawing.Point(542, 364);
            this.buttonQueshion_PIA.Name = "buttonQueshion_PIA";
            this.buttonQueshion_PIA.Size = new System.Drawing.Size(75, 74);
            this.buttonQueshion_PIA.TabIndex = 1;
            this.buttonQueshion_PIA.Text = "?";
            this.buttonQueshion_PIA.UseVisualStyleBackColor = true;
            this.buttonQueshion_PIA.Click += new System.EventHandler(this.buttonQueshion_PIA_Click);
            // 
            // buttonComplete_PIA
            // 
            this.buttonComplete_PIA.Location = new System.Drawing.Point(640, 364);
            this.buttonComplete_PIA.Name = "buttonComplete_PIA";
            this.buttonComplete_PIA.Size = new System.Drawing.Size(148, 74);
            this.buttonComplete_PIA.TabIndex = 2;
            this.buttonComplete_PIA.Text = "Выполнить";
            this.buttonComplete_PIA.UseVisualStyleBackColor = true;
            this.buttonComplete_PIA.Click += new System.EventHandler(this.buttonComplete_PIA_Click);
            // 
            // textBoxWinX_PIA
            // 
            this.textBoxWinX_PIA.Location = new System.Drawing.Point(27, 76);
            this.textBoxWinX_PIA.Name = "textBoxWinX_PIA";
            this.textBoxWinX_PIA.Size = new System.Drawing.Size(100, 20);
            this.textBoxWinX_PIA.TabIndex = 2;
            this.textBoxWinX_PIA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxWinX_PIA_KeyPress_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonComplete_PIA);
            this.Controls.Add(this.buttonQueshion_PIA);
            this.Controls.Add(this.groupBoxResultBox_PIA);
            this.Controls.Add(this.groupBoxVod_PIA);
            this.Controls.Add(this.groupBoxUslovie_PIA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 10";
            this.groupBoxUslovie_PIA.ResumeLayout(false);
            this.groupBoxUslovie_PIA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxResultBox_PIA.ResumeLayout(false);
            this.groupBoxResultBox_PIA.PerformLayout();
            this.groupBoxVod_PIA.ResumeLayout(false);
            this.groupBoxVod_PIA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUslovie_PIA;
        private System.Windows.Forms.GroupBox groupBoxResultBox_PIA;
        private System.Windows.Forms.GroupBox groupBoxVod_PIA;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxTask_PIA;
        private System.Windows.Forms.TextBox textBoxResultat_PIA;
        private System.Windows.Forms.TextBox textBoxResult_PIA;
        private System.Windows.Forms.TextBox textBoxPeremenayaX_PIA;
        private System.Windows.Forms.Button buttonQueshion_PIA;
        private System.Windows.Forms.Button buttonComplete_PIA;
        private System.Windows.Forms.TextBox textBoxWinX_PIA;
    }
}


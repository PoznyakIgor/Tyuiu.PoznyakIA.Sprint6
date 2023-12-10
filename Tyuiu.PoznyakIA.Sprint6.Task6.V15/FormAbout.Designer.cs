
namespace Tyuiu.PoznyakIA.Sprint6.Task6.V15
{
    partial class FormAbout_PIA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_PIA));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelAbout_PIA = new System.Windows.Forms.Label();
            this.buttonOk_PIA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelAbout_PIA
            // 
            this.labelAbout_PIA.AutoSize = true;
            this.labelAbout_PIA.Location = new System.Drawing.Point(180, 12);
            this.labelAbout_PIA.Name = "labelAbout_PIA";
            this.labelAbout_PIA.Size = new System.Drawing.Size(284, 130);
            this.labelAbout_PIA.TabIndex = 1;
            this.labelAbout_PIA.Text = resources.GetString("labelAbout_PIA.Text");
            // 
            // buttonOk_PIA
            // 
            this.buttonOk_PIA.Location = new System.Drawing.Point(435, 241);
            this.buttonOk_PIA.Name = "buttonOk_PIA";
            this.buttonOk_PIA.Size = new System.Drawing.Size(75, 23);
            this.buttonOk_PIA.TabIndex = 2;
            this.buttonOk_PIA.Text = "OK";
            this.buttonOk_PIA.UseVisualStyleBackColor = true;
            this.buttonOk_PIA.Click += new System.EventHandler(this.buttonOk_PIA_Click);
            // 
            // FormAbout_PIA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 276);
            this.Controls.Add(this.buttonOk_PIA);
            this.Controls.Add(this.labelAbout_PIA);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout_PIA";
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelAbout_PIA;
        private System.Windows.Forms.Button buttonOk_PIA;
    }
}
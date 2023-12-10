
namespace Tyuiu.PoznyakIA.Sprint6.Task6.V15
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonDone_PIA = new System.Windows.Forms.Button();
            this.buttonCheckFile_PIA = new System.Windows.Forms.Button();
            this.buttonReference_PIA = new System.Windows.Forms.Button();
            this.groupBoxUslovie_PIA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_PIA = new System.Windows.Forms.TextBox();
            this.groupBoxInput_PIA = new System.Windows.Forms.GroupBox();
            this.groupBoxOutputData_PIA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_PIA = new System.Windows.Forms.TextBox();
            this.openFileDialog_PIA = new System.Windows.Forms.OpenFileDialog();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxInputData_PIA = new System.Windows.Forms.TextBox();
            this.groupBoxUslovie_PIA.SuspendLayout();
            this.groupBoxInput_PIA.SuspendLayout();
            this.groupBoxOutputData_PIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDone_PIA
            // 
            this.buttonDone_PIA.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_PIA.Image")));
            this.buttonDone_PIA.Location = new System.Drawing.Point(93, 12);
            this.buttonDone_PIA.Name = "buttonDone_PIA";
            this.buttonDone_PIA.Size = new System.Drawing.Size(75, 61);
            this.buttonDone_PIA.TabIndex = 0;
            this.buttonDone_PIA.UseVisualStyleBackColor = true;
            this.buttonDone_PIA.Click += new System.EventHandler(this.buttonDone_PIA_Click);
            // 
            // buttonCheckFile_PIA
            // 
            this.buttonCheckFile_PIA.Image = ((System.Drawing.Image)(resources.GetObject("buttonCheckFile_PIA.Image")));
            this.buttonCheckFile_PIA.Location = new System.Drawing.Point(12, 12);
            this.buttonCheckFile_PIA.Name = "buttonCheckFile_PIA";
            this.buttonCheckFile_PIA.Size = new System.Drawing.Size(75, 61);
            this.buttonCheckFile_PIA.TabIndex = 1;
            this.buttonCheckFile_PIA.UseVisualStyleBackColor = true;
            this.buttonCheckFile_PIA.Click += new System.EventHandler(this.buttonCheckFile_PIA_Click);
            // 
            // buttonReference_PIA
            // 
            this.buttonReference_PIA.Image = ((System.Drawing.Image)(resources.GetObject("buttonReference_PIA.Image")));
            this.buttonReference_PIA.Location = new System.Drawing.Point(713, 8);
            this.buttonReference_PIA.Name = "buttonReference_PIA";
            this.buttonReference_PIA.Size = new System.Drawing.Size(75, 65);
            this.buttonReference_PIA.TabIndex = 2;
            this.buttonReference_PIA.UseVisualStyleBackColor = true;
            this.buttonReference_PIA.Click += new System.EventHandler(this.buttonReference_PIA_Click);
            // 
            // groupBoxUslovie_PIA
            // 
            this.groupBoxUslovie_PIA.Controls.Add(this.textBoxTask_PIA);
            this.groupBoxUslovie_PIA.Location = new System.Drawing.Point(12, 79);
            this.groupBoxUslovie_PIA.Name = "groupBoxUslovie_PIA";
            this.groupBoxUslovie_PIA.Size = new System.Drawing.Size(776, 64);
            this.groupBoxUslovie_PIA.TabIndex = 3;
            this.groupBoxUslovie_PIA.TabStop = false;
            this.groupBoxUslovie_PIA.Text = "Условие:";
            // 
            // textBoxTask_PIA
            // 
            this.textBoxTask_PIA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_PIA.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask_PIA.Multiline = true;
            this.textBoxTask_PIA.Name = "textBoxTask_PIA";
            this.textBoxTask_PIA.Size = new System.Drawing.Size(764, 39);
            this.textBoxTask_PIA.TabIndex = 0;
            this.textBoxTask_PIA.Text = "Дан файл ";
            // 
            // groupBoxInput_PIA
            // 
            this.groupBoxInput_PIA.Controls.Add(this.textBoxInputData_PIA);
            this.groupBoxInput_PIA.Location = new System.Drawing.Point(12, 149);
            this.groupBoxInput_PIA.Name = "groupBoxInput_PIA";
            this.groupBoxInput_PIA.Size = new System.Drawing.Size(393, 289);
            this.groupBoxInput_PIA.TabIndex = 0;
            this.groupBoxInput_PIA.TabStop = false;
            this.groupBoxInput_PIA.Text = "Ввод:";
            // 
            // groupBoxOutputData_PIA
            // 
            this.groupBoxOutputData_PIA.Controls.Add(this.textBoxResult_PIA);
            this.groupBoxOutputData_PIA.Location = new System.Drawing.Point(411, 149);
            this.groupBoxOutputData_PIA.Name = "groupBoxOutputData_PIA";
            this.groupBoxOutputData_PIA.Size = new System.Drawing.Size(377, 289);
            this.groupBoxOutputData_PIA.TabIndex = 0;
            this.groupBoxOutputData_PIA.TabStop = false;
            this.groupBoxOutputData_PIA.Text = "Вывод:";
            // 
            // textBoxResult_PIA
            // 
            this.textBoxResult_PIA.Location = new System.Drawing.Point(6, 19);
            this.textBoxResult_PIA.Multiline = true;
            this.textBoxResult_PIA.Name = "textBoxResult_PIA";
            this.textBoxResult_PIA.Size = new System.Drawing.Size(365, 264);
            this.textBoxResult_PIA.TabIndex = 0;
            this.textBoxResult_PIA.Text = " ";
            // 
            // openFileDialog_PIA
            // 
            this.openFileDialog_PIA.FileName = "openFileDialog1";
            // 
            // textBoxInputData_PIA
            // 
            this.textBoxInputData_PIA.Location = new System.Drawing.Point(6, 16);
            this.textBoxInputData_PIA.Multiline = true;
            this.textBoxInputData_PIA.Name = "textBoxInputData_PIA";
            this.textBoxInputData_PIA.Size = new System.Drawing.Size(381, 267);
            this.textBoxInputData_PIA.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxOutputData_PIA);
            this.Controls.Add(this.groupBoxInput_PIA);
            this.Controls.Add(this.groupBoxUslovie_PIA);
            this.Controls.Add(this.buttonReference_PIA);
            this.Controls.Add(this.buttonCheckFile_PIA);
            this.Controls.Add(this.buttonDone_PIA);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.groupBoxUslovie_PIA.ResumeLayout(false);
            this.groupBoxUslovie_PIA.PerformLayout();
            this.groupBoxInput_PIA.ResumeLayout(false);
            this.groupBoxInput_PIA.PerformLayout();
            this.groupBoxOutputData_PIA.ResumeLayout(false);
            this.groupBoxOutputData_PIA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDone_PIA;
        private System.Windows.Forms.Button buttonCheckFile_PIA;
        private System.Windows.Forms.Button buttonReference_PIA;
        private System.Windows.Forms.GroupBox groupBoxUslovie_PIA;
        private System.Windows.Forms.GroupBox groupBoxInput_PIA;
        private System.Windows.Forms.GroupBox groupBoxOutputData_PIA;
        private System.Windows.Forms.TextBox textBoxResult_PIA;
        private System.Windows.Forms.TextBox textBoxTask_PIA;
        private System.Windows.Forms.OpenFileDialog openFileDialog_PIA;
        private System.Windows.Forms.TextBox textBoxInputData_PIA;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}


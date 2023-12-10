using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Tyuiu.PoznyakIA.Sprint6.Task6.V15.Lib;
namespace Tyuiu.PoznyakIA.Sprint6.Task6.V15
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        string openFilePath;
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonCheckFile_PIA_Click(object sender, EventArgs e)
        {
            openFileDialog_PIA.ShowDialog();
            openFilePath = openFileDialog_PIA.FileName;
            textBoxInputData_PIA.Text = File.ReadAllText(openFilePath);
            groupBoxOutputData_PIA.Text = groupBoxOutputData_PIA.Text + " " + openFileDialog_PIA.FileName;
            buttonDone_PIA.Enabled = true;
        }

        private void buttonDone_PIA_Click(object sender, EventArgs e)
        {
            textBoxResult_PIA.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonReference_PIA_Click(object sender, EventArgs e)
        {
            FormAbout_PIA formAbout = new FormAbout_PIA();
            formAbout.ShowDialog();
        }

      
    }
}

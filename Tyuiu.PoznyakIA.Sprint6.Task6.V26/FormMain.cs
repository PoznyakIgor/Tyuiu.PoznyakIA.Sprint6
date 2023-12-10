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
using Tyuiu.PoznyakIA.Sprint6.Task5.V26.Lib;
namespace Tyuiu.PoznyakIA.Sprint6.Task5.V26
{
    public partial class FormMain_PIA : Form
    {
        public FormMain_PIA()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Users\polimer\Desktop\Sprint6Task5\InPutFileTask5V26.txt";
        private void buttonDone_PIA_Click(object sender, EventArgs e)
        {
            dataGridViewNums_PIA.ColumnCount = 2;
            dataGridViewNums_PIA.Columns[0].Width = 20;
            dataGridViewNums_PIA.Columns[1].Width = 50;

            this.chartFunction_PIA.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartFunction_PIA.ChartAreas[0].AxisY.Title = "Ось Y";

            chartFunction_PIA.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewNums_PIA.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartFunction_PIA.Series[0].Points.AddXY(i, numsMass[i]);

            }
        }

        private void buttonOpenFile_PIA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonReference_PIA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ИСТНб-23-1 Позняк Игорь Андреевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

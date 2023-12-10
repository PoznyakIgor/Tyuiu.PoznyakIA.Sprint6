using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.PoznyakIA.Sprint6.Task4.V26.Lib;
using System.IO;

namespace Tyuiu.PoznyakIA.Sprint6.Task4.V26
{
    public partial class FormMain_PIA : Form
    {
        public FormMain_PIA()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonDone_PIA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxVinStart_PIA.Text);
                int stopStep = Convert.ToInt32(textBoxVinEnd_PIA.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_PIA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_PIA.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_PIA.Text = "";

                chartFunction_PIA.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunction_PIA.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_PIA.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_PIA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt";
                File.WriteAllText(path, textBoxResult_PIA.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранение успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохрынении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonReference_PIA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ИСТНб-23-1 Позняк Игорь Андреевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.PoznyakIA.Sprint6.Task2.V14.Lib;
namespace Tyuiu.PoznyakIA.Sprint6.Task2.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonDone_PIA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxNumberStart_PIA.Text);
                int stopStep = Convert.ToInt32(textBoxNumberEnd_PIA.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_PIA.Titles.Add("График функции sin(x)");

                this.chartFunction_PIA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_PIA.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_PIA.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction_PIA.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void buttonReference_PIA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИСТНб-23-1 Позняк Игорь Андреевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxNumberEnd_PIA_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDone_PIA_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_PIA.BackColor = Color.Yellow;
        }

        private void buttonReference_PIA_MouseEnter(object sender, EventArgs e)
        {
            buttonReference_PIA.BackColor = Color.Yellow;
        }

        private void buttonDone_PIA_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_PIA.BackColor = Color.Lime;
        }

        private void buttonReference_PIA_MouseLeave(object sender, EventArgs e)
        {
            buttonReference_PIA.BackColor = Color.Aqua;
        }

        private void buttonDone_PIA_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_PIA.BackColor = Color.Green;
        }

        private void buttonReference_PIA_MouseDown(object sender, MouseEventArgs e)
        {
            buttonReference_PIA.BackColor = Color.Blue;
        }
    }
}

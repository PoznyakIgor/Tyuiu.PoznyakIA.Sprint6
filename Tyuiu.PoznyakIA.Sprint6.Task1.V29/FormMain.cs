using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Tyuiu.PoznyakIA.Sprint6.Task1.V29.Lib;
namespace Tyuiu.PoznyakIA.Sprint6.Task1.V29
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
                int startValue = Convert.ToInt32(textBoxNumberStart_PIA.Text);
                int stopValue = Convert.ToInt32(textBoxNumberEnd_PIA.Text);

                string strLine;

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);
                textBoxResult_PIA.Text = "";
                textBoxResult_PIA.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_PIA.AppendText("|    X     |    f(x)  |" + Environment.NewLine);
                textBoxResult_PIA.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     | {1, 6:f2}   |", startValue, valueArray[i]);
                    textBoxResult_PIA.AppendText(strLine + Environment.NewLine);
                    startValue++;
                }
                textBoxResult_PIA.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        private void buttonReference_PIA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИСТНб-23-1 Позняк Игорь Андреевич", "Сообщение", MessageBoxButtons.OK);
        }
    }
}

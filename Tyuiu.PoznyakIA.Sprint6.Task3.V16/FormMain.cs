using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Tyuiu.PoznyakIA.Sprint6.Task3.V16.Lib;
namespace Tyuiu.PoznyakIA.Sprint6.Task3.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] mtrx = {
                { 14, 1, -3, 1, 10 },
                { 7, -3, 5, -4, 0 },
                { -10, -19, -18, -9, 19 },
                { -2, -2, -16, 2, -17 },
                { -16, 9, 5, -10, 16}
            };

        private void buttonDone_PIA_Click(object sender, EventArgs e)
        {
            int[,] result = ds.Calculate(mtrx);

            int rows = result.GetUpperBound(0) + 1;
            int columns = result.Length / rows;

            dataGridViewMatrix_PIA.ColumnCount = columns;
            dataGridViewMatrix_PIA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_PIA.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_PIA.Rows[i].Cells[j].Value = Convert.ToString(result[i, j]);
                }
            }
        }

        private void buttonReference_PIA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИСТНб-23-1 Позняк Игорь Андреевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
        
    }
}

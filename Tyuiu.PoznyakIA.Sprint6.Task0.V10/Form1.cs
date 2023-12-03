using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.PoznyakIA.Sprint6.Task0.V10.Lib;
namespace Tyuiu.PoznyakIA.Sprint6.Task0.V10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBoxUslovie_PIA_Enter(object sender, EventArgs e)
        {

        }

        private void buttonComplete_PIA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_PIA.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxWinX_PIA.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxResult_PIA_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxWinX_PIA_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxWinX_PIA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void buttonQueshion_PIA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("")
        }
    }


    }

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
using Tyuiu.PoznyakIA.Sprint6.Task7.V29.Lib;
namespace Tyuiu.PoznyakIA.Sprint6.Task7.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            InitializeComponent();
            openFileDialogTask_PIA.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_PIA.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        static string openFilePath;
        static int rows;
        static int colums;
        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            colums = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, colums];

            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < colums; j++)
                {
                    arrayValues[i, j] = Convert.ToInt32(line_r[j]);
                }
            }
            return arrayValues;
        }


        DataService ds = new DataService();
        private void buttonOpenFile_PIA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_PIA.ShowDialog();
            openFilePath = openFileDialogTask_PIA.FileName;

            int[,] arrayValues = LoadFromFileData(openFilePath);

            dataGridViewIn_PIA.ColumnCount = colums;
            dataGridViewIn_PIA.RowCount = rows;
            dataGridViewOut_PIA.ColumnCount = colums;
            dataGridViewOut_PIA.RowCount = rows;

            for (int i = 0; i < colums; i++)
            {
                dataGridViewIn_PIA.Columns[i].Width = 25;
                dataGridViewOut_PIA.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewIn_PIA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_PIA.Enabled = true;
        }

        private void buttonDone_PIA_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, colums];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewOut_PIA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSaveFile_PIA.Enabled = true;
        }

        private void buttonSaveFile_PIA_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_PIA.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_PIA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_PIA.ShowDialog();

            string path = saveFileDialogMatrix_PIA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOut_PIA.RowCount;
            int columns = dataGridViewOut_PIA.ColumnCount;

            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOut_PIA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut_PIA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonAbout_PIA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpenFile_PIA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_PIA.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_PIA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_PIA.ToolTipTitle = "Выполнить";
        }

        private void buttonSaveFile_PIA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_PIA.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonAbout_PIA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_PIA.ToolTipTitle = "Справка";
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewIn_PIA.ColumnCount = 50;
            dataGridViewOut_PIA.ColumnCount = 50;

            dataGridViewIn_PIA.RowCount = 50;
            dataGridViewOut_PIA.RowCount = 50;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewIn_PIA.Columns[i].Width = 25;
                dataGridViewOut_PIA.Columns[i].Width = 25;
            }
        }
    }
}

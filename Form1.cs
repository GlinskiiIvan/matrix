using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matrix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int columnCount = 6;
        int rowCount = 6;

        List<int> tempList = new List<int>();
        IEnumerable<int> tempDistinct;
        int fileCount = 0;

        private void button_create_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            dataGridView_matrix.Rows.Clear();
            dataGridView_matrix.Columns.Clear();            

            dataGridView_matrix.ColumnCount = columnCount;
            dataGridView_matrix.RowCount = rowCount;

            for (int i = 0; i < rowCount; i++)
            {
                for (int k = 0; k < columnCount; k++)
                {
                    int temp = rand.Next(0, 21);
                    dataGridView_matrix.Rows[i].Cells[k].Value = temp;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < rowCount; i++)
            {
                for (int k = 0; k < columnCount; k++)
                {
                    int temp = (int)dataGridView_matrix.Rows[i].Cells[k].Value;
                    tempList.Add(temp);
                }
            }

            tempList.Sort();
            tempDistinct = tempList.Distinct();

            Dictionary<int, int> repeatNumbers = new Dictionary<int, int>();

            foreach (int num in tempDistinct)
            {
                int count = 0;

                for (int i = 0; i < rowCount; i++)
                {
                    for (int k = 0; k < columnCount; k++)
                    {
                        if(num == (int)dataGridView_matrix[i, k].Value)
                        {
                            ++count;
                        }
                    }
                }

                if(count > 1)
                {
                    repeatNumbers.Add(num, count);
                }
            }
                        
            Form3 form3 = new Form3(repeatNumbers);
            form3.Show();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName.Length > 0)
            {
                string path = saveFileDialog1.FileName;

                FileStream file = new FileStream(path, FileMode.OpenOrCreate);
                StreamWriter streamWriter = new StreamWriter(file);

                for(int i = 0; i < rowCount; i++)
                {
                    string temp = "";
                    for(int k = 0; k < columnCount; k++)
                    {
                        temp += (int)dataGridView_matrix.Rows[i].Cells[k].Value + "\t";
                    }
                    streamWriter.WriteLine(temp);
                }
            
                streamWriter.Close();
                file.Close();

                ++fileCount;
            }
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK && openFileDialog1.FileName.Length > 0)
            {
                try
                {

                    string path = openFileDialog1.FileName;

                    StreamReader streamReader = new StreamReader(path);

                    int i = 0;

                    while (true)
                    {
                        // Читаем строку из файла во временную переменную.
                        string temp = streamReader.ReadLine();

                        // Если достигнут конец файла, прерываем считывание.
                        if (temp == null) break;

                        // List<string> itemList = temp.Split("\t");
                        string[] itemList = temp.Split("\t");
                        for (int k = 0; k < columnCount; k++)
                        {
                            int tempInt = Convert.ToInt32(itemList[k]);
                            dataGridView_matrix.Rows[i].Cells[k].Value = tempInt;
                        }

                        ++i;
                    }


                }
                catch (System.ArgumentException ex)
                {
                    
                }
            }

        }
    }
}

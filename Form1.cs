using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        List<int> tempList = new List<int>();
        IEnumerable<int> tempDistinct;

        private void button_create_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            dataGridView_matrix.Rows.Clear();
            dataGridView_matrix.Columns.Clear();

            int columnCount = 6;
            int rowCount = 6;

            dataGridView_matrix.ColumnCount = columnCount;
            dataGridView_matrix.RowCount = rowCount;

            for (int i = 0; i < rowCount; i++)
            {
                for (int k = 0; k < columnCount; k++)
                {
                    int temp = rand.Next(0, 21);
                    dataGridView_matrix.Rows[i].Cells[k].Value = temp;
                    tempList.Add(temp);
                }
            }
            tempList.Sort();
            tempDistinct = tempList.Distinct();
        }

        private void button1_Click(object sender, EventArgs e)
        {           

            Dictionary<int, int> repeatNumbers = new Dictionary<int, int>();

            foreach (int num in tempDistinct)
            {
                int count = 0;

                for (int i = 0; i < 6; i++)
                {
                    for (int k = 0; k < 6; k++)
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
    }
}

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

namespace ExpenseCalculator
{
    public partial class ExpenseTracker : Form
    {
        public ExpenseTracker()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RecreationBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void IntervalBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void IncomeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TravelBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BillsBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Budget b = new Budget();
            b.CreateBudget(IntervalBox.Text,
                IncomeBox.Text,
                FoodBox.Text, 
                RecreationBox.Text, 
                TravelBox.Text, 
                BillsBox.Text);
            dataGridView1.Rows.Add(b.ReqID, b.Interval, b.Income, b.TotalExpenses, b.Balance, b.AnnualCash());


        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                //There is an issue here that doesnt correctly return the file path. 
                //I've tried many things but havent been able to quite get this part.

                openFileDialog1.InitialDirectory = "c:\\";
                openFileDialog1.Filter = "Text files(*.txt) | *.txt | All files(*.*) | *.* ";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;

                string path = "";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file

                    path += openFileDialog1.FileName;


                }
                using (StreamReader txtfile = new StreamReader(path))
                {
                    string ln;
                    //Read file into temp string ln
                    while ((ln = txtfile.ReadLine()) != null)
                    {
                        //parse each line and add values to array
                        string[] parse = ln.Split(' ');
                        //initiate object
                        Budget b = new Budget();
                        b.CreateBudget(parse[0],
                            parse[1],
                            parse[2],
                            parse[3],
                            parse[4],
                            parse[5]);
                        dataGridView1.Rows.Add(b.ReqID, b.Interval, b.Income, b.TotalExpenses, b.Balance, b.AnnualCash());
                    }
                }
            }



        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
        }
    }

}

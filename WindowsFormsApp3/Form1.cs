using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = false;
            dataGridView1.Visible = false; 

            dataGridView3.ColumnCount = 4;
            dataGridView3.RowCount = 50;
            dataGridView3.Show();


            for (int i = 0; i < 50; i++)
            {
                dataGridView3.Rows[i].Cells[0].Value = (i + 1).ToString();
                dataGridView3.Rows[i].Cells[1].Value = FakeData.NameData.GetFullName();
                dataGridView3.Rows[i].Cells[2].Value = FakeData.NetworkData.GetEmail();
                dataGridView3.Rows[i].Cells[3].Value = FakeData.PhoneNumberData.GetPhoneNumber();
               
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;

            dataGridView1.ColumnCount = 5;
            dataGridView1.RowCount = 50;
            dataGridView1.Show();



            for (int i = 0; i < 50; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = (i + 1).ToString();
                dataGridView1.Rows[i].Cells[1].Value = FakeData.NameData.GetFullName();
                dataGridView1.Rows[i].Cells[2].Value = FakeData.NetworkData.GetEmail();
                dataGridView1.Rows[i].Cells[3].Value = FakeData.PhoneNumberData.GetPhoneNumber();
                dataGridView1.Rows[i].Cells[4].Value = FakeData.PlaceData.GetAddress();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView2.Visible = false;
            dataGridView3.Visible = false; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView3.Visible = false;

            dataGridView2.ColumnCount = 3;
            dataGridView2.RowCount = 50;
            dataGridView2.Show();


            for (int i = 0; i < 50; i++)
            {
                dataGridView2.Rows[i].Cells[0].Value = (i+1).ToString();
                dataGridView2.Rows[i].Cells[1].Value = FakeData.NameData.GetFullName();
                dataGridView2.Rows[i].Cells[2].Value = FakeData.NetworkData.GetEmail();
                
               
            }

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.GreenYellow;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = DefaultBackColor;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.GreenYellow;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = DefaultBackColor;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.GreenYellow;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = DefaultBackColor;
        }
    }
}

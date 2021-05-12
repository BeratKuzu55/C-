using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Cyan;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.DarkBlue;
            button2.BackColor = Color.Yellow;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Visible = false;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            button1.BackColor = Color.Orange;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_DropDown(object sender, EventArgs e)
        {
            this.BackColor = Color.Orchid;
        }

        private void dateTimePicker1_CloseUp(object sender, EventArgs e)
        {
            this.BackColor = Color.PaleGreen;
        }

        private void dateTimePicker1_StyleChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.PaleGoldenrod;
        }
    }
}

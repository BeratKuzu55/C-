using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework.Sıra19.D9.ListBoxİnceleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBoxDoldurV1();
        }

        void listBoxDoldurV1()
        {
            foreach (var item in database.ürünTablo)
            {
                listBoxÜrünler.Items.Add(item);/*
                item.add objeden değer kabul ettiği için objelerim ilgili listbox a eklendi
                her eklenen obje ürün nesnesi ama objeye dönüştürüldü
                 */
            }
           
        }

    }
}

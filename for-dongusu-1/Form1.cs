using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace for_dongusu_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int baslangic, bitis;
            baslangic=Convert.ToInt32(txtBaslangic.Text);
            bitis=Convert.ToInt32(txtBitis.Text);
           
            for(int i=baslangic; i <=bitis; i++)
            {
                listBox1.Items.Add(i);
            }

           
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public string dado;
        

        public Form1()
        {
            
            InitializeComponent();

            
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            txtdados.Text = dado;
        }

        public void preenche(string dados)
        {
            txtdados.Text = dados;
            txtdados.Refresh();
            
        }

        private void form2_Click(object sender, EventArgs e)
        {
            Form2 fm = new Form2(this);
            fm.Show();
        }
    }
}

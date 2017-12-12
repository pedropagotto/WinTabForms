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
    public partial class Form2 : Form
    {
        private Form1 _fm = null;
        public Form2(Form1 _fm)
        {
            this._fm = _fm;
            InitializeComponent();
            
        }

        
      

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _fm.preenche(txtdados2.Text);
            this.Close();
        }
    }
}

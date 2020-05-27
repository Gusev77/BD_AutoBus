using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maket
{
    public partial class Form_Enter : Form
    {


        Form_M f1 = new Form_M();
        Form_P f2 = new Form_P();
        public Form_Enter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "АДМИН" && password_txt.Text == "123")
            {
                f1.Show();
                this.Hide();
            }
            else if (comboBox1.Text == "ВОДИТЕЛЬ" && password_txt.Text == "321")
            {
                f2.Show();
                this.Hide();
            }
            else
            {
                Error er = new Error();
                er.Show();
                this.Hide();
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
    
}

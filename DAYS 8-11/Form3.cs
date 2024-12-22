using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAYS_8_11
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string z = txtInput.Text;  
            string n = "";            

            for (int i = z.Length - 1; i >= 0; i--) 
            {
                n += z[i];       
            }

             text1.Text = "Результат: " + n;
        }
    }
}

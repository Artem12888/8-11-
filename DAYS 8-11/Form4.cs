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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnCodes_Click(object sender, EventArgs e)
        {
            string n = txtInput.Text; 

            if (n.Length > 0)          
            {
                int a = n[0];  
                int b = n[n.Length - 1]; 

                text1.Text = "Код первого: " + a + ", последнего: " + b;
            }
            else
            {
                text1.Text = "Строка пустая!"; 
            }
        }
    }
}

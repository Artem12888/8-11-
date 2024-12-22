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
    
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(numLength.Value); 
            char c1= txtC1.Text[0];                 
            char c2 = txtC2.Text[0];                 

            string a = "";                      

            for (int i = 0; i < n; i++)              
            {
                if (i % 2 == 0)                      
                {
                    a += c1;
                }
                else                                 
                {
                    a += c2;
                }
            }

            textrezet.Text = "Результат: " +a;
        }
    }
}

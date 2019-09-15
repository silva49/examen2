using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double horas = double.Parse(txthoras.Text);
            double valor = double.Parse(txtvalor.Text);
           double total = valor * horas;

            if(total< 700000) {
                total = total * 0.10;
                lbltotal.Text = total.ToString() + 0;
                MessageBox.Show("se le incrementó 10% el salario.");
            }
            else {
              if (total<= 1000000) {
                    total = total / 0.2;
                    lbltotal.Text = total.ToString() + 0;
                    MessageBox.Show("se le decrementó 2% el salario.");
                }
                else {
                    if (total>= 1000001) {
                        total = (total / 0.5) *  0.2;
                        lbltotal.Text = total.ToString() ;
                        MessageBox.Show("se le decrementó 5% el salario y se le aumentó 2%");
                    }
                }
            }
        }
    }
}

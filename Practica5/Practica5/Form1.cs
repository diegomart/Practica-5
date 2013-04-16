using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Practica5
{
 

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
      

        private void btnsuma_Click(object sender, EventArgs e)
        {
            double num1 = int.Parse(this.numero1.Text);
            double num2 = int.Parse(this.numero2.Text);

            double resultado = num1 + num2;
            this.Resultado.Text = resultado.ToString();
            
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            double num1 = int.Parse(this.numero1.Text);
            int num2 = int.Parse(this.numero2.Text);

            double resultado = num1 - num2;
            this.Resultado.Text = resultado.ToString();

        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            double num1 = int.Parse(this.numero1.Text);
            double num2 = int.Parse(this.numero2.Text);

            double resultado = num1 * num2;
            this.Resultado.Text = resultado.ToString();
            
        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            double num1 = int.Parse(this.numero1.Text);
            double num2 = int.Parse(this.numero2.Text);

            double resultado = num1 / num2;
            this.Resultado.Text = resultado.ToString();

           
        }
        
        private void numero1_TextChanged(object sender, EventArgs e)
        {
            double num1 = int.Parse(this.numero1.Text);
           
        }

        private void numero2_TextChanged(object sender, EventArgs e)
        {
            double num2 = int.Parse(this.numero2.Text);
        }
        
        private void Resultado_TextChanged(object sender, EventArgs e)
        {
        
        }
          
    }
}

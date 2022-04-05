using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        double num1;
        double num2;
        string op;
        public Form1()
        {
            InitializeComponent();
        }

        clases.Suma objSum = new clases.Suma();
        clases.Resta objRest = new clases.Resta();
        clases.Multiplicacion objMult = new clases.Multiplicacion();
        clases.Division objDiv = new clases.Division();
        private void btn0_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "9";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + ",";
        }

        private void btmSuma_Click(object sender, EventArgs e)
        {
            op = "+";
            num1 = double.Parse(txtPantalla.Text);
            txtPantalla.Clear();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            op = "-";
            num1 = double.Parse(txtPantalla.Text);
            txtPantalla.Clear();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            op = "*";
            num1 = double.Parse(txtPantalla.Text);
            txtPantalla.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            op = "/";
            num1 = double.Parse(txtPantalla.Text);
            txtPantalla.Clear();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(txtPantalla.Text);
            double sum=0,res=0,mult=0, div=0;

            switch (op)
            {
                case "+":
                    sum = objSum.suma(num1,num2);
                    txtPantalla.Text = sum.ToString();
                    break;
                case "-":
                    res = objRest.resta(num1, num2);
                    txtPantalla.Text = res.ToString();
                    break;
                case "*":
                    mult = objMult.multi(num1, num2);
                    txtPantalla.Text = mult.ToString();
                    break;
                case "/":
                    div = objDiv.division(num1, num2);
                    txtPantalla.Text = div.ToString();
                    break;

            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtPantalla.Clear();
        }
    }
}

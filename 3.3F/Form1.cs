using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._3F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static double f(double x, out double y)
        {
            if (x >= 0.9) y = 1 / Math.Pow(1 + x, 2);
            else if (x >= 0) y = 0.2 * x + 0.1;
            else y = x * x + 0.2;
            return y;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            double h, y;
            if (A.Text == "" || B.Text == "" || H.Text == "") V.Text = "Неккоректные введённые данные";
            else
            {
                a = Convert.ToInt32(A.Text);
                b = Convert.ToInt32(B.Text);
                h = Convert.ToDouble(H.Text);
                V.Text = "";
                if (b < a) V.Text = "Неккоректно введены данные";
                else
                {
                    V.Text = "";
                    for (double i = a; i < b; i += h)
                    {
                        V.Text += "f(" + i + ") = " + f(i, out y);
                        V.Text += Environment.NewLine;
                    }

                }

            }
        }
    }
}   

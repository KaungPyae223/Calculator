using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Int16 a = 5;
        Boolean s = true;
        Int16 g = 0;
        Boolean d = true;
        Boolean y = true;
        Boolean e = false;
        
        double i =0;
        double r =0;
        private void btn0_Click(object sender, EventArgs e)
        {
            if (lblresult.Text != "" )
                type("0");

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            type("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            type("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            type("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            type("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            type("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            type("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            type("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            type("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            type("9");
        }

        private void btndeci_Click(object sender, EventArgs e)
        {
            if (d == true)
            {
                if (lblresult.Text == "" || y == false)
                { 
                    lblresult.Text = "0.";
                    true1();
                    y = true;
                    
                }
                else
                    lblresult.Text += ".";

                d = false;
            }
             
        }

        private void btnp_Click(object sender, EventArgs e)
        {
            if (lblresult.Text == "")
                lblresult.Text = "-";
            else
            {
                double a = Convert.ToDouble(lblresult.Text);
                a = a * (-1);
                lblresult.Text = a.ToString();
            }
        }

        

        private void btnequal_Click(object sender, EventArgs e)
        {
            if (lblresult.Text != "" && lblreault1.Text != "")
            {
                if (r != 0)
                    i = r;
                check();
                lblreault1.Text = lblreault1.Text+" " + lblresult.Text+" =";
                lblresult.Text = r.ToString();
                s = true;
                
            }
        }
        private void btnplus_Click(object sender, EventArgs e)
        {
            condition(1, " +");
        }
        private void btnminus_Click(object sender, EventArgs e)
        {
            condition(2, " -");
        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            condition(3, " x");
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            condition(4, " ÷");
        }

        private void btnCe_Click(object sender, EventArgs e)
        {
            lblresult.Text = "";
            d = true;
            y = true;

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            lblresult.Text = "";
            lblreault1.Text = "";
            s = true;
            g = 0;
            a = 5;
            i = 0;
            r = 0;
            d = true;
            y = true;
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            if (lblresult.Text.Length > 0)
            {
                lblresult.Text = lblresult.Text.Remove(lblresult.Text.Length - 1, 1);
            }
            if (y == false)
            {
                lblresult.Text = "";
                d = true;
                y = true;
                
            }
        }
        
        public void type(string k)
        {
            if (y == false)
            {
                lblresult.Text = k;
                y = true;
                e = true;
            }
            else
            {
                lblresult.Text += k;
                e = true;
            }
        }
  
        public void check()
        {
            double f = Convert.ToDouble(lblresult.Text);
            switch (a)
            {
                case 1: r = i + f; break;
                case 2: r = i - f; break;
                case 3: r = i * f; break;
                case 4: r = i / f; break;
            }
            
            y = false;
        }
        public void sign(Int16 z,string z1)
        {
            i = r = Convert.ToDouble(lblresult.Text);
            a = z;
            lblreault1.Text = lblresult.Text + z1;
            lblresult.Text = "";
            d = true;
            s = false;
        }
        public void over(Int16 z, string z1)
        {
            if (r == 0)
            {
                i = r = Convert.ToDouble(lblresult.Text);
            }
            if (a == 5)
            {
                a = z;
            }
            i = r;
            check();
            lblreault1.Text = r.ToString() + z1;
            lblresult.Text = r.ToString();
            a = z;
            d = true;
        }
        public void condition(Int16 z,String z1)
        {
            
            if (lblresult.Text == "" && z1 == " -")
            {
                lblresult.Text = " -";
            }
            else if (lblresult.Text == "")
            {
                MessageBox.Show("Please enter a number first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (s == true && e == true)
            {
                sign(z, z1);
            }
            else if (e == true)
            {
                over(z, z1);
                e = false;
            }
            else
            {
                a = z;
                lblreault1.Text = r.ToString() + z1;
            }
        }
        private void true1()
        {
            e = true;
        }
        
        
    }
}

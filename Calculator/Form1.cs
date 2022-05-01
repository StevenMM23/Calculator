using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            if (PantallaLabel.Enabled)
                PantallaLabel.Text += "6";
            else
            {
                PantallaLabel.Enabled = true;
                PantallaLabel.Text = "";
                PantallaLabel.Text += "6";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            OperatorLabel.Text = "x";
            if (PantallaLabel.Text != "")
                NumberContainerLabel.Text = PantallaLabel.Text;

            PantallaLabel.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (PantallaLabel.Enabled)
                PantallaLabel.Text += "8";
            else
            {
                PantallaLabel.Enabled = true;
                PantallaLabel.Text = "";
                PantallaLabel.Text += "8";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (PantallaLabel.Enabled)
                PantallaLabel.Text += "1";
            else
            {
                PantallaLabel.Enabled = true;
                PantallaLabel.Text = "";
                PantallaLabel.Text += "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (PantallaLabel.Enabled)
                PantallaLabel.Text += "2";
            else
            {
                PantallaLabel.Enabled = true;
                PantallaLabel.Text = "";
                PantallaLabel.Text += "2";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CButton_Click(object sender, EventArgs e)
        {
            PantallaLabel.ResetText();
            NumberContainerLabel.ResetText();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (PantallaLabel.Enabled)
                PantallaLabel.Text += "0";
            else
            {
                PantallaLabel.Enabled = true;
                PantallaLabel.Text = "";
                PantallaLabel.Text += "0";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (PantallaLabel.Enabled)
                PantallaLabel.Text += "3";
            else
            {
                PantallaLabel.Enabled = true;
                PantallaLabel.Text = "";
                PantallaLabel.Text += "3";
            }

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (PantallaLabel.Enabled)
                PantallaLabel.Text += "4";
            else
            {
                PantallaLabel.Enabled = true;
                PantallaLabel.Text = "";
                PantallaLabel.Text += "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (PantallaLabel.Enabled)
                PantallaLabel.Text += "5";
            else
            {
                PantallaLabel.Enabled = true;
                PantallaLabel.Text = "";
                PantallaLabel.Text += "5";
            }
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (PantallaLabel.Enabled)
                PantallaLabel.Text += "7";
            else
            {
                PantallaLabel.Enabled = true;
                PantallaLabel.Text = "";
                PantallaLabel.Text += "7";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (PantallaLabel.Enabled)
                PantallaLabel.Text += "9";
            else
            {
                PantallaLabel.Enabled = true;
                PantallaLabel.Text = "";
                PantallaLabel.Text += "9";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PantallaLabel.Enabled)
            {
                var x = PantallaLabel.Text;
                var y = "";
                if (x.Length > 0)
                    y = x.Remove(x.Length - 1);

                PantallaLabel.Text = y;
            }
            
            
        }

        private void dotbtn_Click(object sender, EventArgs e)
        {
            PantallaLabel.Text += ".";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void plusbtn_Click(object sender, EventArgs e)
        {
            OperatorLabel.Text = "+";
            if (PantallaLabel.Text != "")
                NumberContainerLabel.Text = PantallaLabel.Text;

            PantallaLabel.Text = "";
        }

        private void equalbtn_Click(object sender, EventArgs e)
        {
            
            switch (OperatorLabel.Text)
            {
                case "+":
                    if (NumberContainerLabel.Text != "")
                    {
                        var x = Convert.ToDouble(NumberContainerLabel.Text) + Convert.ToDouble(PantallaLabel.Text);
                        NumberContainerLabel.Text += OperatorLabel.Text + PantallaLabel.Text;
                        NumberContainerLabel.Text = "";
                        PantallaLabel.Enabled = false;
                        PantallaLabel.Text = x.ToString();
                    }
                    break;
                case "-":
                    if (NumberContainerLabel.Text != "")
                    {
                        var x = Convert.ToDouble(NumberContainerLabel.Text) - Convert.ToDouble(PantallaLabel.Text);
                        NumberContainerLabel.Text += OperatorLabel.Text + PantallaLabel.Text;
                        NumberContainerLabel.Text = "";
                        PantallaLabel.Enabled = false;
                        PantallaLabel.Text = x.ToString();
                    }
                    break;
                case "x":
                    if (NumberContainerLabel.Text != "")
                    {
                        var x = Convert.ToDouble(NumberContainerLabel.Text) * Convert.ToDouble(PantallaLabel.Text);
                        NumberContainerLabel.Text += OperatorLabel.Text + PantallaLabel.Text;
                        NumberContainerLabel.Text = "";
                        PantallaLabel.Enabled = false;
                        PantallaLabel.Text = x.ToString();
                    }
                    break;
                case "%":
                    if (NumberContainerLabel.Text != "")
                    {
                        var x = Convert.ToDouble(NumberContainerLabel.Text) / Convert.ToDouble(PantallaLabel.Text);
                        NumberContainerLabel.Text += OperatorLabel.Text + PantallaLabel.Text;
                        NumberContainerLabel.Text = "";
                        PantallaLabel.Enabled = false;
                        PantallaLabel.Text = x.ToString();
                    }
                    break;
            }
        }

        private void minusbtn_Click(object sender, EventArgs e)
        {
            OperatorLabel.Text = "-";
            if (PantallaLabel.Text != "")
                NumberContainerLabel.Text = PantallaLabel.Text;

            PantallaLabel.Text = "";
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            OperatorLabel.Text = "%";
            
            if(PantallaLabel.Text != "") 
                NumberContainerLabel.Text = PantallaLabel.Text;

            PantallaLabel.Text = "";
            
        }

        public void PantallaLabel_Click(object sender, EventArgs e)
        {

        }

        private void equalbtn_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void btn1_Validated(object sender, EventArgs e)
        {
            
        }
    }
}

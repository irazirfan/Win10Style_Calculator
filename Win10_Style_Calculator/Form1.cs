using System;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Win10_Style_Calculator
{
    public partial class Form1 : MetroForm
    {
        Double result = 0;
        String operation = "";
                bool enter_value = false;
        string firstNum, secondNum;
        byte flag = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void numbers_Only(object sender, EventArgs e)
        {
            btnEquals.Enabled = true;
            Button b = (Button) sender;

            if (txtDisplay.Text == "0" || enter_value)
                txtDisplay.Text = "";
            enter_value = false;

            if (b.Text == ".")
            {
                if (!txtDisplay.Text.Contains("."))
                    txtDisplay.Text += b.Text;
            }
            else
            {
                txtDisplay.Text += b.Text;
            }

        }

        private void operators_Click(object sender, EventArgs e)
        {
            Button b = (Button) sender;

            if (result != 0)
            {
                btnEquals.PerformClick();
                enter_value = true;
                operation = b.Text;
                lblShowOps.Text = System.Convert.ToString(result) + "  " + operation;
            }

            else
            {
                operation = b.Text;
                result = Double.Parse(txtDisplay.Text);
                txtDisplay.Text = "";
                lblShowOps.Text = System.Convert.ToString(result) + "  " + operation;
            }

            firstNum = lblShowOps.Text;


        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            secondNum = txtDisplay.Text;
            lblShowOps.Text = "";
            switch (operation)
            {
                case "+":
                    txtDisplay.Text = (result + Double.Parse(txtDisplay.Text)).ToString() ;
                    break;
                case "-":
                    txtDisplay.Text = (result - Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "X":
                    txtDisplay.Text = (result * Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "÷":
                    txtDisplay.Text = (result / Double.Parse(txtDisplay.Text)).ToString();
                    break;
                default:
                    break;
            }

            result = Double.Parse((txtDisplay.Text));
            operation = "";

            //=======================================

            btnHistoryClear.Visible = true;
            rtbDisplayHistory.AppendText(firstNum + "   " + secondNum + " = " + "\n");
            rtbDisplayHistory.AppendText("\n\t" + txtDisplay.Text + "\n\n");
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            result = 0;
            btnEquals.Enabled = false;
            lblShowOps.Text = "";
        }

        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            rtbDisplayHistory.Clear();
            btnHistoryClear.Visible = false;
            rtbDisplayHistory.ScrollBars = 0;
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.StartsWith("-"))
            {
                txtDisplay.Text = txtDisplay.Text.Substring(1);
            }
            else if (!string.IsNullOrEmpty(txtDisplay.Text) && decimal.Parse(txtDisplay.Text) != 0)
            {
                txtDisplay.Text = "-" + txtDisplay.Text;
            }
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            result = Math.Sqrt(Double.Parse(txtDisplay.Text));

            lblShowOps.Text = "✓" + txtDisplay.Text;
            txtDisplay.Text = result.ToString();
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            result *= Double.Parse(txtDisplay.Text);
            result /= 100;
            txtDisplay.Text = result.ToString();
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            result = Double.Parse(txtDisplay.Text);
            result *= result;
            txtDisplay.Text = result.ToString();
        }

        private void btnPowerHalf_Click(object sender, EventArgs e)
        {
            result = Double.Parse(txtDisplay.Text);
            result = Math.Pow(result, .5);
            txtDisplay.Text = result.ToString();
        }

        private void All_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Multiply)
                btnMul.PerformClick();
            else if (e.KeyCode == Keys.Delete)
                btnCE.PerformClick();
            else if (e.KeyCode == Keys.Clear || e.KeyCode == Keys.C)
                btnClear.PerformClick();
            else if (e.KeyCode == Keys.Back)
                btnBackspace.PerformClick();
            else if (e.KeyCode == Keys.Add)
                btnPlus.PerformClick();
            else if (e.KeyCode == Keys.Subtract)
                btnMinus.PerformClick();
            else if (e.KeyCode == Keys.Divide)
                btnDiv.PerformClick();
            else if (e.KeyCode == Keys.Enter)
                btnEquals_Click(btnEquals, e);
            else if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
                btnZero.PerformClick();
            else if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
                btn1.PerformClick();
            else if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
                btn2.PerformClick();
            else if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
                btn3.PerformClick();
            else if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
                btn4.PerformClick();
            else if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
                btn5.PerformClick();
            else if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
                btn6.PerformClick();
            else if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
                btn7.PerformClick();
            else if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
                btn8.PerformClick();
            else if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
                btn9.PerformClick();
            else if (e.KeyCode == Keys.Decimal)
                btnDot.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oopps! Something went wrong");
            }
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                panel2.SendToBack();
                panel1.BringToFront();
                flag = 2;
            }
            else if (flag == 2)
            {
                panel1.SendToBack();
                panel2.BringToFront();
                flag = 1;
            }
        }

        private void btnClear_MouseDown(object sender, MouseEventArgs e)
        {
            btnClear.PerformClick();
        }

        private void btnHistoryClear_Click(object sender, EventArgs e)
        {
            rtbDisplayHistory.Clear();
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }

            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";
            }
        }
    }
}

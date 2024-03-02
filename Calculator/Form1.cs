namespace Calculator
{
    public partial class Form1 : Form
    {
        private double num1;
        private double num2;
        private string operation;
        private double result;
        public Form1()
        {
            InitializeComponent();
        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            operation = "+";
            num1 = double.Parse(txtOutput.Text);
            txtOutput.Clear();
        }
        
        private void ClearDisplay()
        {
            txtOutput.Clear();
        }
        private void PerformOperation(string op)
        {
            operation = op;
            num1 = double.Parse(txtOutput.Text);
            ClearDisplay();
        }
        private void PerformCalculation()
        {
            num2 = double.Parse(txtOutput.Text);

            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "X":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                        MessageBox.Show("Division by zero is not allowed!");
                    break;
                case "%":
                    result = num1 % num2;
                    break;
            }

            txtOutput.Text = result.ToString("0.##");
        }

        private void btn_equals_Click(object sender, EventArgs e)
        {
            PerformCalculation();
        }

        private void btn_decimal_Click(object sender, EventArgs e)
        {
            if (!txtOutput.Text.Contains("."))
                txtOutput.Text += ".";
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            operation = "-";
            num1 = double.Parse(txtOutput.Text);
            txtOutput.Clear();
        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {
            operation = "x";
            num1 = double.Parse(txtOutput.Text);
            txtOutput.Clear();
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            operation = "/";
            num1 = double.Parse(txtOutput.Text);
            txtOutput.Clear();
        }

        private void btn_modulo_Click(object sender, EventArgs e)
        {
            operation = "%";
            num1 = double.Parse(txtOutput.Text);
            txtOutput.Clear();
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text + "0";
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text + "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text + "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text + "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text + "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text + "5";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text + "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text + "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text + "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text + "9";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text.Length > 0)
            {
                txtOutput.Text = txtOutput.Text.Remove(txtOutput.Text.Length - 1, 1);
            }
        }

        private void btn_clearall_Click(object sender, EventArgs e)
        {
            ClearDisplay();
        }
    }
}

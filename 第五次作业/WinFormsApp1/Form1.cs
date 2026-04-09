namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private double firstNumber = 0;
        private double secondNumber = 0;
        private string operation = "";
        private bool isNewNumber = true;

        public Form1()
        {
            InitializeComponent();
            txtDisplay.Text = "";
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (isNewNumber)
            {
                txtDisplay.Text = btn.Text;
                isNewNumber = false;
            }
            else
            {
                txtDisplay.Text += btn.Text;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (isNewNumber)
            {
                txtDisplay.Text = "0";
                isNewNumber = false;
            }
            else
            {
                txtDisplay.Text += "0";
            }
        }

        private void btnOperator_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (!string.IsNullOrEmpty(txtDisplay.Text))
            {
                if (operation != "" && !isNewNumber)
                {
                    CalculateResultWithoutEqual();
                    txtDisplay.Text = firstNumber.ToString();
                }

                firstNumber = Convert.ToDouble(txtDisplay.Text);
                operation = btn.Text;
                isNewNumber = false;

                txtDisplay.Text += operation;
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(operation) && !isNewNumber)
            {
                CalculateResult();
                operation = "";
                isNewNumber = true;
            }
        }

        private void CalculateResultWithoutEqual()
        {
            string currentText = txtDisplay.Text;
            string secondStr = currentText.Substring(currentText.IndexOf(operation) + 1);
            secondNumber = Convert.ToDouble(secondStr);
            double result = 0;

            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "×":
                    result = firstNumber * secondNumber;
                    break;
                case "÷":
                    if (secondNumber != 0)
                    {
                        result = firstNumber / secondNumber;
                    }
                    else
                    {
                        MessageBox.Show("除数不能为零！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Clear();
                        return;
                    }
                    break;
            }

            txtDisplay.Text = result.ToString();
            firstNumber = result;
        }

        private void CalculateResult()
        {
            string currentText = txtDisplay.Text;
            string secondStr = currentText.Substring(currentText.IndexOf(operation) + 1);
            secondNumber = Convert.ToDouble(secondStr);
            double result = 0;

            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "×":
                    result = firstNumber * secondNumber;
                    break;
                case "÷":
                    if (secondNumber != 0)
                    {
                        result = firstNumber / secondNumber;
                    }
                    else
                    {
                        MessageBox.Show("除数不能为零！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Clear();
                        return;
                    }
                    break;
            }

            txtDisplay.Text = firstNumber.ToString() + operation + secondNumber.ToString() + "=" + result.ToString();
            firstNumber = result;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            txtDisplay.Text = "";
            firstNumber = 0;
            secondNumber = 0;
            operation = "";
            isNewNumber = true;
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

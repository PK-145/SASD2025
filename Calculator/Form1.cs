namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtValue.Text += btn0.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtValue.Text += btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtValue.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtValue.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtValue.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtValue.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtValue.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtValue.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtValue.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtValue.Text += btn9.Text;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (txtValue.Text.Length == 0)
                return;

            txtValue.Text = txtValue.Text.Substring(0, txtValue.Text.Length - 1);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtValue.Text = string.Empty;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (txtValue.Text.Length == 0)
                return;

            if (txtValue.Text.EndsWith("+") || txtValue.Text.EndsWith("-") || txtValue.Text.EndsWith("×") || txtValue.Text.EndsWith("÷"))
                return;

            txtValue.Text += btnPlus.Text;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (txtValue.Text.Length == 0)
                return;

            if (txtValue.Text.EndsWith("+") || txtValue.Text.EndsWith("-") || txtValue.Text.EndsWith("×") || txtValue.Text.EndsWith("÷"))
                return;

            txtValue.Text += btnMinus.Text;
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            if (txtValue.Text.Length == 0)
                return;

            if (txtValue.Text.EndsWith("+") || txtValue.Text.EndsWith("-") || txtValue.Text.EndsWith("×") || txtValue.Text.EndsWith("÷"))
                return;

            txtValue.Text += btnMulti.Text;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (txtValue.Text.Length == 0)
                return;

            if (txtValue.Text.EndsWith("+") || txtValue.Text.EndsWith("-") || txtValue.Text.EndsWith("×") || txtValue.Text.EndsWith("÷"))
                return;

            txtValue.Text += btnDivide.Text;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (txtValue.Text.Length == 0)
                return;
            if (txtValue.Text.EndsWith("+") || txtValue.Text.EndsWith("-") || txtValue.Text.EndsWith("×") || txtValue.Text.EndsWith("÷"))
                return;
            try
            {
                string actualTxt = txtValue.Text.Replace("×", "*").Replace("÷", "/");

                // Debug : Check the actual expression before evaluation
                // MessageBox.Show("Evaluating: " + actualTxt);

                if (actualTxt.Contains("/0"))
                {
                    MessageBox.Show("Error: Division by zero is not allowed.");
                    return;
                }

                var result = new System.Data.DataTable().Compute(actualTxt, null);
                txtValue.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}

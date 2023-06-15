namespace simple_calculator
{
    public partial class Form1 : Form
    {
        char op = ' ';
        public Form1()
        {
            InitializeComponent();
        }

        private void add_op_Click(object sender, EventArgs e)
        {
            op = '+';
        }

        private void sub_op_Click(object sender, EventArgs e)
        {
            op = '-';
        }

        private void mul_op_Click(object sender, EventArgs e)
        {
            op = '*';
        }

        private void div_op_Click(object sender, EventArgs e)
        {
            op = '/';
        }

        private void result_op_Click(object sender, EventArgs e)
        {
            if (num_1.Text != "" && num_2.Text != "")
            {
                if (num_1.Text.All(char.IsDigit) && num_2.Text.All(char.IsDigit))
                    switch (op)
                    {
                        case '+':
                            result.Text = (double.Parse(num_1.Text) + double.Parse(num_2.Text)).ToString();
                            break;
                        case '-':
                            result.Text = (double.Parse(num_1.Text) - double.Parse(num_2.Text)).ToString();
                            break;
                        case '*':
                            result.Text = (double.Parse(num_1.Text) * double.Parse(num_2.Text)).ToString();
                            break;
                        case '/':
                            result.Text = (double.Parse(num_1.Text) / double.Parse(num_2.Text)).ToString();
                            break;
                        default:
                            MessageBox.Show("Please select an operator");
                            break;
                    }
                else
                {
                    MessageBox.Show("Please enter numbers only");
                }
            }
            else
            {
                MessageBox.Show("Please enter a number");
            }
        }
    }
}
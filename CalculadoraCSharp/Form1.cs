namespace CalculadoraCSharp
{
    public partial class Calculadora : Form
    {
        double number1 = 0, number2 = 0;
        char operador;
        public Calculadora()
        {
            InitializeComponent();
        }

        private void AddNumber(object sender, EventArgs e)
        {
            var btn = ((Button)sender);

            if (txtScreen.Text == "0")
                txtScreen.Text = "";
            txtScreen.Text += btn.Text;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            number2= Convert.ToDouble(txtScreen.Text);
            switch(operador)
            {
                case '+': 
                    txtScreen.Text = (number1 + number2).ToString(); 
                    number1 = Convert.ToDouble(txtScreen.Text);
                    break;
                case '-':
                    txtScreen.Text = (number1 - number2).ToString();
                    number1 = Convert.ToDouble(txtScreen.Text);
                    break;
                case '/':
                    if (txtScreen.Text != "0")
                    {
                        txtScreen.Text = (number1 / number2).ToString();
                        number1 = Convert.ToDouble(txtScreen.Text);
                    }
                    else
                    {
                        MessageBox.Show("La division entre 0 no es valida.");
                    }
                    break;
                case 'x':
                    txtScreen.Text = (number1 * number2).ToString();
                    number1 = Convert.ToDouble(txtScreen.Text);
                    break;
                case '%':
                    txtScreen.Text = (number1 % number2).ToString();
                    number1 = Convert.ToDouble(txtScreen.Text);
                    break;


            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if ( txtScreen.Text.Length > 1)
            {
                txtScreen.Text = txtScreen.Text.Substring(0, txtScreen.Text.Length - 1);
            }
            else
            {
                txtScreen.Text = "0";
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            number1 = 0;
            number2 = 0;
            operador = '\0';
            txtScreen.Text = "";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtScreen.Text = "";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if ( !(txtScreen.Text.Contains(".")) )
            {
                txtScreen.Text += ".";
            }
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtScreen.Text);
            number1 *= -1;
            txtScreen.Text = number1.ToString();
        }

        private void txtScreen_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClickOperator( object sender, EventArgs e)
        {
            var btn = ((Button)sender);
            number1= Convert.ToDouble(txtScreen.Text);
            operador = Convert.ToChar(btn.Tag);

            if (operador == '²')
            {
                number1 = Math.Pow(number1, 2);
                txtScreen.Text = number1.ToString();
            }
            else if (operador == '√')
            {
                number1 = Math.Sqrt(number1);
                txtScreen.Text = number1.ToString();
            }
            else
            {
                txtScreen.Text = "0";
            }
        } 

    }
}
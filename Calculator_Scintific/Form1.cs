using System;

namespace Calculator_Scintific
{
    public partial class Form1 : Form
    {
        double enterFirstValue,enterSecondValue;
        string op;
        float iCelsius, iFahrenheit, iKevin;
        char iOperation;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 394;
            this.Height = 562;
            txtDisplay.Width = 349;
            
        }
        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 394;
            this.Height = 562;
            txtDisplay.Width = 349;
            
        }

        private void temperatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 928;
            this.Height = 550;
            txtDisplay.Width = 349;
        }

        private void EnterNumbers(object sender, EventArgs e)
        {
            if ((txtDisplay.Text == "0"))
                txtDisplay.Text = "";
            
            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!txtDisplay.Text.Contains("."))
                {
                    txtDisplay.Text += num.Text;
                }

            }
            else
            {
                txtDisplay.Text += num.Text;
            }
        }
        private void numOperator(object sender, EventArgs e)
        {
            Button Operator = (Button)sender;
            enterFirstValue = Convert.ToDouble(txtDisplay.Text);
            op= Operator.Text;
            txtDisplay.Text = "";
        }



        private void btnEqual_Click(object sender, EventArgs e)
        {
            enterSecondValue= Convert.ToDouble(txtDisplay.Text);

            switch (op)
            {
                case "+":
                    txtDisplay.Text = (enterFirstValue + enterSecondValue).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (enterFirstValue - enterSecondValue).ToString();
                    break;
                case "*":
                    txtDisplay.Text = (enterFirstValue * enterSecondValue).ToString();
                    break;
                case "/":
                    txtDisplay.Text = (enterFirstValue / enterSecondValue).ToString();
                    break;
                case "x^y":
                    txtDisplay.Text = Math.Pow(enterFirstValue, enterSecondValue).ToString();
                    break;
                case "Exp":
                    double i = Convert.ToDouble(txtDisplay.Text);
                    double j = enterSecondValue;
                    txtDisplay.Text = Math.Exp(i * Math.Log(j * 4)).ToString();
                    break;
                case "Mod":
                    txtDisplay.Text = (enterFirstValue % enterSecondValue).ToString();
                    break;
                default:
                    break;
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }
        private void btnClearEntry_Click_1(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            string firstNum , secondNum ;
            firstNum = Convert.ToString(enterFirstValue);
            secondNum = Convert.ToString(enterSecondValue);

            firstNum = "";
            secondNum = "";
        }

        private void btnBS_Click(object sender, EventArgs e)
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exitCalculator;
            exitCalculator = MessageBox.Show("Confirm if you want to exit", "Scintific Calculator",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exitCalculator == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "3.141592653589976323";
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            double Log = Convert.ToDouble(txtDisplay.Text);
            Log = Math.Log10(Log);
            txtDisplay.Text = Log.ToString();
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double Sqrt = Convert.ToDouble(txtDisplay.Text);
            Sqrt = Math.Sqrt(Sqrt);
            txtDisplay.Text = Sqrt.ToString();
        }

        private void btnX2_Click(object sender, EventArgs e)
        {
            double X2 = Convert.ToDouble(txtDisplay.Text);
            X2 = Math.Pow(X2, 2);
            txtDisplay.Text = X2.ToString();
        }

        private void btnSinh_Click(object sender, EventArgs e)
        {
            double Sinh = Convert.ToDouble(txtDisplay.Text);
            Sinh = Math.Sinh(Sinh);
            txtDisplay.Text = Sinh.ToString();
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            double Sin = Convert.ToDouble(txtDisplay.Text);
            Sin = Math.Sin(Sin);
            txtDisplay.Text = Sin.ToString();
        }

        private void btnCosh_Click(object sender, EventArgs e)
        {
            double Cosh = Convert.ToDouble(txtDisplay.Text);
            Cosh = Math.Cosh(Cosh);
            txtDisplay.Text = Cosh.ToString();
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            double Cos = Convert.ToDouble(txtDisplay.Text);
            Cos = Math.Cos(Cos);
            txtDisplay.Text = Cos.ToString();
        }

        private void btnTanh_Click(object sender, EventArgs e)
        {
            double Tanh = Convert.ToDouble(txtDisplay.Text);
            Tanh = Math.Tanh(Tanh);
            txtDisplay.Text = Tanh.ToString();
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            double Tan = Convert.ToDouble(txtDisplay.Text);
            Tan = Math.Tan(Tan);
            txtDisplay.Text = Tan.ToString();
        }

        private void btn1X_Click(object sender, EventArgs e)
        {
            double x;
            x = (1 / Convert.ToDouble(txtDisplay.Text));
            txtDisplay.Text = x.ToString();
        }

        private void btnLnX_Click(object sender, EventArgs e)
        {
            double LnX = Convert.ToDouble(txtDisplay.Text);
            LnX = Math.Log(LnX);
            txtDisplay.Text = LnX.ToString();
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            double pre;
            pre = Convert.ToDouble(txtDisplay.Text) / 100;
            txtDisplay.Text = pre.ToString();
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            double dec = Convert.ToDouble(txtDisplay.Text);
            int i1 = Convert.ToInt32(dec);
            txtDisplay.Text = i1.ToString();
        }

        private void btnBin_Click(object sender, EventArgs e)
        {
            int bin = Convert.ToInt32(txtDisplay.Text);
            txtDisplay.Text = Convert.ToString(bin, 2);
        }

        private void btnHex_Click(object sender, EventArgs e)
        {
            int hex = Convert.ToInt32(txtDisplay.Text);
            txtDisplay.Text = Convert.ToString(hex, 16);
        }

        private void btnOct_Click(object sender, EventArgs e)
        {
            int oct = Convert.ToInt32(txtDisplay.Text);
            txtDisplay.Text = Convert.ToString(oct, 8);
        }

        private void btnPM_Click(object sender, EventArgs e)
        {
            double equal = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = Convert.ToString(-1 * equal);
        }

        private void rbCelsiusToFahrenheit_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'C';
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtValueToConvert.Clear();
            txtConvert.Text = "";
            rbCelsiusToFahrenheit.Checked = false;
            rbFahrenheitToCelsius.Checked = false;
            rbKelvin.Checked = false;
        }

        private void rbFahrenheitToCelsius_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'F';
        }
        private void rbKevin_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'K';
        }
        private void btnConvert_Click(object sender, EventArgs e)
        {
            switch (iOperation)
            {
                case 'C':
                    iCelsius = float.Parse(txtValueToConvert.Text);
                    txtConvert.Text = ((iCelsius * 1.8) + 32).ToString();
                    break;
                case 'F':
                    iFahrenheit = float.Parse(txtValueToConvert.Text);
                    txtConvert.Text = ((iFahrenheit - 32) / 1.8).ToString();
                    break;
                case 'K':
                    iKevin = float.Parse(txtValueToConvert.Text);
                    txtConvert.Text = (((iCelsius * 1.8) + 32) + 273.15).ToString();
                    break;
                default:
                    break;
            }
        }

    }
}
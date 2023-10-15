namespace CalculatorWInForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool isClickMouse = false;
        private Point currentPosition = new Point(0, 0);
        private bool isPoint = false;
        private bool isNum2 = false;
        private string num1 = null;
        private string num2 = null;
        private string currentOperation = "";

        private void AddNumm(string txt)
        {
            if (isNum2)
            {
                num2 += txt;
                textResult.Text = num2;
            }
            else
            {
                num1 += txt;
                textResult.Text = num1;
            }
        }
        private void SetNum(string txt)
        {
            if (isNum2)
            {
                num2 = txt;
                textResult.Text = num2;
            }
            else
            {
                num1 = txt;
                textResult.Text = num1;
            }
        }

        private void buttonNumberClick(object sender, EventArgs e)
        {
            var txt = ((Button)sender).Text;
            {
                if (isPoint && txt == ",") { return; }
                if (txt == ",") { isPoint = true; }
            }

            if (txt == "+/-")
            {
                if (textResult.Text.Length > 0)
                    if (textResult.Text[0] == '-')
                    {
                        textResult.Text = textResult.Text.Substring(1, textResult.Text.Length - 1);
                    }
                    else
                    {
                        textResult.Text = '-' + textResult.Text;
                    }
                SetNum(textResult.Text);
                return;
            }
            AddNumm(txt);
        }

        private void buttonOperationClick(object sender, EventArgs e)
        {
            if (num1 == null) { if (textResult.Text.Length > 0) num1 = textResult.Text; else return; }

            isNum2 = true;
            currentOperation = ((Button)sender).Text;
            SetResult(currentOperation);
        }

        private void SetResult(string operation)
        {
            string result = null;

            switch (operation)
            {
                case "+": { result = MathOperation.Add(num1, num2); break; }
                case "-": { result = MathOperation.Sub(num1, num2); break; }
                case "*": { result = MathOperation.Mul(num1, num2); break; }
                case "/": { result = MathOperation.Dev(num1, num2); break; }
                case "%": { result = MathOperation.Proc(num1, num2); break; }
                case "SQRT": { result = MathOperation.Sqrt(num1); isNum2 = false; break; }
                case "x^2": { result = MathOperation.Pow(num1); isNum2 = false; break; }
                case "1/X": { result = MathOperation.OneDev(num1); isNum2 = false; break; }
                default: break;
            }
            OutputResult(result, operation);
            if (isNum2) { if (result != null) num1 = result; } else { num1 = null; }
            isPoint = false;
        }

        private void OutputResult(string result, string operation)
        {
            switch (operation)
            {
                case "SQRT": { if (num1 != null) textHistory.Text = "SQRT" + num1 + " = "; break; }
                case "x^2": { if (num1 != null) textHistory.Text = num1 + "^2 = "; break; }
                case "1/X": { if (num1 != null) textHistory.Text = "1/" + num1 + " = "; break; }
                default:
                    {
                        if (num2 != null)
                        {
                            textHistory.Text = num1 + " " + operation + " " + num2 + " = ";
                        }
                        else
                        {
                            if (num1 != null)
                            {
                                textHistory.Text = num1 + " " + operation + " ";
                                break;
                            }
                        }
                    }
                    break;
            }

            num2 = null;
            if (result != null)
            {
                textResult.Text = result;
            }

        }

        private void buttonClear(object sender, EventArgs e)
        {
            textResult.Text = "";
            textHistory.Text = "";
            isNum2 = false;
            currentOperation = null;
            num1 = null;
            num2 = null;
            isPoint = false;

        }

        private void buttonResultClick(object sender, EventArgs e)
        {
            SetResult(currentOperation);
            num1 = null;
            num2 = null;
            isNum2 = false;
        }

        private void buttonResetNumber(object sender, EventArgs e)
        {
            if (textResult.Text.Length <= 0) { return; }
            textResult.Text = textResult.Text.Substring(0, textResult.Text.Length - 1);
            SetNum(textResult.Text);
        }





        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void textHistory_Click(object sender, EventArgs e)
        {

        }
    }
}
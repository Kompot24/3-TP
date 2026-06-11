namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private void Calculate()
        {
            try
            {
                var firstValue = double.Parse(textBox3.Text);
                var secondValue = double.Parse(textBox4.Text);

                var thirdValue = double.Parse(textBox1.Text);
                var fourthValue = double.Parse(textBox2.Text);

                var firstFract = new Fraction(firstValue, secondValue);
                var secondFract = new Fraction(thirdValue, fourthValue);

                var fraction = new Fraction(0, 0);

                switch (comboBox1.Text)
                {
                    case "+":
                        fraction = firstFract + secondFract;
                        break;
                    case "-":
                        fraction = firstFract - secondFract;
                        break;
                    case "*":
                        fraction = firstFract * secondFract;
                        break;
                    case "/":
                        fraction = firstFract / secondFract;
                        break;

                    case "Сократить":
                        fraction = firstFract.Reduction(firstFract);
                        break;

                    case ">":
                        fraction = firstFract > secondFract;
                        break;

                    case "<":
                        fraction = firstFract < secondFract;
                        break;
                    default:
                        break;
                }

                textBox5.Text = fraction.Verbose();
            }
            catch (FormatException)
            {

            }

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void onValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}

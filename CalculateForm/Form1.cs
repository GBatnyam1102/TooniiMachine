using Calculator.MainCalculator;
using WindowsFormsControlLibrary;

namespace CalculateForm
{
    public partial class Form1 : Form
    {
        public bool isOp = false;
        public bool isNumber = false;
        public bool isadd = false;
        public bool isEqualButt = false;
        public string undsenUtga = "";
        public string useEqualbut = "0";

        BaseCalculator calculator = new BaseCalculator();
        public Form1()
        {
            InitializeComponent();
        }
        public BaseCalculator ViewCalc()
        {
            return calculator;
        }
        private void MemorySaveButton_Click(object sender, EventArgs e)
        {
            MemoryOneItem memoryOneItem = new MemoryOneItem();
            memoryOneItem.ChangeLabelText(calculator);
            flowLayoutPanel1.Controls.Add(memoryOneItem);
        }

        private void Number_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null && isOp == false)
            {
                textBox1.Text += button.Text;
                undsenUtga += button.Text;
            }
            else
            {
                undsenUtga += button.Text;
                textBox1.Text = undsenUtga;
            }
            isNumber = true;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Button button1 = sender as Button;
            if (button1 != null && isNumber == true)
            {
                calculator.Result += int.Parse(undsenUtga);
                isNumber = false;
                isOp = true;
                textBox1.Text = calculator.Result.ToString();
                useEqualbut = undsenUtga;
                isadd = true;
            }
            undsenUtga = "";
        }

        private void SubButton_Click(object sender, EventArgs e)
        {
            Button button1 = sender as Button;
            if (button1 != null && isNumber == true)
            {
                calculator.Result -= int.Parse(undsenUtga);
                isNumber = false;
                isOp = true;
                textBox1.Text = calculator.Result.ToString();
                useEqualbut = undsenUtga;
                isadd = false;
            }
            undsenUtga = "";
        }

        private void ResultClearButton_Click(object sender, EventArgs e)
        {
            Button button1 = sender as Button;
            if (button1 != null)
            {
                calculator.ClearResult();
                textBox1.Text = calculator.Result.ToString();
                useEqualbut = "0";
                undsenUtga = "";
            }
        }

        private void Equalbutton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                if (!isEqualButt)
                {
                    if (isadd)
                    {
                        calculator.Result += int.Parse(textBox1.Text);
                    }
                    else
                    {
                        calculator.Result -= int.Parse(textBox1.Text);
                    }
                }
                else
                {
                    if (isadd)
                    {
                        calculator.Result += int.Parse(useEqualbut);
                    }
                    else
                    {
                        calculator.Result -= int.Parse(useEqualbut);
                    }
                }
                textBox1.Text = calculator.Result.ToString();
            }
            isEqualButt = true;

        }
    }
}

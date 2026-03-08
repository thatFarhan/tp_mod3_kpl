using System.Collections;
namespace TP_MODUL3_103022400083
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string rawNumber = "";
        ArrayList numbers = new ArrayList();
        bool newSession = true;

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Output Label";
            rawNumber = "";
            numbers.Clear();
            bool newSession = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addNumbers("1");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            addNumbers("2");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            addNumbers("3");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            addNumbers("4");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            addNumbers("5");
        }
        private void button6_Click(object sender, EventArgs e)
        {
            addNumbers("6");
        }
        private void button7_Click(object sender, EventArgs e)
        {
            addNumbers("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            addNumbers("8");
        }
        private void button9_Click(object sender, EventArgs e)
        {
            addNumbers("9");
        }
        private void button11_Click(object sender, EventArgs e)
        {
            addNumbers("0");
        }

        private void addNumbers(string a)
        {
            if (newSession)
            {
                label1.Text = a;
            }
            else
            {
                label1.Text += a;
            }
            rawNumber += a;
            newSession = false;
        }

        private void combineNumbers()
        {
            int convertedRaw = int.Parse(rawNumber);
            numbers.Add(convertedRaw);
            rawNumber = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            combineNumbers();
            label1.Text += "+";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            combineNumbers();

            int result = 0;
            foreach (int number in numbers)
            {
                result += number;
            }
            label1.Text += "=" + result.ToString();
            numbers.Clear();
            rawNumber = "";
            newSession = true;
        }
    }
}

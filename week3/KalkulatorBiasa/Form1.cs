namespace KalkulatorBiasa
{
    public partial class Form1 : Form
    {
        double num1, num2, result;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
            num2 = double.Parse(textBox2.Text);
            result = num1 + num2;
            textBox3.Text = result.ToString();  
        }
        private void button2_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
            num2 = double.Parse(textBox2.Text);
            result = num1 - num2;
            textBox3.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
            num2 = double.Parse(textBox2.Text);
            result = num1 * num2; 
            textBox3.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
            num2 = double.Parse(textBox2.Text);
            result = num1 / num2;
            textBox3.Text = result.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

    }
}

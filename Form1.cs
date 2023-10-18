namespace fibo
{
    public partial class Form1 : Form
    {
        public int Fibo(int num)
        {
            if (num <= 2)
            {
                return 1;
            }
            else
            {
                return Fibo(num - 1) + Fibo(num - 2);
            }
        }
        public Form1()


        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(textBox1.Text);
                int res = Fibo(num1);
                MessageBox.Show(res.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ivalid use");
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
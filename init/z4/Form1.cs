namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);

            int nwd = NWD(a, b);
            int nww = NWW(a, b);

            label1.Text = $"NWD: {nwd}, NWW: {nww}";
            
        }
        private int NWD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        private int NWW(int a, int b)
        {
            return (a * b) / NWD(a, b);
        }
    }
}

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private int bulgarska(int n)
        {
            int suma = 0;
            while (n > 0)
            {
                suma += n % 10;
                n /= 10;
            }
            return suma;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int liczba1 = int.Parse(textBox1.Text);
            int liczba2 = int.Parse(textBox2.Text);

            if (liczba1 < 10 || liczba1 > 99 || liczba2 < 10 || liczba2 > 99)
            {
                label1.Text = "liczby musza byc dwu cyfrowe";   
            }
            else
            {
                label1.Text = "liczby sa dwu cyfrowe";
            }

            int bulgarskaa = bulgarska(liczba1) + bulgarska(liczba2);
            
        }
    }
}

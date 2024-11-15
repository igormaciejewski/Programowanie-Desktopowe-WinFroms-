namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int sumadzielnikow(int n)
        {
            int suma = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    suma += i;
                }
            }
            return suma;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int liczba1 = int.Parse(textBox1.Text);
            int liczba2 = int.Parse(textBox2.Text);

            int suma1 = sumadzielnikow(liczba1);
            int suma2 = sumadzielnikow(liczba2);

            if (suma1 == liczba2 && suma2 == liczba1)
            {
                label1.Text = "Liczby sa zaprzyjaznione";
            }
            else
            {
                label1.Text = "Liczby nie sa zaprzyjaznione";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

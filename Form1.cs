namespace Modul3_10302240023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convert_Btn_Click(object sender, EventArgs e)
        {

            if (satuanAwal.Text == "" || satuanAkhir.Text == "")
            {
                MessageBox.Show("Pilih satuan terlebih dahulu", "Invalid Input");
                return;
            } else if (nilai_awal.Text == "")
            {
                MessageBox.Show("Masukkan angka yang valid!", "Invalid Input");
                return;
            }
            int a = int.Parse(nilai_awal.Text);
            int b = 0;

            if (satuanAwal.Text == satuanAkhir.Text)
            {
                nilai_akhir.Text = a.ToString();
                return;
            }
            else if (satuanAwal.Text == "Celcius")
            {
                if (satuanAkhir.Text == "Reamur")
                {
                    b = (4 * a) / 5;
                }
                else if (satuanAkhir.Text == "Kelvin")
                {
                    b = a + 273;
                }
                else if (satuanAkhir.Text == "Fahrenheit")
                {
                    b = (9 * (a + 32)) / 5;
                }
            }
            else if (satuanAwal.Text == "Reamur")
            {
                if (satuanAkhir.Text == "Celcius")
                {
                    b = ((5 * a) / 4);
                }
                else if (satuanAkhir.Text == "Kelvin")
                {
                    b = ((5 * (a + 273)) / 4);
                }
                else if (satuanAkhir.Text == "Fahrenheit")
                {
                    b = ((9 * (a + 32)) / 4);
                }
            }
            else if (satuanAwal.Text == "Fahrenheit")
            {
                if (satuanAkhir.Text == "Celcius")
                {
                    b = ((5 * (a - 32)) / 9);
                }
                else if (satuanAkhir.Text == "Reamur")
                {
                    b = (4 * (a - 32)) / 9;
                }
                else if (satuanAkhir.Text == "Kelvin")
                {
                    b = ((5 * (a - 32)) / 9) + 273;
                }
            }
            else if (satuanAwal.Text == "Kelvin")
            {
                if (satuanAkhir.Text == "Celcius")
                {
                    b = a - 273;
                }
                else if (satuanAkhir.Text == "Reamur")
                {
                    b = (4 * (a - 732)) / 5;
                }
                else if (satuanAkhir.Text == "Fahrenheit")
                {
                    b = ((9 * (a - 273)) / 5) + 32;
                }
            }

            nilai_akhir.Text = b.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }
    }
}

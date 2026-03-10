namespace Modul3_103022430005
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih satuan terlebih dahulu!");
                return;
            }

            double nilaiAwal;
            bool isAngkaValid =
                double.TryParse(textBox1.Text, out nilaiAwal);
            if (!isAngkaValid)
            {
                MessageBox.Show("Masukkan angka yang valid!");
                return;
            }

            string from = comboBox1.SelectedItem.ToString();
            string to = comboBox2.SelectedItem.ToString();
            double hasil = 0;

            if (from == "Celcius" && to == "Fahreinheit")
            {
                hasil = (9 / 5) * nilaiAwal + 32;
                textBox2.Text = hasil.ToString();
            }
            else if (from == "Celcius" && to == "Reamur")
            {
                hasil = (4.0 / 5.0) * nilaiAwal;
            }
            else if (from == "Celcius" && to == "Kelvin")
            {
                hasil = nilaiAwal + 273.15;
            }
        }
    }
}

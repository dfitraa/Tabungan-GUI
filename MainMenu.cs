using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabunganGUI
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SimpanUang simpanUang = new SimpanUang();
            simpanUang.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CekSaldo cekSaldo = new CekSaldo();
            cekSaldo.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AmbilUang ambilUang = new AmbilUang();
            ambilUang.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AmbilUangDollar ambilUangDollar = new AmbilUangDollar();
            ambilUangDollar.Show();
            this.Hide();
        }
    }
}

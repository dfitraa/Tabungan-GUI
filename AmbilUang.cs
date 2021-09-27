using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TabunganGUI
{
    public partial class AmbilUang : Form
    {
        public AmbilUang()
        {
            InitializeComponent();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Controller controller = new Controller(20000);
            int jumlah = Convert.ToInt32(textBox1.Text);
            Controller.controller.ambilRupiah(jumlah);
            MessageBox.Show("Sisa Saldo: Rp."+Controller.controller.cekSaldo());
        }

        private void AmbilUang_Load(object sender, EventArgs e)
        {

        }
    }
}

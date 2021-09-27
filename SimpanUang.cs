using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TabunganGUI
{
    public partial class SimpanUang : Form
    {

        public int jumlah;
        public SimpanUang()
        {
            InitializeComponent();
        }

        //Controller controller = new Controller(15000);


        private void button2_Click(object sender, EventArgs e)
        {
            
            jumlah = Convert.ToInt32(textBox1.Text);
            Controller.controller.biayaAdministrasi(5000);
            Controller.controller.simpanUang(jumlah);
            MessageBox.Show("Saldo Sekarang "+Controller.controller.cekSaldo().ToString()+" Rupiah");
           

        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void SimpanUang_Load(object sender, EventArgs e)
        {
            //controller.simpanUang(jumlah);
        }
    }
}

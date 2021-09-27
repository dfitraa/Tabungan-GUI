using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TabunganGUI
{
    public partial class CekSaldo : Form
    {
        public CekSaldo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void CekSaldo_Load(object sender, EventArgs e)
        {
            label2.Text = Controller.controller.cekSaldo().ToString();
        }
    }
}

using System.Windows.Forms;

namespace TabunganGUI
{
    class Controller
    {

        private int saldo;
        public static readonly Controller controller = new Controller(); 

        public Controller()
        {
            saldo = 0;
        }

        public int cekSaldo()
        {
            return saldo;
        }

        public void biayaAdministrasi(int jumlah)
        {
            saldo -= jumlah;
        }

        public void simpanUang(int jumlah)
        {
            
            saldo += jumlah;
            
        }

        public bool ambilRupiah(int jumlah)
        {
            if (jumlah > saldo)
            {
                
                MessageBox.Show("Saldo anda tidak cukup ");
                return false;
            }
            else
            {
                biayaAdministrasi(5000);
                saldo -= jumlah;
                return true;
            }
        }

        public bool ambilDollar(int jumlah)
        {
            int administrasi = jumlah * 50;
            int konversiRupiah = jumlah * 15000;
            if ((saldo - (konversiRupiah + administrasi)) < 0)
            {
                return false;
            }
            else
            {
                saldo = saldo - (konversiRupiah + administrasi);
                return true;
            }
        }
    }
}

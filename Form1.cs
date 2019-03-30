using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        Kullanici Kullan = new Kullanici();
        TicTacToe Oyun = new TicTacToe();
       

        private void buttonGiris_Click(object sender, EventArgs e)
        {
            if(Kullan.KullaniciAdi==textBoxKAdi.Text && Kullan.Sifre==textBoxSifre.Text)
            {
                AnaForm FormKapa = new AnaForm();
                Oyun.ShowDialog();
                FormKapa.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış!!");
            }
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            Kullan.KullaniciAdi = "FG";
            Kullan.Sifre = "FG";
        }
    }
}

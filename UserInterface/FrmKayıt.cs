using DataAccess.Concrete;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class FrmKayıt : Form
    {
        UserDal userDal;
        bool durum = false;
        public FrmKayıt()
        {
            InitializeComponent();
            userDal = UserDal.GetInstance();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            Kontroller();
            if (durum)
            {
                string mesaj=userDal.Add(new User(TxtKullanıcıAdı.Text, TxtAdSoyad.Text, MskKimlik.Text, MskTelefon.Text, MskMail.Text, RchAdres.Text, 2));
                userDal.AddLogin(TxtKullanıcıAdı.Text, TxtSifre.Text);
                MessageBox.Show(mesaj,"Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            
        }

        private void FrmKayıt_Load(object sender, EventArgs e)
        {
            
        }

        public void Kontroller()//Bilgilerin Eksiksiz Girildiğini Kontrol Ediyoruz
        {
            if (string.IsNullOrEmpty(TxtAdSoyad.Text)|| string.IsNullOrEmpty(TxtKullanıcıAdı.Text) ||string.IsNullOrEmpty(TxtSifre.Text)||
                string.IsNullOrEmpty(MskKimlik.Text)||string.IsNullOrEmpty(MskMail.Text)||string.IsNullOrEmpty(MskTelefon.Text))
            {
                MessageBox.Show("Kullanıcı Bilgileri Boş Geçilemez","Dikkat",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if(TxtKullanıcıAdı.Text.Length>20)
            {
                MessageBox.Show("Kullanıcı Adı 20 Karakteri Geçemez", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MskKimlik.Text.Length < 11)
            {
                MessageBox.Show("Kimlik No 11 Karakterden Az Olamaz", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (TxtSifre.Text.Length > 15)
            {
                MessageBox.Show("Şifre 15 Karakteri Geçemez", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            durum = true;
        }
    }
}

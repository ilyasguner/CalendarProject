using DataAccess.Concrete;
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
    public partial class FrmGiris : Form
    {
        UserDal userDal;
        bool durum=false;
        public FrmGiris()
        {
            InitializeComponent();
            userDal = UserDal.GetInstance();
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            Kontroller();
            if(durum)
            {
                object[] infos = userDal.Login(TxtKullanıcıAdı.Text, TxtSifre.Text);
                if (infos!=null)
                {
                    FrmTakvim frmTakvim = new FrmTakvim();
                    frmTakvim.infos = infos;
                    frmTakvim.Show();
                    this.Hide();
                }else
                {
                    MessageBox.Show("Bilgileriniz Yanlış Lütfen Tekrar Deneyiniz");
                    TxtKullanıcıAdı.Text = "";
                    TxtSifre.Text = "";
                }

            }
            
        }
        public void Kontroller()//Bilgileri Kontrol ediyoruz
        {
            if(string.IsNullOrEmpty(TxtKullanıcıAdı.Text)||string.IsNullOrEmpty(TxtSifre.Text))
            {
                MessageBox.Show("Kullanıcı Adı ve Şifre Boş Geçilemez","Dikkat",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (TxtKullanıcıAdı.Text.Length > 20)
            {
                MessageBox.Show("Kullanıcı Adı 20 Karakteri Geçemez", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (TxtSifre.Text.Length > 15)
            {
                MessageBox.Show("Şifre 15 Karakteri Geçemez", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            durum = true;
        }
        private void LnkKayıtOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmKayıt frmKayıt = new FrmKayıt();
            frmKayıt.Show();
        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {

        }
    }
}

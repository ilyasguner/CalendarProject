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

        public FrmGiris()
        {
            InitializeComponent();
            userDal = UserDal.GetInstance();
        }

        private void BtnGiris_Click(object sender, EventArgs e)
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

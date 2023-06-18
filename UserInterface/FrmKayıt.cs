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
            //userDal.Add(new User(TxtKullanıcıAdı.Text, TxtAdSoyad.Text, MskKimlik.Text, MskTelefon.Text, MskMail.Text, RchAdres.Text, 2));
            userDal.AddLogin(TxtKullanıcıAdı.Text, TxtSifre.Text);
        }
    }
}

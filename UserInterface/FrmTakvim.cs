using DataAccess.Concrete;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class FrmTakvim : Form
    {
        public object[] infos;
        EventDal eventsDal;
        Events events;        
        bool timerDurdur=true;
        SoundPlayer player = new SoundPlayer(Properties.Resources.alarm2);
        public FrmTakvim()
        {
            InitializeComponent();
            eventsDal = EventDal.GetInstance();
        }

        private void FrmTakvim_Load(object sender, EventArgs e)
        {
            OlayListesi();           
        }


        void OlayListesi()
        {//datagried için kaynak olarak sqlde yazdığımız  kullanıcı adına göre olayları getiren prosedürümüzü çağırıyoruz
            DtgTakvim.DataSource = eventsDal.OlaylarıListele("GetDescription", infos[0].ToString());
            DataGriedDoldur();
        }

        void DataGriedDoldur()//sqlden gelen başlıkları ayarlıyoruz
        {
            DtgTakvim.Columns["ID"].Visible = false;
            DtgTakvim.Columns["EventId"].Visible = false;
            DtgTakvim.Columns["UserName"].Visible = false;
            DtgTakvim.Columns["EventName"].HeaderText = "Olay Adı";
            DtgTakvim.Columns["EventContent"].HeaderText = "Olay Açıklaması";
            DtgTakvim.Columns["CreatingTime"].HeaderText = "Oluşturma Zamanı";
            DtgTakvim.Columns["StartTime"].HeaderText = "Başlangıç Zamanı";
        }

        private void DtgTakvim_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {//seçilen satırın bilgilerini yazdırma
            if (DtgTakvim.CurrentRow == null)
            {
                MessageBox.Show("Öncelikle Bir Satır Seçiniz");
            }

            DataGridViewRow row = DtgTakvim.CurrentRow;

            events = new Events(//events kısmında oluşturulan constructor
                row.Cells["EventName"].Value.ToString(),
                row.Cells["EventContent"].Value.ToString(),
                row.Cells["CreatingTime"].Value.ConDate(),
                row.Cells["StartTime"].Value.ConDate()
                );

            TxtOlay.Text = events.EventName;
            RchAciklama.Text = events.EventContent;
            DtpOlusturma.Text = events.CreatingTime.ToString();
            MskOlusturma.Text = events.CreatingTime.ToShortTimeString();
            DtpBaslangic.Text = events.StartTime.ToString();
            MskBaslangic.Text = events.StartTime.ToShortTimeString();
        }

        private void BtnOlayTanımla_Click(object sender, EventArgs e)
        {           
            DateTime başlangıcTarihi = DtpBaslangic.Value;
            TimeSpan başlangıçZamanı = TimeSpan.Parse(MskBaslangic.Text);
            DateTime birleşikTarih = başlangıcTarihi + başlangıçZamanı;

            events = new Events(TxtOlay.Text, infos[0].ToString(), RchAciklama.Text, birleşikTarih);
            string mesaj =eventsDal.Add(events);
            MessageBox.Show(mesaj,"Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Temizle();
            OlayListesi();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(!timerDurdur)
            {
                return;
            }
            int simdiDakika = DateTime.Now.Minute;
            int simdiSaat = DateTime.Now.Hour;
            foreach (DataGridViewRow satır in DtgTakvim.Rows)
            {
                if(!satır.IsNewRow)
                {
                    DataGridViewCell hucre = satır.Cells["StartTime"];
                    if (hucre.Value!=null && hucre.Value is DateTime)
                    {
                        DateTime tarih = (DateTime)hucre.Value;

                        if (tarih.Minute == simdiDakika &&tarih.Hour==simdiSaat) // Tarih eşleşiyorsa
                        {                            
                            timer1.Stop();
                            timerDurdur = false;
                            player.Play();
                            DialogResult dr=MessageBox.Show("Dikkat Bir Olay Zamanı Geldi","Dikkat",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                            if(dr==DialogResult.OK)
                            {
                                player.Stop();
                            }
                            TxtOlay.Text = satır.Cells["EventName"].Value.ToString();
                            RchAciklama.Text = satır.Cells["EventContent"].Value.ToString();
                            DtpOlusturma.Text = satır.Cells["CreatingTime"].Value.ToString();
                            DtpBaslangic.Text = satır.Cells["StartTime"].Value.ToString();
                            break;
                        }
                    }
                }              
            }
        }
        
        public void Temizle()//satırları temizleme
        {
            TxtOlay.Text = "";
            RchAciklama.Text = "";
            MskOlusturma.Text = "";
            MskBaslangic.Text = "";
        }
    }
}

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
    public partial class FrmTakvim : Form
    {
        public object[] infos;
        EventDal eventsDal;
        Events events;


        public FrmTakvim()
        {
            InitializeComponent();
            eventsDal = EventDal.GetInstance();
        }

        private void FrmTakvim_Load(object sender, EventArgs e)
        {
            BilgileriDoldur();
            OlayListesi();
            TxtOlay.Text = infos[0].ToString();
        }

        void BilgileriDoldur()
        {
            
        }

        void OlayListesi()
        {
            DtgTakvim.DataSource = eventsDal.OlaylarıListele("GetDescription", infos[0].ToString());
            DataGriedDoldur();
        }

        void DataGriedDoldur()
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
        {
            if (DtgTakvim.CurrentRow == null)
            {
                MessageBox.Show("Öncelikle Bir Satır Seçiniz");
            }

            DataGridViewRow row = DtgTakvim.CurrentRow;

            events = new Events(
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
    }
}

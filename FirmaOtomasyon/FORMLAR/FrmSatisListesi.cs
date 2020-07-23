using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirmaOtomasyon.FORMLAR
{
    public partial class FrmSatisListesi : Form
    {
        public FrmSatisListesi()
        {
            InitializeComponent();
        }
        DBFIRMAEntities db = new DBFIRMAEntities();
        private void FrmSatisListesi_Load(object sender, EventArgs e)
        {
            var satislar = (from x in db.TBLURUNSATIS

                            select new
                            {
                                x.SATISID,
                                x.TBLURUN.AD,
                                x.SERINO,
                                FIRMA = x.TBLFIRMA.AD,
                                SATISFIYAT = x.TBLURUN.SATISFIYAT,
                                PERSONEL = x.TBLPERSONEL.ADSOYAD,
                                x.TARIH,
                               TOPLAMFIYAT = x.FIYAT,
                                x.ADET,
                                x.KDV
                               
                            }

                             );

            gridControl1.DataSource = satislar.ToList();
        }
    }
}

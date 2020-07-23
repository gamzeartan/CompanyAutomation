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
    public partial class FrmAnasayfa : Form
    {
        public FrmAnasayfa()
        {
            InitializeComponent();
        }

        DBFIRMAEntities db = new DBFIRMAEntities();
        private void FrmAnasayfa_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TBLPERSONEL
                                       select new
                                       {
                                           x.ADSOYAD,
                                           x.TBLGOREV.GOREV,
                                           x.TELEFON
                                       }).ToList();


            //azalan stok

            gridControl2.DataSource = (from x in db.TBLURUN
                                       select new
                                       {
                                           x.AD,
                                           x.STOK
                                       }


                                       ).Where(x => x.STOK < 10).ToList();




            DateTime date = DateTime.Today;

            var deger = (from x in db.TBLNOT
                         select new
                         {
                             x.BASLIK,
                             x.ICERIK,
                             x.TARIH,
                             x.DURUM
                         }).Where(x => x.DURUM == false);

            gridControl3.DataSource = deger.ToList();



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

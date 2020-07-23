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
    public partial class FrmFatura : Form
    {
        public FrmFatura()
        {
            InitializeComponent();
        }
        void listele()
        {
            var faturalar = from prs in db.TBLFATURABILGI
                            select new
                            {
                                prs.ID,
                                prs.SERI,
                                prs.SIRA,
                                prs.TARIH,
                                prs.SAAT,
                                FIRMA = prs.TBLFIRMA.AD,
                                PERSONEL = prs.TBLPERSONEL.ADSOYAD

                            };

            gridControl1.DataSource = faturalar.ToList();




            lookUpEdit1.Properties.DataSource = (from x in db.TBLFIRMA
                                                 select new
                                                 {

                                                     x.ID,
                                                     x.AD


                                                 }).ToList();

            lookUpEdit2.Properties.DataSource = (from x in db.TBLPERSONEL
                                                 select new
                                                 {

                                                     x.ID,
                                                     x.ADSOYAD


                                                 }).ToList();



        }
        DBFIRMAEntities db = new DBFIRMAEntities();
        private void FrmFatura_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class FrmIadeListe : Form
    {
        public FrmIadeListe()
        {
            InitializeComponent();
        }

        DBFIRMAEntities db = new DBFIRMAEntities();
        private void FrmIadeListe_Load(object sender, EventArgs e)
        {
            var iadeler = (from x in db.TBLURUNISLEM
                           select new
                           {
                               x.ISLEMID,
                               x.SERINO,
                               FIRMA = x.TBLFIRMA.AD,
                               PERSONEL = x.TBLPERSONEL.ADSOYAD,
                               x.GELISTARIH,
                             
                               x.ADET,
                               x.ACIKLAMA });
            gridControl1.DataSource = iadeler.ToList();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            labelid.Text = gridView1.GetFocusedRowCellValue("ISLEMID").ToString();
            label2.Text = gridView1.GetFocusedRowCellValue("SERINO").ToString();

            labelfirma.Text = gridView1.GetFocusedRowCellValue("FIRMA").ToString();
            labelpersonel.Text = gridView1.GetFocusedRowCellValue("PERSONEL").ToString();
            labelgelis.Text = gridView1.GetFocusedRowCellValue("GELISTARIH").ToString();
            labeladet.Text = gridView1.GetFocusedRowCellValue("ADET").ToString();
            labelaciklama.Text = gridView1.GetFocusedRowCellValue("ACIKLAMA").ToString();

        }
    }
}

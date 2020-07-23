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
    public partial class FrmNotlar : Form
    {
        public FrmNotlar()
        {
            InitializeComponent();
        }

        DBFIRMAEntities db = new DBFIRMAEntities();
        private void FrmNotlar_Load(object sender, EventArgs e)
        {
            refreshG();
            //groupControl1.BackColor = Color.AliceBlue;

        }


        void refreshG()
        {
            gridControl1.DataSource = db.TBLNOT.Where(x => x.DURUM == false).ToList();
            gridControl2.DataSource = db.TBLNOT.Where(y => y.DURUM == true).ToList();
        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            TBLNOT tbl = new TBLNOT();
            tbl.BASLIK = txtBaslik.Text;
            tbl.ICERIK = txtIcerik.Text;
            tbl.TARIH = DateTime.Parse(txtTarih.Text);
            tbl.DURUM = false;

            db.TBLNOT.Add(tbl);
            db.SaveChanges();
            MessageBox.Show("İşlem başarıyla gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);



            refreshG();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            labelID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            labelbaslik.Text = gridView1.GetFocusedRowCellValue("BASLIK").ToString();
            labelicerik.Text = gridView1.GetFocusedRowCellValue("ICERIK").ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if(checkEdit1.Checked == true)
            {
                int id = int.Parse(labelID.Text);
                var deger = db.TBLNOT.Find(id);
                deger.DURUM = true;
                db.SaveChanges();
                MessageBox.Show("İşlem gerçekleştirildi.", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                refreshG();
            }    
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Silme işleminden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dg == DialogResult.Yes)
            {
                int ID = int.Parse(labelID.Text);
                var sil = db.TBLNOT.Find(ID);
                db.TBLNOT.Remove(sil);
                db.SaveChanges();
                MessageBox.Show("İşlem başarıyla gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Silme işlemi ipal edildi.");
            }

            refreshG();       }
    }
}

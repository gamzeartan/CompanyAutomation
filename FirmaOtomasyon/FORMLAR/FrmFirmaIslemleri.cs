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
    public partial class FrmFirmaIslemleri : Form
    {
        public FrmFirmaIslemleri()
        {
            InitializeComponent();
        }

        void refresh()
        {
            gridControl1.DataSource = db.TBLFIRMA.ToList();
        }



        DBFIRMAEntities db = new DBFIRMAEntities();
        private void FrmFirmaIslemleri_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void gridView1_FocusedRowChanged(object sender,
            DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtFirmaID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtFirmaAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            txtTlf.Text = gridView1.GetFocusedRowCellValue("TELEFON").ToString();
            txtMail.Text = gridView1.GetFocusedRowCellValue("MAIL").ToString();
            textBox1.Text = gridView1.GetFocusedRowCellValue("IL").ToString();
            txtOdeme.Text = gridView1.GetFocusedRowCellValue("ODEME").ToString();
            txtFirmaNo.Text = gridView1.GetFocusedRowCellValue("FIRMANO").ToString();
            txtStatu.Text = gridView1.GetFocusedRowCellValue("STATU").ToString();
            txtAdres.Text = gridView1.GetFocusedRowCellValue("ADRES").ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Silme işleminden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dg == DialogResult.Yes)
            {
                int ID = int.Parse(txtFirmaID.Text);
                var sil = db.TBLFIRMA.Find(ID);
                db.TBLFIRMA.Remove(sil);
                db.SaveChanges();
                MessageBox.Show("İşlem başarıyla gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Silme işlemi ipal edildi.");
            }

            refresh();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            TBLFIRMA tbl = new TBLFIRMA();
            tbl.AD = txtFirmaAd.Text;
            tbl.TELEFON = txtTlf.Text;
            tbl.MAIL = txtMail.Text;
            tbl.IL = textBox1.Text;
            tbl.ODEME = txtOdeme.Text;
            tbl.FIRMANO = txtFirmaNo.Text;
            tbl.STATU = txtStatu.Text;
            tbl.ADRES = txtAdres.Text;
            db.TBLFIRMA.Add(tbl);
            db.SaveChanges();
            MessageBox.Show("İşlem başarıyla gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refresh();       }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            int id = int.Parse(txtFirmaID.Text);
            var guncelle = db.TBLFIRMA.Find(id);
            guncelle.AD = txtFirmaAd.Text;
            guncelle.TELEFON = txtTlf.Text;
            guncelle.MAIL = txtMail.Text;
            guncelle.IL = textBox1.Text;
            guncelle.ODEME = txtOdeme.Text;
            guncelle.FIRMANO = txtFirmaNo.Text;
            guncelle.STATU = txtStatu.Text;
            guncelle.ADRES = txtAdres.Text;
            db.SaveChanges();
            MessageBox.Show("İşlem başarıyla gerçekleşti.");
            refresh();
        }
    }
}

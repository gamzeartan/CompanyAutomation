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
    public partial class FrmPersonelIslemleri : Form
    {
        public FrmPersonelIslemleri()
        {
            InitializeComponent();
        }

        DBFIRMAEntities db = new DBFIRMAEntities();
        void refresh()
        {
            var personeller = from prs in db.TBLPERSONEL
                              select new
                              {
                                  prs.ID,
                                  prs.TCNO,
                                  prs.ADSOYAD,
                                  prs.TELEFON,
                                  prs.MAIL,
                                  prs.ADRES,
                                  prs.GOREV,
                                  prs.FOTOGRAF
                              };

            gridControl1.DataSource = personeller.ToList();

        }
        private void FrmPersonelIslemleri_Load(object sender, EventArgs e)
        {
            refresh();

            lookupGorev.Properties.DataSource = (from x in db.TBLGOREV
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.GOREV
                                                 }).ToList();

            label8.Text = db.TBLPERSONEL.Count().ToString();
            label10.Text = db.TBLGOREV.Count().ToString();
        }

        private void btnGorevEkle_Click(object sender, EventArgs e)
        {
            TBLPERSONEL tbl = new TBLPERSONEL();

            if (txtTC.Text != "" && txtAd.Text != "")
            {
                tbl.TCNO = txtTC.Text;
                tbl.ADSOYAD = txtAd.Text;
                tbl.TELEFON = txtTelefon.Text;
                tbl.MAIL = txtMail.Text;
                tbl.ADRES = txtAdres.Text;
                tbl.GOREV = byte.Parse(lookupGorev.EditValue.ToString());
                tbl.FOTOGRAF = pictureBox1.ImageLocation;

                db.TBLPERSONEL.Add(tbl);
                db.SaveChanges();
                MessageBox.Show("İşlem gerçekleştirildi.",
                "Bilgi", MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
                refresh();
            }
            else
            {
                MessageBox.Show("Kayıt yapılamadı, kontrol ediniz",
                "Hata", MessageBoxButtons.OK
                , MessageBoxIcon.Error);
            }
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = file.FileName;
            }
        }

        private void btnGorevGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var update = db.TBLPERSONEL.Find(id);
            update.TCNO = txtTC.Text;
            update.ADSOYAD = txtAd.Text;
            update.TELEFON = txtTelefon.Text;
            update.MAIL = txtMail.Text;
            update.ADRES = txtAdres.Text;
            update.FOTOGRAF = pictureBox1.ImageLocation;

            db.SaveChanges();
            MessageBox.Show("İşlem başarıyla gerçekleşti.");
            refresh();
        }

        private void btnGorevSil_Click(object sender, EventArgs e)
        {
            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Silme işleminden emin misiniz?", "Uyarı",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dg == DialogResult.Yes)
            {
                int ID = int.Parse(txtID.Text);
                var sil = db.TBLPERSONEL.Find(ID);
                db.TBLPERSONEL.Remove(sil);
                db.SaveChanges();
                MessageBox.Show("İşlem başarıyla gerçekleşti.", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Silme işlemi ipal edildi.");
            }

            refresh();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtTC.Text = gridView1.GetFocusedRowCellValue("TCNO").ToString();
            txtAd.Text = gridView1.GetFocusedRowCellValue("ADSOYAD").ToString();
            txtTelefon.Text = gridView1.GetFocusedRowCellValue("TELEFON").ToString();
            txtMail.Text = gridView1.GetFocusedRowCellValue("MAIL").ToString();
            txtAdres.Text = gridView1.GetFocusedRowCellValue("ADRES").ToString();
            lookupGorev.EditValue = gridView1.GetFocusedRowCellValue("GOREV").ToString();
            pictureBox1.ImageLocation = gridView1.GetFocusedRowCellValue("FOTOGRAF").ToString();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

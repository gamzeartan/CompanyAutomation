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
    public partial class FrmGorevIslemleri : Form
    {
        public FrmGorevIslemleri()
        {
            InitializeComponent();
        }
        DBFIRMAEntities db = new DBFIRMAEntities();

        void gorevRefresh()
        {
            var gorevler = from gorev in db.TBLGOREV
                          select new
                          {
                              gorev.ID,
                              gorev.GOREV,
                            
                          };

            gridControl1.DataSource = gorevler.ToList();

        }


        private void FrmGorevIslemleri_Load(object sender, EventArgs e)
        {
            gorevRefresh();
        }

        private void btnGorevEkle_Click(object sender, EventArgs e)
        {
            TBLGOREV tbl = new TBLGOREV();

            if(txtGorevAd.Text.Length <= 50 && txtGorevAd.Text != "")
            {
                tbl.GOREV = txtGorevAd.Text;
                db.TBLGOREV.Add(tbl);
                db.SaveChanges();
                MessageBox.Show("İşlem gerçekleştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gorevRefresh();
            }
            else
            {
                MessageBox.Show("Kayıt yapılamadı, kontrol ediniz", "Hata", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }



        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            txtGorevID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtGorevAd.Text = gridView1.GetFocusedRowCellValue("GOREV").ToString();
        }

        private void btnGorevSil_Click(object sender, EventArgs e)
        {
            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Silme işleminden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dg == DialogResult.Yes)
            {
                int ID = int.Parse(txtGorevID.Text);
                var sil = db.TBLGOREV.Find(ID);
                db.TBLGOREV.Remove(sil);
                db.SaveChanges();
                MessageBox.Show("İşlem başarıyla gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Silme işlemi ipal edildi.");
            }

            gorevRefresh();

        }

        private void btnGorevGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtGorevID.Text);
            var guncelle = db.TBLGOREV.Find(id);
            guncelle.GOREV = txtGorevAd.Text;

            db.SaveChanges();
            MessageBox.Show("İşlem başarıyla gerçekleşti.");
            gorevRefresh();
        }
    }
    }


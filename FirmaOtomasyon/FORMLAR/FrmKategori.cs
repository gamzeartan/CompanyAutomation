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
    public partial class FrmKategori : Form
    {
        public FrmKategori()
        {
            InitializeComponent();
        }


        DBFIRMAEntities db = new DBFIRMAEntities();
        void kategoriRefresh()
        {
            var urunler = from k in db.TBLKATEGORI
                          select new
                          {
                              k.ID,
                              k.KATEGORIAD,
                             
                          };

            gridControl1.DataSource = urunler.ToList();




        }
        private void FrmKategori_Load(object sender, EventArgs e)
        {
            kategoriRefresh();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            TBLKATEGORI tbl = new TBLKATEGORI();
            tbl.KATEGORIAD = txtKAD.Text;
            
            db.TBLKATEGORI.Add(tbl);
            db.SaveChanges();
            MessageBox.Show("İşlem başarıyla gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            kategoriRefresh();


        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtKID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtKAD.Text = gridView1.GetFocusedRowCellValue("KATEGORIAD").ToString();
           

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Silme işleminden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dg == DialogResult.Yes)
            {
                int ID = int.Parse(txtKID.Text);
                var sil = db.TBLKATEGORI.Find(ID);
                db.TBLKATEGORI.Remove(sil);
                db.SaveChanges();
                MessageBox.Show("İşlem başarıyla gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Silme işlemi ipal edildi.");
            }

            kategoriRefresh();

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtKID.Text);
            var guncelle = db.TBLKATEGORI.Find(id);
            guncelle.KATEGORIAD = txtKAD.Text;
           
            db.SaveChanges();
            MessageBox.Show("İşlem başarıyla gerçekleşti.");
            kategoriRefresh();
        }
    }
}

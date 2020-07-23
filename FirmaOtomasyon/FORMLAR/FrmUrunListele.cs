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
    public partial class FrmUrunListele : Form
    {
        public FrmUrunListele()
        {
            InitializeComponent();
        }



        DBFIRMAEntities db = new DBFIRMAEntities();
        private void FrmUrunListele_Load(object sender, EventArgs e)
        {
            gridRefresh();
            lookUpEdit1.Properties.DataSource = db.TBLKATEGORI.ToList();


        }

        //ürün listeleme fonk.
        void gridRefresh()
        {
            var urunler = from urun in db.TBLURUN
                          select new
                          {
                              urun.ID,
                              urun.AD,
                              urun.TBLKATEGORI.KATEGORIAD,
                              urun.MARKA,
                              urun.STOK,
                              urun.ALISFİYAT,
                              urun.SATISFIYAT,
                              urun.OZELLIK
                          };

            gridControl1.DataSource = urunler.ToList();

         


        }



        private void simpleButton1_Click(object sender, EventArgs e)
        {
            TBLURUN tbl = new TBLURUN();
            tbl.AD = txtAD.Text;
            tbl.ALISFİYAT = decimal.Parse(txtAlis.Text);
            tbl.MARKA = txtMarka.Text;
            tbl.OZELLIK = textBox7.Text;
            tbl.STOK = short.Parse(txtStok.Text);
            tbl.DURUM = false;
            tbl.SATISFIYAT = decimal.Parse(txtSatis.Text);
            tbl.KATEGORI = byte.Parse(lookUpEdit1.EditValue.ToString());
            db.TBLURUN.Add(tbl);
            db.SaveChanges();
            MessageBox.Show("İşlem başarıyla gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            gridRefresh();




        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            txtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtAD.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            txtMarka.Text = gridView1.GetFocusedRowCellValue("MARKA").ToString();
            txtAlis.Text = gridView1.GetFocusedRowCellValue("ALISFİYAT").ToString();
            txtSatis.Text = gridView1.GetFocusedRowCellValue("SATISFIYAT").ToString();
            txtStok.Text = gridView1.GetFocusedRowCellValue("STOK").ToString();
            textBox7.Text = gridView1.GetFocusedRowCellValue("OZELLIK").ToString();

           

        

           

           




        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Silme işleminden emin misiniz?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dg ==DialogResult.Yes)
            {
                int urunID = int.Parse(txtID.Text);
                var sil = db.TBLURUN.Find(urunID);
                db.TBLURUN.Remove(sil);
                db.SaveChanges();
                MessageBox.Show("İşlem başarıyla gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Silme işlemi ipal edildi.");
            }

            gridRefresh();




        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var guncelle = db.TBLURUN.Find(id);
            guncelle.AD = txtAD.Text;
            guncelle.STOK = short.Parse(txtStok.Text);
            guncelle.MARKA = txtMarka.Text;
            guncelle.ALISFİYAT = decimal.Parse(txtAlis.Text);
            guncelle.SATISFIYAT = decimal.Parse(txtSatis.Text);
            guncelle.OZELLIK = txtOzellik.Text;
            guncelle.KATEGORI = byte.Parse(lookUpEdit1.EditValue.ToString());
            db.SaveChanges();
            MessageBox.Show("İşlem başarıyla gerçekleşti.");
            gridRefresh();




        }
    }
}

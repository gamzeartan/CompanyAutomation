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
    public partial class FrmSatis : Form
    {
        public FrmSatis()
        {
            InitializeComponent();
        }

        DBFIRMAEntities db = new DBFIRMAEntities();
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            TBLURUNSATIS t = new TBLURUNSATIS();
            t.URUN = int.Parse(lookUpEdit1.EditValue.ToString());
            t.MUSTERI = int.Parse(lookUpEdit2.EditValue.ToString());
            t.PERSONEL = short.Parse(lookUpEdit3.EditValue.ToString());
            t.TARIH = DateTime.Parse(txtTarih.Text);
            t.ADET = short.Parse(txtAdet.Text);
            t.KDV = int.Parse(txtKDV.Text);
            t.FIYAT = decimal.Parse(txtFiyat.Text);
            t.SERINO = txtSeriNo.Text;
            db.TBLURUNSATIS.Add(t);
            db.SaveChanges();
            MessageBox.Show("Satış gerçekleştirildi.");
        }

        private void FrmSatis_Load(object sender, EventArgs e)
        {
            lookUpEdit1.Properties.DataSource = (from x in db.TBLURUN
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.AD


                                                 }).ToList();
            lookUpEdit2.Properties.DataSource = (from y in db.TBLFIRMA
                                                 select new
                                                 {
                                                     y.ID,
                                                     y.AD


                                                 }).ToList();
            lookUpEdit3.Properties.DataSource = (from z in db.TBLPERSONEL
                                                 select new
                                                 {
                                                     z.ID,
                                                     z.ADSOYAD


                                                 }).ToList();
            //label10.ForeColor = Color.Black;
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            int id = int.Parse(lookUpEdit1.EditValue.ToString());
            var fiyat = ((from x in db.TBLURUN
                          select new
                          {
                              x.ID,
                              x.SATISFIYAT

                          }).Where(x => x.ID == id)).FirstOrDefault();



            label10.Text = fiyat.ToString();
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}

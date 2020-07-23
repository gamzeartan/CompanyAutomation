using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils.Drawing;
using DevExpress.XtraBars.Ribbon.ViewInfo;

namespace FirmaOtomasyon
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            FORMLAR.FrmAnasayfa frm = new FORMLAR.FrmAnasayfa();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMLAR.FrmUrunIstatistik frm = new FORMLAR.FrmUrunIstatistik();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnUrunListele_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMLAR.FrmUrunListele frm = new FORMLAR.FrmUrunListele();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMLAR.FrmKategori frm = new FORMLAR.FrmKategori();
            frm.MdiParent = this;
            frm.Show();

        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMLAR.FrmFirmaIslemleri frm = new FORMLAR.FrmFirmaIslemleri();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMLAR.FrmFirmaIstatistik frm = new FORMLAR.FrmFirmaIstatistik();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMLAR.FrmGorevIslemleri frm = new FORMLAR.FrmGorevIslemleri();
            frm.MdiParent = this;
            frm.Show();
        }

       

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMLAR.FrmPersonelIslemleri frm = new FORMLAR.FrmPersonelIslemleri();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnHesapM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("excel");

        }

        private void barButtonItem24_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMLAR.FrmNotlar frm = new FORMLAR.FrmNotlar();
            frm.MdiParent = this;
            frm.Show();

        }

        private void barButtonItem28_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMLAR.FrmIletisim frm = new FORMLAR.FrmIletisim();
            frm.MdiParent = this;
            frm.Show();
        }

      

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMLAR.FrmIadeListe frm = new FORMLAR.FrmIadeListe();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem26_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMLAR.FrmSatis frm = new FORMLAR.FrmSatis();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem35_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMLAR.FrmSatisListesi frm = new FORMLAR.FrmSatisListesi();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMLAR.FrmIadeYap frm = new FORMLAR.FrmIadeYap();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMLAR.FrmIadeDurum frm = new FORMLAR.FrmIadeDurum();
            frm.MdiParent = this;
            frm.Show();
        }

      

        private void barButtonItem36_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMLAR.FrmFatura frm = new FORMLAR.FrmFatura();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMLAR._ frm = new FORMLAR._();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem32_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMLAR.FrmRaporlar frm = new FORMLAR.FrmRaporlar();
           // frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem37_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMLAR.FrmAnasayfa frm = new FORMLAR.FrmAnasayfa();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {


            FORMLAR.FrmYardim fr = new FORMLAR.FrmYardim();
            fr.Show();

            //MessageBox.Show("                 TİCARİ FİRMA OTOMASYONU" + Environment.NewLine + Environment.NewLine+ "Web Sitesi: www.ticarifirmaotomasyonuornek.com"
            //    + Environment.NewLine + Environment.NewLine+"Telefon: 0(262) 00 00 " + Environment.NewLine +Environment.NewLine+ "Açıklama: Uygulama ticari firmalar için geliştirilmiş bir otomasyon uygulamasıdır." +
            //    " Personel, ürün, stok, müşteri  ve satış işlemleri ile birlikte yardımcı araçlar ile birçok işlem gerçekleştirilmektedir.",
            //    "Bilgilendirme", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
    }
}

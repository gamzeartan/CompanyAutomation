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
    public partial class _ : Form
    {
        public _()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            TBLFATURADETAY t = new TBLFATURADETAY();
            t.URUN = txturun.Text;
            t.ADET = short.Parse(txtadet.Text);
            t.FIYAT = decimal.Parse(txtfiyat.Text);
            t.TUTAR = decimal.Parse(txttutar.Text);
            t.FATURADETAYID = int.Parse(txtfaturaid.Text);
            db.TBLFATURADETAY.Add(t);
            db.SaveChanges();
            MessageBox.Show("İşlem gerçekleştirildi.");

            listeler();




        }
        DBFIRMAEntities db = new DBFIRMAEntities();

        void listeler()
        {
            var degerler = from u in db.TBLFATURADETAY
                           select new
                           {
                               u.FATURADETAYID,
                               u.URUN,

                               u.ADET,
                               u.FIYAT,
                               u.TUTAR,
                               u.FATURAID

                           };

            gridControl1.DataSource = degerler.ToList();




        }



        private void __Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dBFIRMADataSet.TBLFATURABILGI' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBLFATURABILGITableAdapter.Fill(this.dBFIRMADataSet.TBLFATURABILGI);
            listeler();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);

            var degerler = (from u in db.TBLFATURADETAY
                            select new
                            {
                                u.FATURADETAYID,
                                u.URUN,
                                u.ADET,
                                u.FIYAT,
                                u.TUTAR,
                                u.FATURAID
                            }).Where(x => x.FATURAID == id);


            dataGridView1.ForeColor = Color.Black;
            dataGridView1.DataSource = degerler.ToList();

            var faturalar = (from y in db.TBLFATURABILGI
                             select new
                             {
                                 y.ID,
                                 y.TBLPERSONEL.ADSOYAD,
                                 y.SAAT,
                                 y.SERI,
                                 y.SIRA,
                                 y.TARIH,
                                 y.TBLFIRMA.AD
                             }).Where(y => y.ID == id);
            dataGridView2.ForeColor = Color.Black;
            dataGridView2.DataSource = faturalar.ToList();



        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }



        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            Random rnd = new Random();
            string harfler = "0123456789";
            string uret = "";
            for (int g = 0; g < 6; g++)
            {
                uret += harfler[rnd.Next(harfler.Length)];
            }
            SolidBrush firca = new SolidBrush(Color.Black);
            Font font = new Font("Times New Roman", 13);
            e.Graphics.DrawString("www.ornekwebsitesi.com", font, firca, 50, 5);
            font = new Font("Times New Roman", 12);
            Pen kalem = new Pen(Color.Black);

            e.Graphics.DrawString("Düzenlenme Tarihi: " + DateTime.Now.ToLongDateString() + " " +
                    "" + DateTime.Now.ToLongTimeString(), font, firca, 50, 60);
            e.Graphics.DrawString("Fatura No: " + uret.ToString() + "", font, firca, 630, 60);

            e.Graphics.DrawLine(kalem, 50, 85, 770, 85);
            e.Graphics.DrawLine(kalem, 50, 1000, 50, 85);

            e.Graphics.DrawLine(kalem, 50, 1000, 770, 1000);
            e.Graphics.DrawLine(kalem, 770, 1000, 770, 85);

            font = new Font("Arial", 10, FontStyle.Bold);
            e.Graphics.DrawString("Fatura Bilgileri", font, firca, 350, 94);
            e.Graphics.DrawLine(kalem, 50, 110, 770, 110);

            font = new Font("Arial", 14, FontStyle.Bold);
            e.Graphics.DrawString("Seri", font, firca, 90, 118);
            //e.Graphics.DrawString("Saat", font, firca, 155, 118);
            e.Graphics.DrawString("Sıra", font, firca, 180, 118);
            e.Graphics.DrawString("Personel", font, firca, 300, 118);
            e.Graphics.DrawString("Firma Adı", font, firca, 470, 118);
            //e.Graphics.DrawString("Tarih", font, firca, 580, 118);
            e.Graphics.DrawLine(kalem, 50, 150, 770, 150);


            ////////////////////////////////////////////////////////
            e.Graphics.DrawString("Ödenen: " + txtOdenen.Text + "  TL", font, firca, 60, 1025);
            e.Graphics.DrawString("Ödeme Şekli: " + textBox2.Text + "  TL", font, firca, 480, 1025);
            e.Graphics.DrawString("Genel Toplam: " + txtToplam.Text + "  TL", font, firca, 60, 1065);
            e.Graphics.DrawString("Fatura Detay ID: " + textBox1.Text, font, firca, 480, 1065);
            /////////////////////////////////////////////////////////
            int y = 160; font = new Font("Arial", 15);
    
            int a = 0;
            while (a <= dataGridView2.Rows.Count - 1)
            {
                e.Graphics.DrawString((a + 1) + ".", font, firca, 60, y);
                e.Graphics.DrawString(dataGridView2[3, a].Value.ToString(), font, firca, 90, y);
                e.Graphics.DrawString(dataGridView2[4, a].Value.ToString(), font, firca, 180, y);
                e.Graphics.DrawString(dataGridView2[1, a].Value.ToString(), font, firca, 300, y);
                e.Graphics.DrawString(dataGridView2[6, a].Value.ToString(), font, firca, 470, y);

                y += 25;

                a = a + 1;

            }
            y = 270;
            font = new Font("Arial", 14, FontStyle.Bold);
            e.Graphics.DrawLine(kalem, 50, 200, 770, 200);
            e.Graphics.DrawString("Ürün", font, firca, 90, 210);
            e.Graphics.DrawString("Adet", font, firca, 440, 210);
            e.Graphics.DrawString("Fiyat", font, firca, 500, 210);
            e.Graphics.DrawString("Tutar", font, firca, 620, 210);
            e.Graphics.DrawLine(kalem, 50, 240, 770, 240);

          
            int i = 0;
            while (i <= dataGridView1.Rows.Count - 1)
            {
                e.Graphics.DrawString((i + 1) + ".", font, firca, 60, y);
                e.Graphics.DrawString(dataGridView1[1, i].Value.ToString(), font, firca, 90, y);
                e.Graphics.DrawString(dataGridView1[2, i].Value.ToString(), font, firca, 440, y);
                e.Graphics.DrawString(dataGridView1[3, i].Value.ToString(), font, firca, 500, y);
                e.Graphics.DrawString(dataGridView1[4, i].Value.ToString(), font, firca, 620, y);
                y += 25;
                i = i + 1;

            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

        }
    }
}

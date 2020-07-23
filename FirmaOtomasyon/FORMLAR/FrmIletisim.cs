using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//mail için kütüphaneler
using System.Net;
using System.Net.Mail;

namespace FirmaOtomasyon.FORMLAR
{
    public partial class FrmIletisim : Form
    {
        public FrmIletisim()
        {
            InitializeComponent();
        }
        DBFIRMAEntities db = new DBFIRMAEntities();

        private void FrmIletisim_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TBLFIRMA
                                       select new
                                       {
                                           x.FIRMANO,
                                           x.AD,
                                           x.TELEFON } ).ToList();
            gridControl2.DataSource = (from x in db.TBLFIRMA
                                       select new
                                       {   x.AD,
                                           x.MAIL }).ToList();
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            txtAlici.Text = "";
            txtIcerik.Text = "";
            txtKonu.Text = "";
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            string alici = txtAlici.Text;
            var fromAddress = new MailAddress("projemail00@gmail.com", "Ticari Firma Otomasyonu");
            var toAddress = new MailAddress(alici, "Alıcı");
            const string fromPassword = "Projemail1.";
            string subject = txtKonu.Text;
            string body = txtIcerik.Text;

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
                Timeout = 20000
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
                MessageBox.Show("Mailiniz gönderildi.", "Bilgi");
            }
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class FrmIadeYap : Form
    {
        public FrmIadeYap()
        {
            InitializeComponent();
        }

        private void FrmIadeYap_Load(object sender, EventArgs e)
        {
            lookUpEdit1.Properties.DataSource = db.TBLFIRMA.ToList();
            lookUpEdit2.Properties.DataSource = db.TBLPERSONEL.ToList();

        }

        DBFIRMAEntities db = new DBFIRMAEntities();
        private void btniade_Click(object sender, EventArgs e)
        {
            TBLURUNISLEM t = new TBLURUNISLEM();
            t.FIRMA = int.Parse(lookUpEdit1.EditValue.ToString());
           t.PERSONEL = short.Parse(lookUpEdit2.EditValue.ToString());
            t.GELISTARIH = DateTime.Parse(txtGelisT.Text);
            t.ADET = int.Parse(txtAdet.Text);
            t.ACIKLAMA = txtAçıklama.Text;
            t.SERINO = txtserino.Text;
            db.TBLURUNISLEM.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün iadesi yapıldı.");
        }
    }
}

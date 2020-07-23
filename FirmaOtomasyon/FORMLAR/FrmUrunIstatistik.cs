using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FirmaOtomasyon.FORMLAR
{
    public partial class FrmUrunIstatistik : Form
    {
        public FrmUrunIstatistik()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        DBFIRMAEntities db = new DBFIRMAEntities();
        SqlConnection sqlBaglanti = new SqlConnection(@"Data Source=NIRVANA\MSSQLSERVER1;Initial Catalog=DBFIRMA;Integrated Security=True");
        private void FrmUrunIstatistik_Load(object sender, EventArgs e)
        {

            label2.Text = db.TBLURUN.Count().ToString();
            label5.Text = db.TBLKATEGORI.Count().ToString();
            label3.Text = db.TBLURUN.Sum(x => x.STOK).ToString();

            var g = (from k in db.TBLURUN
                     where k.STOK <= 5
                     select k.AD).FirstOrDefault();

            label9.Text = g.ToString();

            label15.Text = (from x in db.TBLURUN
                            select x.MARKA).Distinct().Count().ToString();

            label11.Text = (from x in db.TBLURUNSATIS

                            orderby x.ADET descending
                            select x.TBLURUN.AD ).FirstOrDefault();

            label13.Text = (from x in db.TBLURUNSATIS
                            orderby x.ADET ascending
                            select x.TBLURUN.AD).FirstOrDefault();

            sqlBaglanti.Open();
            SqlCommand komut = new SqlCommand("select MARKA, COUNT(*) FROM TBLURUN group by MARKA", sqlBaglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            }
            sqlBaglanti.Close();


            sqlBaglanti.Open();
            SqlCommand komut2 = new SqlCommand("select TBLKATEGORI.KATEGORIAD, COUNT(*) FROM TBLURUN " +
                "INNER JOIN TBLKATEGORI ON TBLKATEGORI.ID=TBLURUN.KATEGORI GROUP BY TBLKATEGORI.KATEGORIAD", sqlBaglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                chartControl2.Series["Series 1"].Points.AddPoint(Convert.ToString(dr2[0]), int.Parse(dr2[1].ToString()));
            }



            sqlBaglanti.Close();






        }
    }
}







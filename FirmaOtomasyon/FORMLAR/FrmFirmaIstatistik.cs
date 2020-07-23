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
    public partial class FrmFirmaIstatistik : Form
    {
        public FrmFirmaIstatistik()
        {
            InitializeComponent();
        }

        SqlConnection sqlBaglanti = new SqlConnection(@"Data Source=NIRVANA\MSSQLSERVER1;Initial Catalog=DBFIRMA;Integrated Security=True");


        DBFIRMAEntities db = new DBFIRMAEntities();
        private void FrmFirmaIstatistik_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = db.TBLFIRMA.OrderBy(x => x.IL).GroupBy(y => y.IL).
                Select(z => new
                {
                    İL = z.Key, ToplamSayı = z.Count()
                }).ToList();

            sqlBaglanti.Open();
            SqlCommand komut = new SqlCommand("select IL, COUNT(*) FROM TBLFIRMA group by IL",sqlBaglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            }
            sqlBaglanti.Close();
            label2.Text = db.TBLFIRMA.Count().ToString();
            label3.Text = (from x in db.TBLFIRMA
                           select new
                           {
                               x.IL }).Distinct().Count().ToString(); }

        private void chartControl1_Click(object sender, EventArgs e)
        {

        }
    }
}

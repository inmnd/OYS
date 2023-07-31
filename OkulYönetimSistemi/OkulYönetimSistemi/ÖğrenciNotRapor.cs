using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulYönetimSistemi
{
    public partial class ÖğrenciNotRapor : Form
    {
        int dersId, sinifId;

        public ÖğrenciNotRapor(string dI, string sI)
        {
            InitializeComponent();
            this.dersId = Convert.ToInt32(dI);
            this.sinifId = Convert.ToInt32(sI);
        }

        private void ÖğrenciNotRapor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'okulDataSet.Ogrenci' table. You can move, or remove it, as needed.
            this.ogrenciTableAdapter.Fill(this.okulDataSet.Ogrenci,sinifId);
            this.sinifTableAdapter.Fill(this.okulDataSet.Sinif,sinifId);
            this.dataTable1TableAdapter.Fill(this.okulDataSet.DataTable1, dersId ,sinifId);
            this.dersTableAdapter.Fill(this.okulDataSet.Ders, dersId);
            this.ogrenciNotTableAdapter1.Fill(this.okulDataSet1.OgrenciNot,dersId, sinifId);


            this.reportViewer1.RefreshReport();
        }
    }
}

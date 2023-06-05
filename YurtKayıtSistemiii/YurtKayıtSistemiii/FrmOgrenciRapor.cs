using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtKayıtSistemiii
{
    public partial class FrmOgrenciRapor : Form
    {
        public FrmOgrenciRapor()
        {
            InitializeComponent();
        }

        private void FrmOgrenciRapor_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'YurtkayıtDataSet22.Ogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.OgrenciTableAdapter.Fill(this.YurtkayıtDataSet22.Ogrenci);

            this.reportViewer1.RefreshReport();
        }
    }
}

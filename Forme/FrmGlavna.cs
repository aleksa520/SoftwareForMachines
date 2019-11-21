using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme
{
    public partial class FrmGlavna : Form
    {
        public FrmGlavna()
        {
            InitializeComponent();
            UrediFormu();
        }

        public void UrediFormu()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            lblKorisnik.Text = Kontroler.Kontroler.Instance.Korisnik.KorisnickoIme;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void grupa1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUnosMasine frmUnosMasine = new FrmUnosMasine();
            frmUnosMasine.ShowDialog();
        }
    }
}

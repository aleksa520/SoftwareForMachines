using Domen;
using Kontroler;
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
    public partial class FrmPrijava : Form
    {
        private const int MAX_BROJ_POKUSAJA = 3;
        public FrmPrijava()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        } 

        private void btnPrijaviSe_Click_1(object sender, EventArgs e)
        {
            int brojPokusaja = MAX_BROJ_POKUSAJA;
            string kor = txtKorisnickoIme.Text;
            string pass = txtPassword.Text;

            if (Kontroler.Kontroler.Instance.Prijava(kor, pass))
            {
                Korisnik k = new Korisnik()
                {
                    KorisnickoIme = kor,
                    Sifra = pass
                };

                Kontroler.Kontroler.Instance.Korisnik = k;
                FrmGlavna frmGlavna = new FrmGlavna();
                frmGlavna.ShowDialog();
            }
            else
            {
                brojPokusaja--;
                if (brojPokusaja == 0)
                {
                    Close();
                }
                MessageBox.Show($"Broj preostalih pokusaja: {brojPokusaja}");
                txtKorisnickoIme.Clear();
                txtPassword.Clear();
            }
        }
    }
}

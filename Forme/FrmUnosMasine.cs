using Domen;
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
    public partial class FrmUnosMasine : Form
    {
        BindingList<Alat> alatiIzBaze;
        BindingList<Alat> alatiNaFormi = new BindingList<Alat>();
        public FrmUnosMasine()
        {
            InitializeComponent();
            UrediFormu();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        public void UrediFormu()
        {
            cmbTipMasine.DataSource = Kontroler.Kontroler.Instance.VratiTipoveMasinaSortirano();
            cmbLokacija.DataSource = Kontroler.Kontroler.Instance.VratiSveLokacijeSortirano();
            alatiIzBaze = new BindingList<Alat>(Kontroler.Kontroler.Instance.VratiSveAlate());
            cmbAlati.DataSource = Kontroler.Kontroler.Instance.VratiSveAlate();
            dgvAlati.DataSource = alatiNaFormi;
            dgvAlati.Columns[0].Visible = false;
            dgvAlati.Columns[2].HeaderText = "Kolicina";
        }

        private void btnDodajAlat_Click(object sender, EventArgs e)
        {
            Alat a = (Alat)cmbAlati.SelectedItem;

            foreach (Alat alat in alatiNaFormi)
            {
                if (alat.AlatId == a.AlatId)
                {
                    foreach (Alat alatIzBaze in alatiIzBaze)
                    {
                        if (alatIzBaze.Equals(alat))
                        {
                            if (alatIzBaze.StanjeNaZalihama > 0)
                            {
                                alat.StanjeNaZalihama++;
                            }
                            else
                            {
                                MessageBox.Show($"{alatIzBaze.Naziv} je presusio na zalihama");
                                return;
                            }
                        }
                    }
                    foreach (Alat al in alatiIzBaze)
                    {
                        if (al.AlatId == alat.AlatId)
                        {
                            al.StanjeNaZalihama--;
                            break;
                        }
                    }
                    dgvAlati.Refresh();
                    return;
                }
            }

            foreach (Alat alatBaza in alatiIzBaze)
            {
                if (alatBaza.Equals(a))
                {
                    if (alatBaza.StanjeNaZalihama > 0)
                    {
                        alatiNaFormi.Add(a);
                        a.StanjeNaZalihama = 1;
                        foreach (Alat al in alatiIzBaze)
                        {
                            if (al.AlatId == a.AlatId)
                            {
                                al.StanjeNaZalihama--;
                                break;
                            }
                        }
                        dgvAlati.Refresh();
                    }
                    else
                    {
                        MessageBox.Show($"{alatBaza.Naziv} je presusio na zalihama");
                        return;
                    }
                }
            }
        }

        private void btnObrisiAlat_Click(object sender, EventArgs e)
        {
            if (dgvAlati.SelectedRows.Count > 0)
            {
                Alat a = (Alat)dgvAlati.SelectedRows[0].DataBoundItem;
                alatiNaFormi.Remove(a);
                foreach (Alat alat in alatiIzBaze)
                {
                    if (alat.Equals(a))
                    {
                        alat.StanjeNaZalihama = alat.StanjeNaZalihama + a.StanjeNaZalihama;
                        return;
                    }
                }
            }
        }

        private void btnSacuvajMasinu_Click(object sender, EventArgs e)
        {
            if (ProveraForme())
            {
                return;
            }

            Masina m = new Masina
            {
                Naziv = txtNaziv.Text,
                Proizvodjac = txtProizvodjac.Text,
                OcekivaniRadniVek = int.Parse(txtOcekivaniRadniVek.Text),
                GodinaProizvodnje = int.Parse(txtGodinaProizvodnje.Text),
                Korisnik = Kontroler.Kontroler.Instance.Korisnik,
                DatumPocetkaEksploatacije = dateTimePicker1.Value,
                TipMasine = (TipMasine)cmbTipMasine.SelectedItem,
                Alati = alatiNaFormi.ToList(),
                Lokacija = (Lokacija)cmbLokacija.SelectedItem
            };

            bool uspesno;

            uspesno = Kontroler.Kontroler.Instance.SacuvajMasinuSmanjiAlate(m, alatiNaFormi.ToList());
            if (uspesno)
            {
                MessageBox.Show($"Masina {m.Naziv} je sacuvana");
                txtGodinaProizvodnje.Clear();
                txtNaziv.Clear();
                txtOcekivaniRadniVek.Clear();
                txtProizvodjac.Clear();
                alatiNaFormi.Clear();
            }
            else
            {
                MessageBox.Show($"Masina {m.Naziv} nije sacuvana");
            }

        }

        public bool ProveraForme()
        {
            int godinaProiz;
            bool godinaProizGreska = false;
            string godineProizTekst = "";
            if (!int.TryParse(txtGodinaProizvodnje.Text, out godinaProiz) || godinaProiz < 1900 || godinaProiz > 2018)
            {
                godinaProizGreska = true;
                godineProizTekst = "Godina mora biti u intervalu od 1900 do 2018";
            }

            DateTime vreme = dateTimePicker1.Value;
            bool vremeGreska = false;
            string vremeTekst = "";
            if (vreme < DateTime.Now)
            {
                vremeGreska = true;
                vremeTekst = "Vreme mora biti u buducnosti";
            }

            string postojiLokacijaTekst = "";
            Lokacija l = (Lokacija)cmbLokacija.SelectedItem;
            bool postojiLokacija = Kontroler.Kontroler.Instance.PostojiLiMasinaNaLokaciji(l);
            if (postojiLokacija)
            {
                postojiLokacijaTekst = "Postoji masina na datoj lokaciji";
            }
            if (godinaProizGreska || vremeGreska || postojiLokacija)
            {
                MessageBox.Show(vremeTekst + "\n" + godineProizTekst + "\n" + postojiLokacijaTekst);
                return true;
            }

            return false;
        }
    }
}

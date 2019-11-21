using BrokerBazePodataka;
using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontroler
{
    public class Kontroler
    {
        private static Kontroler instance;
        Broker broker = new Broker();
        Memorija memorija = new Memorija();
        public Korisnik Korisnik { get; set; }

        public static Kontroler Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Kontroler();
                }
                return instance;
            }
            set
            {
            }
        }
        private Kontroler()
        {
        }

        public List<TipMasine> VratiTipoveMasinaSortirano()
        {
            return memorija.TipoviMasine;
        }

        public bool Prijava(string kor, string pass)
        {
            foreach (Korisnik k in memorija.Korisnici)
            {
                if (k.KorisnickoIme == kor && k.Sifra == pass)
                {
                    return true;
                }
            }
            return false;
        }

        public List<Lokacija> VratiSveLokacijeSortirano()
        {
            return broker.VratiSveLokacijeSortirano();
        }

        public IList<Alat> VratiSveAlate()
        {
            return broker.VratiSveAlate();
        }

        public bool PostojiLiMasinaNaLokaciji(Lokacija l)
        {
            return broker.PostojiLiMasinaNaLokaciji(l);
        }

        public bool SacuvajMasinuSmanjiAlate(Masina m, List<Alat> alatiNaFormi)
        {
            try
            {
                broker.OtvoriKonekciju();
                broker.PokreniTransakciju();
                broker.SacuvajMasinuSmanjiAlate(m, alatiNaFormi);
                broker.Commit();
                return true;
            }
            catch (Exception)
            {
                broker.Rollback();
                return false;
            }
            finally
            {
                broker.ZatvoriKonekciju();
            }
        }
    }
}

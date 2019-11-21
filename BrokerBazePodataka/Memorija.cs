using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokerBazePodataka
{
    public class Memorija
    {
        private List<Korisnik> korisnici;
        public List<Korisnik> Korisnici { get { return korisnici; } }

        private List<TipMasine> tipoviMasine;
        public List<TipMasine> TipoviMasine { get { return tipoviMasine; } }
        public Memorija()
        {
            korisnici = new List<Korisnik>()
            {
                new Korisnik
                {
                    KorisnickoIme = "a",
                    Sifra = "a"
                },
                new Korisnik
                {
                    KorisnickoIme = "b",
                    Sifra = "b"
                }
            };

            tipoviMasine = new List<TipMasine>()
            {
                new TipMasine
                {
                    Naziv = "trafo"
                },
                new TipMasine
                {
                    Naziv = "stator"
                },
                new TipMasine
                {
                    Naziv = "skrubler"
                },
                new TipMasine
                {
                    Naziv = "induktor"
                },
                new TipMasine
                {
                    Naziv = "bager"
                }
            };

            var sortirano = tipoviMasine.OrderBy(x => x.Naziv).ToList();
            tipoviMasine = sortirano;
        }
    }
}

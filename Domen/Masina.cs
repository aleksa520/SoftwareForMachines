using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Masina
    {
        public int MasinaId { get; set; }
        public string Naziv { get; set; }
        public string Proizvodjac { get; set; }
        public int OcekivaniRadniVek { get; set; }
        public int GodinaProizvodnje { get; set; }
        public Korisnik Korisnik { get; set; }
        public DateTime DatumPocetkaEksploatacije { get; set; }
        public TipMasine TipMasine { get; set; }
        public Lokacija Lokacija { get; set; }
        public List<Alat> Alati { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Alat
    {
        public int AlatId { get; set; }
        public string Naziv { get; set; }
        public int StanjeNaZalihama { get; set; }
        public override string ToString()
        {
            return Naziv;
        }
        public override bool Equals(object obj)
        {
            if (obj is Alat a)
            {
                return a.AlatId == AlatId;
            }
            return false;
        }
    }
}

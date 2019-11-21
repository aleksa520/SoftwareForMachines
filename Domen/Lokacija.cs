namespace Domen
{
    public class Lokacija
    {
        public int LokacijaId { get; set; }
        public string Naziv { get; set; }
        public override string ToString()
        {
            return Naziv;
        }
    }
}
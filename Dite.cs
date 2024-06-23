using System;

namespace SpecEdApp.Data
{
    public class Dite
    {
        public int Id { get; set; }
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public DateTime DatumNarozeni { get; set; }
        public string TypSpecialnichPotreb { get; set; }
        public string SpecifickeVzdelavaciPotreby { get; set; }
        public string ZdravotniInformace { get; set; }
        public string KontaktNaRodice { get; set; }

        public Dite(string jmeno, string prijmeni, DateTime datumNarozeni, string typSpecialnichPotreb,
                    string specifickeVzdelavaciPotreby, string zdravotniInformace, string kontaktNaRodice)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            DatumNarozeni = datumNarozeni;
            TypSpecialnichPotreb = typSpecialnichPotreb;
            SpecifickeVzdelavaciPotreby = specifickeVzdelavaciPotreby;
            ZdravotniInformace = zdravotniInformace;
            KontaktNaRodice = kontaktNaRodice;
        }
    }
}
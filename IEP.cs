using System.Collections.Generic;

namespace SpecEdApp.Data
{
    public class IEP
    {
        public Dite Dite { get; set; }
        public List<string> Cile { get; set; }
        public List<string> Pokrok { get; set; }

        public IEP(Dite dite)
        {
            Dite = dite;
            Cile = new List<string>();
            Pokrok = new List<string>();
        }

        public void PridatCil(string cil)
        {
            Cile.Add(cil);
        }

        public void ZaznamenatPokrok(string popisPokroku)
        {
            Pokrok.Add(popisPokroku);
        }
    }
}
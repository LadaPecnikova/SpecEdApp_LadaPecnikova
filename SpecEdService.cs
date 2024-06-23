using System.Collections.Generic;

namespace SpecEdApp.Data
{
    public class SpecEdService
    {
        private List<Dite> _deti = new List<Dite>();
        private List<IEP> _ieps = new List<IEP>();

        public IEnumerable<Dite> GetDeti() => _deti;
        public IEnumerable<IEP> GetIeps() => _ieps;

        public Dite? VybraneDite;

        public void AddDite(Dite dite)
        {
            _deti.Add(dite);
        }

        public int GetNextId() => _deti.Count;

        public void AddIep(IEP iep)
        {
            _ieps.Add(iep);
        }

        public void UpravDite(Dite newDite)
        {
            Dite? stareDite = _deti.Find(dite => dite.Id == newDite.Id);

            if (stareDite != null)
            {
                _deti.Remove(stareDite);
            }

            _deti.Add(newDite);
        }

        public void SmazDite(Dite dite)
        {
            _deti.Remove(dite);
        }

        public void VyberDite(Dite dite)
        {
            VybraneDite = dite;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osobaUcenik
{
    class Ucenik:Osoba
    {
        private string odeljenje, smer, profil;
        public string Odeljenje
        {
            get { return odeljenje; }
            set { odeljenje = value; }
        }
        public string Smer
        {
            get { return smer; }
            set { smer = value; }
        }
        public string Profil  
        {
            get { return profil; }
            set { profil = value; }
        }
        public Ucenik():base()
        {

        }
        public Ucenik(string ime,string prezime,string roditelj,string odeljenje, string smer,string profil):base (ime,prezime,roditelj)
        {
            this.odeljenje = odeljenje;
            this.smer = smer;
            this.profil = profil;
        }
        public override string Podaci()
        {
            return (base.Podaci() + "\nUpisano odeljenje:" + this.odeljenje + "\nSmera:" + this.smer + "\nObrazovni profil: " + this.profil);

        }
    }
}

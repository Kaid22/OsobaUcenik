using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osobaUcenik
{
    class Osoba
    {
        protected string roditelj, ime, prezime;
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }
        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }
        public string Roditelj
        {
            get { return roditelj; }
            set { roditelj = value; }
        }
        public Osoba()
        {

        }
        public Osoba(string ime,string prezime,string roditelj)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.roditelj = roditelj;
        }
        public virtual string Podaci()
        {
            return "Ime je: " + this.ime + "\nPrezime je: " + this.prezime + "\nIme roditelja je: " + this.roditelj;
        }
    }
}

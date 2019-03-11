using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca_11._3._2019
{
    class Ucenik
    {
        
	
	private string ime = "";
        private string prezime = "";
        private long oib = 0;
        private int telefon = 0;
        private int racun = 0;

        public string Ime
        { get => ime; }
        public string Prezime
        { get => prezime; }
        public long Oib
        { set => oib = value; }
        public int Racun
        { get => racun; set => racun = value; }


        public override string ToString()
        {
            return "Pozdrav, " + ime + " " + prezime + " stanje racuna: " + racun;
        }


        public Ucenik() { }

        public Ucenik(string ime, string prezime)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.Racun = 5000;
        }
        public Ucenik(string ime, string prezime, long oib)
        : this(ime, prezime)
        {
            this.Oib = oib;
            this.Racun = 4000;
        }
        public Ucenik(string ime, string prezime, long oib, int racun)
        : this(ime, prezime, oib)
        {
            this.Racun = racun;
        }
    }
}
    


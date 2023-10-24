using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horazad
{
    public class Hora
    {
        private string name;
        private int godini;
        private double zaplata;
        private string adres;
        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length < 3)
                    throw new ArgumentOutOfRangeException("value");
                name = value;
            }
        }
        public int Age
        {
            get { return godini; }
            set
            {
                if(value<18)
                {
                    throw new ArgumentException("value");
                }
                godini = value;
            }
        }
        public double Zaplata
        {
            get { return zaplata; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("value");
                zaplata = value;
            }
        }
        public string Adres
        {
            get { return adres; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("value");
            }
        }
        public Hora()
        {
            Name = "Ivan";
            Age = 20;
            Zaplata = 1000;
            Adres = "Karlovo";
        }
        public Hora(string name,int godini,double zaplata,string adres)
        {
            Name = name;
            Age = godini;
            Zaplata = zaplata;
            Adres = adres;
        }
    }
}

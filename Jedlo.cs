using System;
using System.ComponentModel;

namespace SpravaPotravin
{
    public class Jedlo
    {
        [DisplayName("Jedlo")]
        public string Nazov { get; set; }

        private double mnozstvo;

        [DisplayName("Množstvo")]
        public double Mnozstvo
        {
            get
            {
                return mnozstvo;
            }

            set
            {
                mnozstvo = value <= 0 ? 1 : value;
            }
        }
        public Jednotky Jednotka { get; set; }
        public Miesta Miesto { get; set; }

        [DisplayName("Expirácia")]
        public DateTime Expiracia { get; set; }

        public readonly TimeSpan KontrolnyTimeSpan = new TimeSpan(3, 0, 0, 0);

        public static bool BolaVykonanaZmena;
        public Jedlo(string nazov = "", double mnozstvo = 0, Jednotky jednotka = default, Miesta miesto = default, DateTime expiracia = default)
        {
            Nazov = nazov;
            Mnozstvo = mnozstvo;
            Jednotka = jednotka;
            Miesto = miesto;
            Expiracia = expiracia;
        }     
        public Jedlo() 
        {

        }
        public static double UpravMnozstvo(double noveMnozstvo)
        {
            Jedlo jedlo = new Jedlo();
            BolaVykonanaZmena = true;
            return jedlo.Mnozstvo = noveMnozstvo;
        }
        public static DateTime UpravExpiraciu(DateTime novaExpiracia)
        {
            Jedlo jedlo = new Jedlo();
            BolaVykonanaZmena = true;
            return jedlo.Expiracia = novaExpiracia;
        }
        public static bool JeMnozstvoCislo(string zadaneMnozstvo)
        {
            return double.TryParse(zadaneMnozstvo, out double _);
        }
        public bool JeExpiraciaKriticka(DateTime zadanaExpiracia)
        {
            TimeSpan DniDoKoncaExpiracie = zadanaExpiracia - DateTime.Now;
            return DniDoKoncaExpiracie <= KontrolnyTimeSpan;
        }
    }
}

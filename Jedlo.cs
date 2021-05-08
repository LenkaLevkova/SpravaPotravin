﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using KGySoft.CoreLibraries;
using KGySoft.ComponentModel;

namespace SpravaPotravin
{
    public enum Miesta
    {
        Chladnička,
        Mraznička,
        Špajza
    }

    public enum Jednotky
    {
        ks,
        g,
        ml
    }
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

        public static double VysledneMnozstvo;

        public static TimeSpan DniDoKoncaExpiracie;

        public readonly TimeSpan KontrolnyTimeSpan = new TimeSpan(3, 0, 0, 0);

        public bool BolaVykonanaZmena;
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
        public double UpravMnozstvo(double noveMnozstvo)
        {
            BolaVykonanaZmena = true;
            return Mnozstvo = noveMnozstvo;
        }
        public DateTime UpravExpiraciu(DateTime novaExpiracia)
        {
            BolaVykonanaZmena = true;
            return Expiracia = novaExpiracia;
        }

        public bool JeMnozstvoCislo(string zadaneMnozstvo)
        {
            return double.TryParse(zadaneMnozstvo, out VysledneMnozstvo);
        }
        public bool JeExpiraciaKriticka(DateTime zadanaExpiracia)
        {
            DniDoKoncaExpiracie = zadanaExpiracia - DateTime.Now;

            if (DniDoKoncaExpiracie <= KontrolnyTimeSpan)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}

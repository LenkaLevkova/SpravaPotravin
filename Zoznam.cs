using System;
using KGySoft.ComponentModel;


namespace SpravaPotravin
{
    class Zoznam
    {
        public readonly int sloupecMnozstvo = 1;

        public readonly int sloupecExpiracia = 4;
        public bool BolaVykonanaZmena { get; set; }

        public SortableBindingList<Jedlo> Potraviny { get; set; }
 
        public void PridajJedlo(Jedlo zadaneJedlo)
        {
            Potraviny.Add(zadaneJedlo);
            BolaVykonanaZmena = true;
        }
        public void ZmazJedlo(Jedlo jedloKZmazaniu)
        {
            Potraviny.Remove(jedloKZmazaniu);
            BolaVykonanaZmena = true;
        }
        public bool JeVybranyRiadok(int index)
        {
            return index != 0;
        }
    }
}

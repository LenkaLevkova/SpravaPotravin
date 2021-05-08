using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using KGySoft.CoreLibraries;
using KGySoft.ComponentModel;
using Newtonsoft.Json;
using System.IO;
using System.Data.EntityClient;
using System.Data.Objects.DataClasses;


namespace SpravaPotravin
{
    class Zoznam
    {
        public readonly int sloupecMnozstvo = 1;

        public readonly int sloupecExpiracia = 4;

        public bool BolaVykonanaZmena;

        public SortableBindingList<Jedlo> Potraviny;
 
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
            if(index != 0)
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

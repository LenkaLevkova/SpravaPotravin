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

namespace SpravaPotravin
{
    static class Repositar
    {
        static string Adresar
        {
            get
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            }
        }
        public static string Cesta
        {
            get
            {
                return Path.Combine(Adresar, "ulozeneData.json");
            }
        }

        public static string Json { get; set; }

        public static void UlozData(SortableBindingList<Jedlo> zoznam)
        {
            string serializovanySubor = JsonConvert.SerializeObject(zoznam);
            File.WriteAllText(Cesta, serializovanySubor);
        }
        public static string NacitajData()
        {
            return Json = File.ReadAllText(Repositar.Cesta);
        }
    }
}

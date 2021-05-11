using System;
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

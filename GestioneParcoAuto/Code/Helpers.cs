using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneParcoAuto.Code
{
    public static class Helpers
    {
        public const string JsonPath = @"D:\Lavoro\Formazione\ESERCIZI\GestioneParcoAutoAziendale\GestioneParcoAuto\GestioneParcoAuto\FileJSON";
        public static BindingList<AutoAziendale> GetParcoAutoFromJson()
        {
            var path = Path.Combine(JsonPath, "macchine.json");
            var list = new BindingList<AutoAziendale>();
            using (var stream = new StreamReader(path))
            {
                while (true)
                {
                    var line = stream.ReadLine();
                    if (line == null) break;
                    if (line == string.Empty) continue;
                    list.Add(JsonConvert.DeserializeObject<AutoAziendale>(line));
                }
                return list;
            }
        }
        public static List<Dipendente> GetDipendentiFromJson()
        {
            var path = Path.Combine(JsonPath, "dipendenti.json");
            var list = new List<Dipendente>();
            using (var stream = new StreamReader(path))
            {
                while (true)
                {
                    var line = stream.ReadLine();
                    if (line == null) break;
                    if (line == string.Empty) continue;
                    list.Add(JsonConvert.DeserializeObject<Dipendente>(line));
                }
                return list;
            }
        }
        public static void SaveParcoAutoInJson(BindingList<AutoAziendale> parcoAuto)
        {
            var path = Path.Combine(JsonPath, "macchine.json");
            using (var streamWriter = new StreamWriter(path, false))
            {
                foreach (var auto in parcoAuto)
                {
                    streamWriter.WriteLine(JsonConvert.SerializeObject(auto));
                }          
            }
        }
    }
}

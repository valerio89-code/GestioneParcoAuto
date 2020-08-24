using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneParcoAuto.Code
{
    public class AutoAziendale
    {
        public string Marca { get; set; }
        public string Modello { get; set; }
        public string Targa { get; set; }
        public string Cilindrata { get; set; }
        public DateTime ScadenzaAssicurazione { get; set; }
        public string Disponibile
        {
            get
            {
                return this.Dipendente != null ? "Occupata" : "Disponibile";
            }
        }
        public bool IsDisponibile()
        {
            return Disponibile == "Disponibile";
        }
        public Dipendente Dipendente { get; set; }
        public override string ToString()
        {
            return $"{Targa} - {Marca} {Modello}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneParcoAuto.Code
{
    public class Dipendente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Matricola { get; set; }
        public override string ToString()
        {
            return $"{Cognome} {Nome} - {Matricola}";
        }

    }
}

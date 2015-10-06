using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployesLibrary
{            
    public class Cadre : Personnel
    {
        private static double TauxChargeCadre = 0.25;

        public Cadre(int id, string nom, string prenom): base(id, nom, prenom) { }
        public Cadre(int id, string nom, string prenom, double salaireBrut): base(id, nom, prenom, salaireBrut) { }
        public override double TauxCharges { get { return TauxChargeCadre; } }
    }
}

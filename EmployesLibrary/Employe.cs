using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployesLibrary
{
    public class Employe : Personnel
    {
        private double TauxChargeEmploye = 0.2;
        public Employe(int id, string nom, string prenom): base(id, nom, prenom) { }
        public Employe(int id, string nom, string prenom, double salaireBrut): base(id, nom, prenom, salaireBrut) { }
        public override double TauxCharges { get { return TauxChargeEmploye; } }
    }
}

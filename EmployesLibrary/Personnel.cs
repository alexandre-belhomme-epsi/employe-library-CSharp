using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployesLibrary
{
    public abstract class Personnel
    {
        public int Id { get; private set; }
        public string Nom { get; private set; }
        public string Prenom { get; private set; }
        public DateTime DateNaissance { get; private set; }
        public double SalaireBrut { get; set; }
        public double Primes
        {
            get
            {
                return 0;
            }
        }
        public abstract double TauxCharges { get; }
        public double SalaireNet
        {
            get
            {
                return (SalaireBrut + Primes) * (1 - TauxCharges);
            }
        }
        public Personnel(int id, string nom, string prenom): this(id, nom, prenom, 1500){}
        public Personnel(int id, string nom, string prenom, double salaireBrut)
        {         
            Id = id;
            Nom = nom;
            Prenom = prenom;
            SalaireBrut = salaireBrut;
        }


    }
}

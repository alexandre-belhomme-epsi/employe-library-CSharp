using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployesLibrary;

namespace EmployesLibrary
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Personnel> liste = new List<Personnel>();
            liste.Add(new Employe(1, "Dupont", "Henry", 2000));
            liste.Add(new Cadre(2, "Durant", "Marcel", 2000));
            foreach (Personnel personne in liste)
            {
                Console.WriteLine("Type = {0}, Nom = {1}, SalaireBrut = {2}, Taux = {3}, SalaireNet = {4}, TauxCharges = {5}\n",
                    personne.GetType(), personne.Nom, personne.SalaireBrut, personne.TauxCharges, personne.SalaireNet, personne.TauxCharges);
            }
        }
    }   
}
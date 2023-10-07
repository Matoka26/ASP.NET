using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tema01
{
    internal class Student
    {
        public string nume { get; set; }
        public string prenume { get; set; }
        public int? codStudent { get; set; }
        public char initialaTata { get; set; }
        public List<Materie>? materii { get; set; }

        public Student()
        {
            nume = "necunoscut";
            prenume = "necunoscut";
            initialaTata = '?';
            codStudent = null;
            materii = new List<Materie>();
        }

        public void afisareNume()
        {
            Console.WriteLine(codStudent + ": " + nume + " " + initialaTata + " " + prenume);
        }
        public void afisareMaterie()
        {
            if (materii.Count != 0)
            {
                Console.Write("Materii:");
                foreach (Materie mat in materii)
                {
                    Console.Write(mat.numeMaterie + " ");
                }
            }
            else { Console.WriteLine("Nu e inscris la nimic"); }
            Console.Write("\n\n");
        }
    } 
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooRecap2
{
    abstract class Animal
    {
        public string Nom { get; set; }
        public int Age { get; set; }

        public Animal(string nom, int age)
        {
            Nom = nom;
            Age = age;

        }

        public abstract string Crier();
        public abstract string Manger();


        public virtual string CrierV()
        {
            return Nom + " ";
        }

    }
}

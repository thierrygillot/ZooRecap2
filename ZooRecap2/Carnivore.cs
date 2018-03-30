using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooRecap2
{
    abstract class Carnivore :Animal
    {

        public Carnivore(string nom,int age)
            :base(nom,age)
        {
                
        }

        public override string Manger()
        {
            return "mange de la viande ";
        }

       // public override abstract string Crier();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooRecap2
{
    abstract class Herbivore :Animal
    {
        public Herbivore(string nom,int age)
            :base(nom,age)
        {

        }

        public override string Manger()
        {
            return "mange des végétaux";
        }

        //public override abstract string Crier();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooRecap2
{
    class Lion : Carnivore
    {
        public Lion(string nom, int age)
            :base(nom,age)
        {

        }

        public override string Crier()
        {
            return "Rugir";


        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Nom: ");
            sb.Append(Nom);
            sb.Append(" Age: ");
            sb.Append(Age);
            sb.Append(" Type d'alimentation: ");
            sb.Append(Manger());
            sb.Append(" Cri: ");
            sb.Append(Crier());

            return sb.ToString();

        }
    }
}

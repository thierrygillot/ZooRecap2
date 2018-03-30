using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooRecap2
{
    class Cheval : Herbivore
    {
        public Cheval(string nom,int age)
            :base(nom,age)
        {

        }

        public override string Crier()
        {
            return "Henir";

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

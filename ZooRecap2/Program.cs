using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooRecap2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Polymorphisme implicite
            Animal vache1 = new Vache("Juliette",20);//casting implicite
            //Polymorphisme explicite
            Vache v = (Vache)vache1;//casting explicite


            Loup loup1 = new Loup("Kyle",12);

            Console.WriteLine(vache1.ToString());
            Console.WriteLine(loup1.ToString());


            //utilisation de liste
            Lion lion1 = new Lion("Roger",12);
            Cheval cheval1 = new Cheval("Herbie", 5);
            List<Animal> animaux = new List<Animal>();
            animaux.Add(lion1);
            animaux.Add(vache1);
            animaux.Add(loup1);
            animaux.Add(cheval1);

            foreach (Animal item in animaux)
            {

                //prend les carnivores et ses enfants
                if (item is Carnivore)
                {
                    Carnivore c = (Carnivore)item;
                    Console.WriteLine("Carnivore");
                      
                }

                //Si c'est égal au type herbivore et strictement herbivore - pas d'enfants
                if (item.GetType() ==typeof(Herbivore))
                {
                    Herbivore h = (Herbivore)item;
                    Console.WriteLine("Carnivore");

                }
            }



            Console.Read();


        }
    }
}

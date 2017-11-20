using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public struct Person
    {
        public string Name { get; set; }

        public delegate void IsPregant(bool twins);

        public event IsPregant Pregant;

        public void DrunkBeer( int no )
        {
            if( no > 3 )
            {
                if(Pregant != null )
                {
                    Pregant((no > 5));
                }
            }
        }

        public void AlertPregant( bool twins )
        {
            Console.WriteLine("Ohh No is pregant!!!!" + twins);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            Person mother = new Person() { Name = "Gerda" };
            Person daugther = new Person() { Name = "Lotte" };

            daugther.Pregant += mother.AlertPregant;

            daugther.DrunkBeer(4);

            daugther.DrunkBeer(7);

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication22
{
    class Car
    {
        internal string owner;
        internal  string Owner
        {
            get { return owner; }
            set { owner = value; }
        }

        internal Car(string owner)
        {
            Owner = owner;
        }
        internal void ShowDetails()
        {
            Console.WriteLine("First owner: {0}", owner);
        }

        internal void SellCar(string newOwner)
        {
         
            if (newOwner != owner)
            {
                Console.WriteLine("New owner is: {0}", newOwner);
            }
        }
          
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication22
{
    class Program
    {
        static void Main(string[] args)
        {
            Car firstCar = new Car("AUDI fabrika");
            firstCar.ShowDetails();
           
            firstCar.SellCar("Ana Pavlovic");
       
           
            Console.ReadLine();


        }
    }
}

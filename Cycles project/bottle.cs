using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cycles_project
{
    public class Bottle
    {
        public int Volume {  get; set; }
        public string Material { get; set; }
        public string FormFactor { get; set; }

        public void Fall()
        {
            Console.WriteLine("Bottle fall down");
        }

        public void Decomposed() 
        {
            Console.WriteLine("bottle decomposed");
        }

    }
    public class Cup
    {
        int Volume { get; set; }
        string Material { get; set; }
        string Color { get; set; }

        void Break()
        {
            Console.WriteLine("Cup has brokken");
        }

        void FillUp()
        {
            Console.WriteLine("Fullfilled the cup");
        }


    }

    public class Car
    {
        public Car(int numberOfDoors)
        {
            NumberOfDoors = numberOfDoors;
        }




        public string CarClass;
        public int NumberOfDoors { get; set; }
        public bool IsCabriolet { get; set; }

        public void StartEngine()
        {
            Console.WriteLine("Vroom Vroom");
        }

        public void StopEngine()
        {
            Console.WriteLine("Engine turned off");
        }
        public void Drive()
        {
            Console.WriteLine("Car is driving");
        }


    }
}

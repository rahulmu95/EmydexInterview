using System;
using FarmSystem.Test1.Abstracts;

namespace FarmSystem.Test1
{
    public class Horse :FarmAnimal
    {
        private string _id;
        private int _noOfLegs;

        public string Id
        {
            get { return _id; }
            set
            {
                _id = value;
            }
        }


        public int NoOfLegs
        {
            get
            {
                return _noOfLegs;
            }
            set
            {
                _noOfLegs = base.NoOfLegs;
            }
        }
        

        public override void Talk()
        {
            Console.WriteLine("Horse says neigh!");
        }

        public override void Run()
        {
            Console.WriteLine("Horse is running");
        }
        
    }
}
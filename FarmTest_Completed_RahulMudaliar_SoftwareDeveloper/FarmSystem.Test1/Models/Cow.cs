using System;
using FarmSystem.Test1.Abstracts;
using FarmSystem.Test2;

namespace FarmSystem.Test1
{
    //Multple inheritance made possible because one is a base class and the other one is an interface
    public class Cow : FarmAnimal, IMilkableAnimal
    {
        private string _id;
        private int _noOfLegs = 4;


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
            Console.WriteLine("Cow says Moo!");
        }

        public override void Run()
        {
            Console.WriteLine("Cow is running");
        }

        public void Walk()
        {
            Console.WriteLine("Cow is walking");
        }

        public void ProduceMilk()
        {
            Console.WriteLine("Cow produced milk");
        }

      

    }
}
using System;
using FarmSystem.Test1.Interfaces;

namespace FarmSystem.Test1.Abstracts
{
    //Creating an abstract class here so that value of property NoOfLegs can be set across all concrete animal classes. If not for this - the interface would suffice
    public abstract class FarmAnimal : IAnimal
    {
        public string Id { get; set; }
        public int NoOfLegs { get; protected set; }
        //All concrete animals have number of legs as 4. Therefore, setting this value in the base class
        public FarmAnimal()
        {
            NoOfLegs = 4;
        }
        //These methods can be overridden to provide cutom implementation in a derived class
        public abstract void Talk();
        public abstract void Run();
    }
}


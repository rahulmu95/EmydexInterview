using System;
namespace FarmSystem.Test1.Interfaces
{
    public interface IAnimal
    {
       // All concrete animal classes have these propertie and methods. Therefore, they are placed in an interface. Provides a contract for shared animal properties and methods
        string Id { get; set; }
        int NoOfLegs { get; }
        void Talk();
        void Run();
    }
}


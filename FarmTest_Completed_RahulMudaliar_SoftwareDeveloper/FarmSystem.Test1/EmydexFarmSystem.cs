using System;
using System.Collections.Generic;
using FarmSystem.Test1.Abstracts;
using FarmSystem.Test2;

namespace FarmSystem.Test1
{
    public class EmydexFarmSystem
    {
        public event EventHandler FarmEmpty;

        public void RaiseEvent() {
            FarmEmpty.Invoke(this, EventArgs.Empty);
        }
        //TEST 1
        public void Enter(Queue<FarmAnimal> queueOfAnimals)
        {
            //TODO Modify the code so that we can display the type of animal (cow, sheep etc) 
            //Hold all the animals so it is available for future activities
            foreach(FarmAnimal animal in queueOfAnimals) {
                string AnimalName = animal.GetType().Name;
                Console.WriteLine($"{AnimalName} has entered the Emydex farm");
            }
        }
     
        //TEST 2
        public void MakeNoise(Queue<FarmAnimal> queueOfAnimals)
        {
            //Test 2 : Modify this method to make the animals talk
            foreach (FarmAnimal animal in queueOfAnimals)
            {
                animal.Talk();
            }
        }

        //TEST 3
        public void MilkAnimals(Queue<FarmAnimal> queueOfAnimals)
        {
            Type MilkableInterfaceType = typeof(IMilkableAnimal);

            foreach (FarmAnimal animal in queueOfAnimals)
            {
                Type AnimalType = animal.GetType();
                //check if the animal concrete object is implementing the IMilkable interface by checking type
                if (MilkableInterfaceType.IsAssignableFrom(AnimalType))
                {
                    //Casting object of type base abstract class to derived class to be able to class derived class method
                    Cow cow = (Cow)animal;
                    cow.ProduceMilk();
                }
               
            }
        }

        //TEST 4
        public void ReleaseAllAnimals(Queue<FarmAnimal> queueOfAnimals)
        {

            while (queueOfAnimals.Count > 0) {
                FarmAnimal animal = queueOfAnimals.Dequeue();
                string AnimalName = animal.GetType().Name;
                Console.WriteLine($"{AnimalName} has left the farm");
            }
            if(queueOfAnimals.Count == 0) {
                RaiseEvent();
            }
        }
    }
}
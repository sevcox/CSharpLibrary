using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _08_Interfaces
{

    public interface IFruit
    {
        string Name { get; } // Property with only Get
        bool Peeled { get; set; } //Property with a Get and Set
        string Peel(); //Method with only a return type ad no parameters
    }

    public class Banana : IFruit
    {
        public string Name
        {
            get { return "Banana"; }

        }
        public bool Peeled { get; set; }
        public string Peel()
        {
            Peeled = true;
            return "You peel the banana.";
        }
    }

    public class Orange : IFruit
    {
        public string Name
        {
            get
            {
                return "Orange";
            }
        }

        public bool Peeled { get; set; }

        public string Peel()
        {
            Peeled = true;
            return "You peel the orange.";
        }
        public string Squeeze()
        {
            return "You squeeze the orange and juice comes out";
        }

    }

    public class Grape : IFruit
    {
        public string Name
        {
            get { return "Grape"; }
        }
        public bool Peeled { get; set; }
        public string Peel()
        {
            return "Who peels grapes?";
        }
    }
    [TestClass]
    public class Introduction
    {

        [TestMethod]
        public void CallingInterfaceMethods()
        {
            // New up an instance of an IFruit
            IFruit fruit = new Banana();  //we are calling Banana BUT will only have the properties of IFruit, can't just call on interfaces like other classes. In this example it will take on the name of the banana put ONLY have access to the IFruit properties in Banana.
            List < IFruit > = new List<IFruit>();

            string output = fruit.Peel();
            Console.WriteLine(output);
            Console.WriteLine("The banana is peeled: " + fruit.Peeled);
        }
        [TestMethod]
        public void InterfacesInCollections()
        {
            var orange = new Orange(); //could put Orange in place of var but did that so this is dry code
            var fruitSalad = new List<IFruit>();
            fruitSalad.Add(orange);
            fruitSalad.Add(new Banana());
            fruitSalad.Add(new Grape());

            foreach (var fruit in fruitSalad)
            {
                Console.WriteLine(fruit.Name);
                Console.WriteLine(fruit.Peel());
            }
            Console.WriteLine(orange.Squeeze()); //can't go inside of foreach loop because fruit in the foreach loop is of type IFruit
        }

        private string GetFruitName(IFruit fruit) //helper method for below testmethod
        {
            return $"This fruit is called {fruit.Name}";
        }
        [TestMethod]
        public void InterfacesinMethods()
        {
            var grape = new Grape();
            var output = GetFruitName(grape);

            Console.WriteLine(output);

        }

    }
}
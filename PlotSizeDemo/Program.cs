using System;
using System.Collections.Generic;

namespace PlotSizeDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            //Test Set 1: Generic Lists
            //Sample of Generic list being used to store values in a list and disply them in a console
            List<string> Planets = new List<string>() { "Mars", "Jupiter", "Pluto", "Earth", "Venus", "Mercury" };
            Console.WriteLine("List of planets based popular vote:");
            
            // using foreach LINQ method
            //Planets.ForEach(num => Console.WriteLine(num + ", "));//prints 1, 2, 5, 7, 8, 10,

            // using for loop
            for (int i = 0; i < Planets.Count; i++)
                Console.WriteLine(Planets[i]);


            #endregion

            #region
            //Test set 2: Methods in generics and type testing 
            //Implemented to test the instantiation of the type of a generic within the main class
            //post setting the type within the Datastore class
            DataStore<string> JuiceFlavors = new DataStore<string>();
            JuiceFlavors.AddOrUpdate(0, "Orange");
            JuiceFlavors.AddOrUpdate(1, "Apple");
            JuiceFlavors.AddOrUpdate(2, "Mango");

            Console.WriteLine("\n Flavors returned from flavor list");
            Console.WriteLine("Returned Flavor:"+JuiceFlavors.GetData(0));
            #endregion

        }
    }

    //Method without a type instantiated whicb will be done so later in the application 
    //Test type 2
    class DataStore<T>
    {
        private T[] _data = new T[10];

        public void AddOrUpdate(int index, T item)
        {
            if (index >= 0 && index < 10)
                _data[index] = item;
        }

        public T GetData(int index)
        {
            if (index >= 0 && index < 10)
                return _data[index];
            else
                return default(T);
        }
    }
}

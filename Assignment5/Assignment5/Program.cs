using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating Dictionary with the key Value pair
            Dictionary<int, string> PrimeDictionary = new Dictionary<int, string>();
            PrimeDictionary.Add(1998, "Atal Bihari Vajpayee");
            PrimeDictionary.Add(2014, "Narendra Modi");
            PrimeDictionary.Add(2004, "Manmohan Singh");

            //Finding the Prime minister of 2004.

            Console.WriteLine("Prime Minister Of 2004 is --> " + PrimeDictionary[2004]);


            //Adding current prime minister in the dictionary.

            PrimeDictionary.Add(2020, "Narendra Modi");


            //Sorting the dictionary by year.

            Console.WriteLine("Sorted List of Prime Ministers by year");
            foreach (KeyValuePair<int, string> PM in PrimeDictionary.OrderBy(key => key.Value))
            {
                Console.WriteLine("Key: {0}, Value: {1}", PM.Key, PM.Value);
            }

            Console.ReadKey();

        }
    }
}

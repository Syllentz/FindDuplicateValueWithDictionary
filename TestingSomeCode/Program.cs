using System;
using System.Collections.Generic;
using System.Linq;

namespace TestingSomeCode
{
    public class Program
    {
        private static object e;
        static void Main(string[] args)
        {
            int[] rNumbers = CreateArray(100);
            Console.Write("Set of Values:");
            foreach (var item in rNumbers)
            {
                Console.Write(" {0}", item);
            }            
            List<int> duplicates = FindDuplicatesNewList(rNumbers);
            Console.Write("\nDuplicate Values:");
            foreach (var item in duplicates)
            {
                Console.Write(" {0}", item);
            }
            Console.ReadKey();
        }
        static int[] CreateArray (int i)
        {
            Random random = new Random();
            int[] array = new int[i];
            int roundedVar = 0;
            for (int j = 0; j < i; j++)
            {
                roundedVar = (int)(random.NextDouble() * 1000);
                array[j] = roundedVar;
            }                
            return array;
        }
        static List<int> FindDuplicatesNewList(int[] array)
        { 
            Dictionary<int,int> dictionary = new Dictionary<int, int>();
            List<int> original = array.ToList();
            List<int> duplicates = new List<int> ();
            for (int i = 0; i < original.Count; i++)
            {
                try
                {
                    dictionary.Add(original[i], i);
                }
                catch (Exception e)
                {
                    duplicates.Add((int)original[i]);  
                    continue;
                }              
            }
            return duplicates;
        }
    }        
}

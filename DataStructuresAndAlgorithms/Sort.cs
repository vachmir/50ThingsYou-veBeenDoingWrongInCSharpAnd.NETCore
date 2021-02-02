using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms
{
     class Sort
    {
        public static void Sorter()
        {

            Console.WriteLine("Ordering Method");
            var list = new List<int> { 4, 3, 5, 8, 2, 1 };
            //  var orderedList = list.OrderBy(x => x).ToList();
            list.Sort();  //Computation goes faster
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}


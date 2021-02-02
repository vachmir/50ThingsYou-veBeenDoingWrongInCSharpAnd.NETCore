using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    class Find
    {
        public static void Finding()
        {
            Console.WriteLine("Find Method");
            var list = new List<int> { 4, 3, 2, 1, 0, 5 };

            var three = list.Where(x => x == 3).FirstOrDefault();
            Console.WriteLine(three);

            three = list.FirstOrDefault(x => x == 3);
            Console.WriteLine(three);

            three = list.Find(x => x == 3);//This is better
            Console.WriteLine(three);

            list.Sort();
            var indexOfThree = list.BinarySearch(3);
            Console.WriteLine(indexOfThree);

        }
    }
}

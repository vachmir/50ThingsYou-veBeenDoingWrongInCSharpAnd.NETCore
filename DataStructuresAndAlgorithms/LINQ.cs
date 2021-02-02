using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    class LINQ
    {
        public static void TheLINQ()
        {
            Console.WriteLine("TheLINK Method");
            var list = new List<int> { 4, 3, 2, 1, 0 };
            var three = list.Where(x => x == 3).FirstOrDefault();
            Console.WriteLine(three);
            three = list.AsQueryable().Where(x => x == 3).FirstOrDefault();
            Console.WriteLine(three);

        }
    }
}

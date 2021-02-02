using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MisusingCSharpPrimitives.MisusingStructsAndBoxingMistakes
{
    class ReadOnlyEnumerator
    {
        private readonly List<int>.Enumerator _enumerator;

        public ReadOnlyEnumerator(List<int> list)
        {
            _enumerator = list.GetEnumerator();
        }

        public void PrintTheFirstElement()
        {
            _enumerator.MoveNext();
            Console.WriteLine(_enumerator.Current);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolvingGeneralCSharpCodingErrors.MisunderstandingVirtualAndOverride
{
    class Toyota : Car
    {
        public override void Run()
            => Console.WriteLine($"Toyota running at speed: {this.speed}");
    }
}

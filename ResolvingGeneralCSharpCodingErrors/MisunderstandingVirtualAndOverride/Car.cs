using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolvingGeneralCSharpCodingErrors.MisunderstandingVirtualAndOverride
{
    public abstract class Car
    {
        protected int speed;
        public abstract void Run();
        public virtual void Accelerate()
            => this.speed += 10;
        public void Stop()
            => Console.WriteLine("Stoppung the car");
    }
}

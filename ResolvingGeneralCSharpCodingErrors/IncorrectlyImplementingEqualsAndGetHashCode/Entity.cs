using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolvingGeneralCSharpCodingErrors.IncorrectlyImplementingEqualsAndGetHashCode
{
    class Entity
    {
        public Entity(int id)
        {
            this.Id = id;
        }
        public int Id { get; }
        public override int GetHashCode() => this.Id;

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(obj, null)) return false;
            if (ReferenceEquals(obj, this)) return true;
            return obj is Entity e1 && e1.Id == this.Id;
        }
    }
}

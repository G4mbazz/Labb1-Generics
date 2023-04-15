using Labb1_Generics.Models;
using System.Diagnostics.CodeAnalysis;

namespace Labb1_Generics.Controllers
{
    internal class BoxSameVol : EqualityComparer<Box>
    {
        public override bool Equals(Box? obj1, Box? obj2)
        {
            if (obj1.width * obj1.length * obj1.height == obj2.width * obj2.length * obj2.height)
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode([DisallowNull] Box obj)
        {
            var hash = obj.height ^ obj.width ^ obj.length;
            return hash.GetHashCode();
        }
    }

}

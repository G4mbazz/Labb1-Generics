using System.Diagnostics.CodeAnalysis;
using Labb1_Generics.Models;

namespace Labb1_Generics.Controllers
{
    internal class BoxSameDimensions : EqualityComparer<Box>
    {
        public override bool Equals(Box? obj1, Box? obj2)
        {
            if (obj1.height == obj2.height && obj1.width == obj2.width && obj1.length == obj2.length)
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode([DisallowNull] Box obj)
        {
            var hash = obj.height ^ obj.length ^ obj.width;
            return hash.GetHashCode();
        }
    }
}
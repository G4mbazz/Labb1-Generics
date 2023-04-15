using Labb1_Generics.Models;
using System.Collections;

namespace Labb1_Generics.Controllers
{
    internal class BoxCollection : ICollection<Box>
    {
        private List<Box> _boxes;
        public BoxCollection()
        {
            _boxes = new List<Box>();
        }
        public Box this[int index]
        {
            get => _boxes[index];
            set => _boxes[index] = value;
        }
        public int Count => _boxes.Count();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(Box item)
        {
            if (!Contains(item) || !Contains(item, new BoxSameVol()))
            {
                _boxes.Add(item);
            }
            else
            {
                Console.WriteLine($"The box with dimensions: Height: {item.height}, Lenght: {item.length}, " +
                $"Width: {item.width} Already exixsts");
            }
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }
        public bool Contains(Box item)
        {
            foreach (var box in _boxes)
            {
                if (box.Equals(item))
                {
                    return true;
                }
            }
            return false;
        }
        public bool Contains(Box item, BoxSameVol comparer)
        {
            foreach (var box in _boxes)
            {
                if (comparer.Equals(box, item))
                {
                    return true;
                }
            }
            return false;
        }

        public void CopyTo(Box[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Box> GetEnumerator()
        {
            return new BoxEnumerator(this);
        }

        public bool Remove(Box item)
        {
            bool result = false;
            for (int i = 0; i < _boxes.Count; i++)
            {
                Box box = _boxes[i];
                if (new BoxSameDimensions().Equals(box, item))
                {
                    _boxes.RemoveAt(i);
                    result = true;
                    break;
                }
            }
            return result;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new BoxEnumerator(this);
        }
    }
}

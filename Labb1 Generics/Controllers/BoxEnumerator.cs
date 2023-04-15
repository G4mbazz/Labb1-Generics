using Labb1_Generics.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_Generics.Controllers
{
    internal class BoxEnumerator : IEnumerator<Box>
    {
        private BoxCollection? _boxes;
        private int _currentIndex;
        private Box? _currentBox;
        public BoxEnumerator(BoxCollection boxes)
        {
            this._boxes = boxes;
            _currentIndex = -1;
            _currentBox = default;
        }

        public bool MoveNext()
        {
            if (++_currentIndex < _boxes.Count)
            {
                _currentBox = _boxes[_currentIndex];
                return true;
            }
            return false;
        }
        public Box Current { get { return _currentBox; } }
        object IEnumerator.Current { get { return Current; } }

        public void Dispose()
        {
        }

        public void Reset()
        {
            _currentIndex = -1;
        }
    }
}

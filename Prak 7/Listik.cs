using System.Collections;

namespace Prak_7
{
    public class Listik<T> : IEnumerable<T>
    {
        private T[] _items;
        private int _length, _capacity;
        const int DefCapacity = 4;
        public int Length
        {
            get { return _length; }
        }

        public int Capacity
        {
            get { return _capacity; }
            set
            {
                if (value < _length)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _capacity = value;
            }
        }
        public Listik()
        {
            _items = new T[0];
        }

        public Listik(int capacity)
        {
            Capacity = capacity;
            _items = new T[Capacity];
        }

        public Listik(System.Collections.Generic.IEnumerable<T> collection)
        {
            _items = collection.ToArray();
        }

        private void IncreaseCapacity()
        {
            if (_capacity == 0)
            {
                _items = new T[2];
                _capacity = _items.Length;
            }
            else 
            {
                Array.Resize(ref _items, _capacity * 2);
                _capacity = _items.Length;
            }
        }

        public void Add(T item)
        {
            if (_length == _capacity)
            {
                IncreaseCapacity();
            }

            if (_length == 0)
            {
                _items[0] = item;
                _length++;
            }

            else
            {
                if (_length < _capacity)
                {
                    _items[_length] = item;
                    _length++;
                }
            }
        }

        public void AddRange(IEnumerable<T> collection)
        {
            T[] temparr = collection.ToArray();
            if (_length == 0)
            {
                IncreaseCapacity();
                _items = temparr;
                _length = _items.Length;
            }
            else
            {
                for (int i = 0; i < temparr.Length; i++)
                {
                    if (_length < _capacity)
                    {
                        _items[_length] = temparr[i];
                        _length++;
                    }
                    else
                    {
                        IncreaseCapacity();
                        _items[_length] = temparr[i];
                        _length++;
                    }
                }
            }
        }

        public void Clear()
        {
            _length = 0;
            _items = new T[0];
        }

        public int IndexOf(T element)
        {
            for (int i = 0; i < _length; i++)
            {
                if (object.Equals(_items[i], element))
                {
                    return i;
                }
            }
            return -1;
        }

        public void Remove(int index)
        {
            if (index < 0 || index >= _length)
                throw new IndexOutOfRangeException();
            _items[index] = default;
            for (int i = index; i < _length - 1; i++)
            {
                _items[i] = _items[i+1];
            }
            _items[_items.Length-1] = default;
            _length--;
            Array.Resize(ref _items, _length);
        }

        public void RemoveAll(T element)
        {
            for (int i = 0; i < _length; i++)
            {
                if (object.Equals(_items[i], element))
                {
                    Remove(i);
                    i--;
                }
            }
        }

        public void Reverse()
        {
            int x;
            if (_length % 2 == 0)
            {
                x = _length / 2;
                for (int i = 0; i < x; i++)
                {
                    T temp = _items[i];
                    _items[i] = _items[_length - 1 - i];
                    _items[_length - 1 - i] = temp;
                }
            }
            else if (_length % 2 != 0)
            {
                x = _length / 2 + 1;
                for (int i = 0; i < x; i++)
                {
                    T temp = _items[i];
                    _items[i] = _items[_length - 1 - i];
                    _items[_length - 1 - i] = temp;
                }
            }
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < _length; i++)
                yield return _items[i];
        }
    }
}

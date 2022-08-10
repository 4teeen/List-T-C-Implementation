using System.Collections;

namespace Prak_7
{
    public class Listik<T> : IEnumerable<T>
    {
        private T[] _items;
        private int _length, _capacity;
        public int Length
        {
            get { return _length; }
        }

        public int Capacity
        {
            get {return _capacity; }
            set
            {
                if (value < _length)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    _capacity = value;
                }
            }
        }

        public T this[int index]
        {
            get
            {
                if (index > _length)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    return _items[index];
                }
            }
            set
            {
                if(index > _length)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _items[index] = value;
            }
            
        }

        public Listik()
        {
            _items = new T[0];
        }

        public Listik(int capacity)
        {
            _capacity = capacity;
            _items = new T[_capacity];
        }

        public Listik(IEnumerable<T> collection)
        {
            T[]temp = collection.ToArray();
            _items = temp;
            _length = temp.Length;
            _capacity = temp.Length;
        }

        private void IncreaseCapacity()
        {
            if (_capacity == 0)
            {
                _items = new T[2];
            }
            else 
            {
                Array.Resize(ref _items, _capacity * 2);
            }
            _capacity = _items.Length;
        }

        public void Add(T item)
        {
            if (_length == _capacity)
            {
                IncreaseCapacity();
            }

             if (_length < _capacity)
             {
                 _items[_length] = item;
                 _length++;
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

                if (_length + temparr.Length > _capacity)
                {
                    _capacity = _length + temparr.Length;
                    Array.Resize(ref _items, _capacity);
                    for (int i = 0; i < temparr.Length; i++)
                    {
                        _items[_length] = temparr[i];
                        _length++;
                    }
                }
                else
                {
                    for (int i = 0; i < temparr.Length; i++)
                    {
                        _items[_length] = temparr[i];
                        _length++;
                    }
                }
               
            }
        }

        public void Clear()
        {
            Array.Clear(_items, 0, _items.Length);
            _length = 0;
        }


        public int IndexOf(T element)
        {
            for (int i = 0; i < _length; i++)
            {
                if (EqualityComparer<T>.Default.Equals(_items[i], element))
                {
                    return i;
                }
            }
            return -1;
        }

        public void Remove(int index)
        {
            if (index < 0 || index >= _length)
            {
                throw new IndexOutOfRangeException();
            }
            _items[index] = default;
            for (int i = index; i < _length - 1; i++)
            {
                _items[i] = _items[i+1];
            }
            _items[_items.Length-1] = default;
            _length--;
        }

        public void RemoveAll(T element)
        {
            for (int i = 0; i < _length; i++)
            {
                if (EqualityComparer<T>.Default.Equals(_items[i], element))
                {
                    Remove(i);
                    i--;
                }
            }
        }

        public void Reverse()
        {
            Array.Reverse(_items);
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

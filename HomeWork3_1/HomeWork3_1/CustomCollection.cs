using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_1
{
	public class CustomCollection<T> : IEnumerable<T>
	{
		private T[] _array;

		public CustomCollection()
		{
			_array = new T[0];
		}

		public int Count => _array.Length;

		public void Sort()
		{
			Array.Sort(_array);
		}

		public void Add(T item)
		{
			Array.Resize(ref _array, _array.Length + 1);
			_array[_array.Length - 1] = item;
		}

		public void SetDefaultAt(int index, T defaultValue)
		{
			if (index >= 0 && index < _array.Length)
			{
				_array[index] = defaultValue;
			}
			else
			{
				throw new IndexOutOfRangeException("Index is out of range.");
			}
		}

		public IEnumerator<T> GetEnumerator()
		{
			foreach (T item in _array)
			{
				yield return item;
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}

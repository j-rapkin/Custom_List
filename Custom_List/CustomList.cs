using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Custom_List
{
	public class CustomList<T> : IEnumerable
	{
		private int count;
		private int arrayCapacity;
		private T[] arrayOfElements;

		public IEnumerator GetEnumerator()
		{
			for (int index=0; index < count; index++)
			{
				yield return arrayOfElements[index];
			}
		}
		public T this[int index]
		{
			get
			{
				if(index >= count)
				{
					throw new ArgumentOutOfRangeException();
				}
				else
				{
					return arrayOfElements[index];
				}
			}
			set
			{
				if (index >= count)
				{
					throw new ArgumentOutOfRangeException();
				}
				else
				{
					arrayOfElements[index] = value;
				}
			}
		}
		public int Count
		{
			get
			{
				return count;
			}
		}
		public int Capacity
		{
			get
			{
				return arrayCapacity;
			}
		}
		public CustomList()
		{
			count = 0;
			arrayCapacity = 4;
			arrayOfElements = new T[arrayCapacity];
		}

	}
}

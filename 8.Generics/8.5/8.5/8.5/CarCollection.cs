using System.Collections;
using System.Collections.Generic;

namespace _8._5
{
	class CarCollection<T> : IEnumerable where T : ICar
	{
		List<T> Vehicles { get; set; }
		public int Count { get => Vehicles.Count; }

        public CarCollection()
        {
            Vehicles = new List<T>();
        }

        public void Add(T vehicle)
        {
            Vehicles.Add(vehicle);
        }
        public void RemoveAt(int index)
        {
            Vehicles.RemoveAt(index);
        }
		public void RemoveAll()
		{
			Vehicles = new List<T>();
		} 

		public T this[int index]
		{
			get { return Vehicles[index]; }
			set
			{
				if (value is ICar && Vehicles.Count > index)
					Vehicles[index] = value;
			}
		}
        public IEnumerator GetEnumerator()
        {
            foreach (T car in Vehicles)
                yield return car;
        }
        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < Vehicles.Count; i++)
                result += string.Format($"\n#{i + 1}\n" + Vehicles[i] + "\n----------------");
            return result;
        }
    }
}
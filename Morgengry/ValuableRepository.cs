using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
	public class ValuableRepository
	{
		List<IValuable> valuables = new List<IValuable>();

		public void AddValuable(IValuable v)
		{
			valuables.Add(v);
		}

		public IValuable GetValuable(string id)
		{
			for (int i = 0; i < valuables.Count; i++)
			{
				if (valuables[i] is Merchandise m)
				{
					if (m.ItemId == id)
					{
						return m;
					}
				}
				else if (valuables[i] is Course c)
				{
					if (c.Name == id)
					{
						return c;
					}
				}
			}
			return null;
		}

		public double GetTotalValue()
		{
			double count = 0;
			for (int i = 0; i < valuables.Count; i++)
			{
				count += valuables[i].GetValue();
			}
			return count;
		}

		public int Count()
		{
			return valuables.Count;
		}
	}
}

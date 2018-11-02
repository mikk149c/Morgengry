using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
	public class ValuableRepository : IPersistable
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

		public void Save()
		{
			Save("ValuableRepository.txt");
		}

		public void Save(string filename)
		{
			string path = $"{filename}";
			if (File.Exists(path))
				File.Delete(path);
			StreamWriter sw = File.CreateText($"{path}");
			foreach (IValuable v in valuables)
			{
				if (v is Book b)
				{
					sw.WriteLine($"BOG;{b.ItemId};{b.Title};{b.Price}");
				}
				else if (v is Amulet a)
				{
					sw.WriteLine($"AMULET;{a.ItemId};{a.Design};{a.Quality}");
				}
				else if (v is Course c)
				{
					sw.WriteLine($"COURSE;{c.Name};{c.DurationInMinutes}");
				}
			}
			sw.Close();
		}

		public void Load()
		{
			Load("ValuableRepository.txt");
		}

		public void Load(string filename)
		{
			string path = $"{filename}";
			if (File.Exists(path))
			{
				StreamReader sr = new StreamReader(path);
				string[] lines = sr.ReadToEnd().Split('\n');
				sr.Close();
				foreach (string s in lines)
				{
					string[] data = s.Split(';');
					switch (data[0])
					{
						case "BOG":
							valuables.Add(new Book(data[1], data[2], Double.Parse(data[3])));
							break;
						case "AMULET":
							Level l = new Level();
							Enum.TryParse(data[3], out l);
							valuables.Add(new Amulet(data[1], l, data[2]));
							break;
						case "COURSE":
							valuables.Add(new Course(data[1], int.Parse(data[2])));
							break;
					}
				}
			}
		}
	}
}

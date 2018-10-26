using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
	public class Course
	{
		private string name;
		private int durationInMinutes = 0;

		public Course(string name)
		{
			Name = name;
		}

		public Course(string name, int durationInMinutes) : this(name)
		{
			DurationInMinutes = durationInMinutes;
		}

		public string Name { get { return name; } set {	name = value; } }
		public int DurationInMinutes { get { return durationInMinutes; } set { durationInMinutes = value; } }

		public override string ToString()
		{
			return $"Name: {Name}, Duration in Minutes: {DurationInMinutes}";
		}
	}
}

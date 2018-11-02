using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
	public class Course : IValuable
	{
		private string name;
		private int durationInMinutes = 0;
		private double coursHourValue = 825;
		public double CourseHourValue
		{
			get { return coursHourValue; }
			set { coursHourValue = value; }
		}
		public string Name { get { return name; } set {	name = value; } }
		public int DurationInMinutes
		{
			get { return durationInMinutes; }
			set { durationInMinutes = value; }
		}

		public Course(string name)
		{
			Name = name;
		}

		public Course(string name, int durationInMinutes) : this(name)
		{
			DurationInMinutes = durationInMinutes;
		}

		public double GetValue()
		{
			return (durationInMinutes + 59) / 60 * CourseHourValue;
		}

		public override string ToString()
		{
			return $"Name: {Name}, Duration in Minutes: {DurationInMinutes}, Pris pr påbegyndt time: {CourseHourValue}";
		}
	}
}

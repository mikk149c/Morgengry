using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
	public class Amulet : Merchandise
	{
		private string design;
		private Level quality;
		private static double lowQualityValue = 12.5;
		private static double mediumQualityValue = 20;
		private static double highQualityValue = 27.5;
		public string Design { get { return design; } set { design = value; } }
		public Level Quality { get { return quality; } set { quality = value; } }
		public static double LowQualityValue { get { return lowQualityValue; } }
		public static double MediumQualityValue { get { return mediumQualityValue; } }
		public static double HighQualityValue { get { return highQualityValue; } }

		public Amulet(string itemId, Level quality, string design)
		{
			ItemId = itemId;
			Quality = quality;
			Design = design;
		}
		public Amulet(string itemId, Level quality) : 
			this ( itemId, quality, "" )
		{
		}
		public Amulet(string itemId) :
			this ( itemId, Level.medium )
		{
		}
		public override string ToString()
		{
			return $"ItemId: { ItemId }, Quality: { Quality }, Design: { Design }";
		}

		public override double GetValue()
		{
			double r;
			switch (this.Quality)
			{
				case Level.high:
					r = HighQualityValue;
					break;
				case Level.medium:
					r = MediumQualityValue;
					break;
				case Level.low:
					r = LowQualityValue;
					break;
				default:
					r = 0;
					break;
			}
			return r;
		}
	}
}

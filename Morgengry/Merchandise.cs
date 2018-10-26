using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
	abstract public class Merchandise
	{
		private string itemId;
		public string ItemId { get { return itemId; } set { itemId = value; } }
		public override string ToString()
		{
			return $"ItemId: {ItemId}";
		}
	}
}

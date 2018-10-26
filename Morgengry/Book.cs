using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
	public class Book
	{
		private string itemId;
		private string title;
		private double price;
		public string ItemId { get { return itemId; } set { itemId = value; } }
		public string Title	{ get { return title; } set { title = value; } }
		public double Price { get { return price; } set { price = value; } }

		public Book(string itemId, string title, double price)
		{
			ItemId = itemId;
			Title = title;
			Price = price;
		}
		public Book(string itemId, string title) : 
			this (itemId, title, 0)
		{
		}
		public Book(string itemId) :
			this (itemId, "")
		{
		}
		public override string ToString()
		{
			return $"ItemId: {ItemId}, Title: {Title}, Price: {Price}";
		}
	}
}

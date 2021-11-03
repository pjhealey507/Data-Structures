using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
	class Dish
	{
		public bool washed;

		public Dish()
		{
			washed = false;
		}

		public string Status()
		{
			return String.Format("{0} is washed: {1}", this, washed);
		}
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
	class Dishwasher
	{
		Queue<Dish> dirty_dishes;
		Stack<Dish> clean_dishes;

		public Dishwasher()
		{
			dirty_dishes = new Queue<Dish>();
			clean_dishes = new Stack<Dish>();

			AddAllDishes();
			WashAllDishes(dirty_dishes);
			CheckAllDishes(clean_dishes);
		}

		public void AddAllDishes()
		{
			for (int i = 0; i < 10; i++)
			{
				Dish d = new Dish();
				AddDirtyDish(d);
			}
		}

		public void WashAllDishes(Queue<Dish> dishes)
		{
			foreach (Dish d in dishes)
			{
				Wash(dishes.Peek());
				AddCleanDish(dishes.Peek());
			}

			dishes.Clear();
		}

		public void CheckAllDishes(Stack<Dish> dishes)
		{
			foreach (Dish d in dishes)
			{
				Console.WriteLine(d.Status());
			}
		}

		public void AddDirtyDish(Dish d)
		{
			dirty_dishes.Enqueue(d);
		}

		public void AddCleanDish(Dish d)
		{
			clean_dishes.Push(d);
		}

		public void Wash(Dish d)
		{
			d.washed = true;
		}
	}
}

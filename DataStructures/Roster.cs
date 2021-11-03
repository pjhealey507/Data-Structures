using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
	class Roster
	{
		public Employee[] employees;
		public Dictionary<int, Employee> employeesID;

		public Roster()
		{
			employees = new Employee[5];

			SetEmployeeArray();
			SetEmployeeDictionary();

			GetEmployeeByID(21);
			GetEmployeeByID(76);
			GetEmployeeByID(54);
		}

		public void SetEmployeeArray()
		{
			employees[0] = new Employee("John", 15);
			employees[1] = new Employee("Sally", 21);
			employees[2] = new Employee("Jim", 32);
			employees[3] = new Employee("Jennifer", 76);
			employees[4] = new Employee("Fred", 54);
		}

		public void SetEmployeeDictionary()
		{
			employeesID = new Dictionary<int, Employee>()
			{
				{15, new Employee("John", 15)},
				{21, new Employee("Sally", 21)},
				{32, new Employee("Jim", 32)},
				{76, new Employee("Jennifer", 76)},
				{54, new Employee("Fred", 54)},
			};
		}

		public void GetEmployeeByID(int ID)
		{
			Employee employee;

			employeesID.TryGetValue(ID, out employee);

			Console.WriteLine(employee.name);
		}
	}
}

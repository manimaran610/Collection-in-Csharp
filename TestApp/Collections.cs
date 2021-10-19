using System;
using System.Collections.Generic;

namespace TestApp
{

    public class CollectionsMainPage
    {
        public static void HomePage()
        {
            List<Employee> employeeList = new List<Employee>();
            Employee employee1 = new Employee("MANI1", "ACE1234");
            Employee employee2 = new Employee("AANI2", "ACE1235");
            Employee employee3 = new Employee("CANI3", "ACE1236");
            Employee employee4 = new Employee("LANI4", "ACE1237");


            employeeList.Add(employee1);
            employeeList.Add(employee2);
            employeeList.Add(employee3);
            employeeList.Add(employee4);

            Console.WriteLine($"Capacity :{employeeList.Capacity}");

            Console.WriteLine("Before Sort");
            for (int index = 0; index < employeeList.Count; index++)
            {
                Console.WriteLine(employeeList[index].Name, employeeList[index].EmployeeId);
            }
           
            bool isExists = employeeList.Exists(item => item.Name == "MANI1");

            SortByName sortByName = new SortByName();  //sorting using iComparer
            employeeList.Sort(sortByName);


            Console.WriteLine("After sort");
            foreach (Employee employee in employeeList)
            {
                Console.WriteLine(employee.Name, employee.EmployeeId);
            }


            employeeList.RemoveAt(3);
            employeeList.RemoveAll(item => item.Name != null);

        }




        public class SortByName : IComparer<Employee>
        {


            public  int Compare(Employee x, Employee y)
            {
                return x.Name.CompareTo(y.Name);
            }
        }









        public class Employee
        {
            public string Name { get; }
            public string EmployeeId { get; }

            public Employee(string name, string employeeId)
            {
                this.Name = name;
                this.EmployeeId = employeeId;
            }

        }
    }
}
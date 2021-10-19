using System.Collections.Generic;
using System;

namespace TestApp
{
    public class DictionaryMainPage
    {
        public static void HomePage()
        {
            Dictionary<string,Employee> employeeDictionary = new Dictionary<string, Employee>();
            Employee employee1 = new Employee("MANI1", "ACE1234");
            Employee employee2 = new Employee("AANI2", "ACE1235");
            Employee employee3 = new Employee("CANI3", "ACE1236");
            Employee employee4 = new Employee("LANI4", "ACE1237");


            employeeDictionary.Add(employee1.Name,employee1);
            employeeDictionary.Add(employee2.Name, employee2);
            employeeDictionary.Add(employee3.Name, employee3);
            employeeDictionary.Add(employee4.Name, employee4);

            employeeDictionary[employee1.Name] = employee4;
            foreach(KeyValuePair<string,Employee> employee in employeeDictionary)
            {
                Console.WriteLine($"key :{employee.Key} Value :{employee.Value.EmployeeId}");
            }

            ICollection<string> keys = employeeDictionary.Keys;
          

           foreach (var key in keys)
            {
                Console.WriteLine(employeeDictionary[key].EmployeeId);
            }


            employeeDictionary.Remove("MANI1");  //remove with key
            if (!employeeDictionary.ContainsKey("ANNA"))
            {
                Console.WriteLine("Keys does't exists");
            }
            employeeDictionary.Clear();  // removes all the elements in the dictionary
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
using System.Collections.Generic;
using System.Linq;

namespace TestApp
{
    public class LINQMainPage
    {

        public static void HomePage()
        {
            List<Customers> customers = new List<Customers>();
            customers.Add(new Customers(12, "MANI", 21));
            customers.Add(new Customers(22, "MANI", 25));
            customers.Add(new Customers(52, "Akshaya", 39));
            customers.Add(new Customers(2, "Raji", 51));
            customers.Add(new Customers(188, "Prakash", 41));
            customers.Add(new Customers(25, "Krishna", 16));
            customers.Add(new Customers(32, "Banu", 59));

            //LINQ Queries
            var LINQset = from CustomList in customers where CustomList.Age > 10  orderby CustomList.Name select CustomList ;

            var LINQset2 = from CustomList in customers  select CustomList.OrderNo;
            var LINQset3 = from CustomList in customers select  CustomList.Name;

            foreach (Customers customer in LINQset.Take(3)){

                System.Console.WriteLine($"{customer.Name} {customer.Age}");
            }
            foreach (Customers customer in LINQset.Where(item => item.Name.Contains("ak")))
            {
                System.Console.WriteLine($"contains block {customer.Name} {customer.Age}");
            }

            System.Console.WriteLine("MAX OF ORDER  {0}",LINQset2.Max());
            System.Console.WriteLine("SUM OF ORDER   {0} ", LINQset2.Average());
            System.Console.WriteLine(LINQset.ElementAt(2).Name);
            System.Console.WriteLine(LINQset3.Distinct());

        }

    }

    public class Customers
    {
       public int OrderNo;
        public string Name;
        public int Age;

        public Customers(int OrderNo, string Name, int Age) { 
            this.OrderNo=OrderNo;
            this.Age = Age;
            this.Name = Name;

        
        }
    }
}
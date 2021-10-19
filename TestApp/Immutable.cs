using System;
using System.Collections.Immutable;

namespace TestApp
{
    public class ImmutableMainPage
    {

        public static void HomePage()
        {
            ImmutableList<Int32> numbers = ImmutableList.Create<Int32>().Add(0);

            numbers.Add(2);
            int[] arr = new int[2] {1, 2 };

            numbers.AddRange(arr);

           
           

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

        }
    }
}

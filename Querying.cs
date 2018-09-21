using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_notes
{
    class Querying
    {

        public static List<int> numbers = new List<int> { 2, 4, 8, 16, 32, 64 };

        public static List<int> numbersgreaterThanTen = new List<int>();

        public static void RunQuery()
        {
            foreach ( var number in numbers )
            {
                if ( number > 10 )
                {
                    numbersgreaterThanTen.Add(number);
                }
            }

            numbersgreaterThanTen.ForEach(x => Console.Write(x + ", "));
            Console.WriteLine();
        }
    }
}

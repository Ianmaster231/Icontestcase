using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace icontestcase
{
    class Program
    {
        static void Main(string[] args)
        {

            int eur10 = 999;
            int[] eur20 = Enumerable.Range(1000, 2000).ToArray();

            Console.WriteLine("Enter the width: ");
            int a = Convert.ToInt32(Console.ReadLine());

            /*    Console.WriteLine("Enter the Second Number: ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the Third Number: ");
                int c = Convert.ToInt32(Console.ReadLine());

                int large = (a > b) ? ((b > c) ? a : (c > a) ? c : a) : (b > c) ? b : c; */

            
            if(a <= eur10)
            {
                Console.WriteLine("Parcel cost is 10 Eur");
            }
            else if (a > 1000 || a <= 2000)
            {
                Console.WriteLine("Parcel cost is 20 Eur");
            }    

           
        }
    }
}

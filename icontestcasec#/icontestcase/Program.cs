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

            //console showing the user the three options that are avaliable as a mailing service
            Console.WriteLine("Please select a mail order option:");
            Console.WriteLine("1. Cargo4You 1");
            Console.WriteLine("2. ShipFaster 2");
            Console.WriteLine("3. MaltaShip 3");
            Console.WriteLine("Enter your selection (1 or 2 or 3):");
            //Storing the variable answer to be excituted 
            int selection = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the weight :");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the width: ");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the height: ");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the depth: ");
            int depth = Convert.ToInt32(Console.ReadLine());

            int cost = width + height + depth;

            decimal weightCost;
            decimal parcelSizeCost = cost;
            switch (selection)
            {
                case 1:
                    weightCost = weightcostCargo4You(input);
                    parcelSizeCost = parcelsizeMaltapost(cost);
                    break;
                case 2:
                    weightCost = weightcostShipFaster(input);
                    break;
                case 3:
                    weightCost = weightcostMaltapost(input);
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    return;
            }
            if (weightCost >= parcelSizeCost)
            {
                Console.WriteLine("Parcel cost: " + weightCost);
            }
            else
            {
                Console.WriteLine("Parcel cost: " + parcelSizeCost);
            }
            //Console.WriteLine("Parcel cost: " + weightCost);
            //Console.WriteLine("Parcel cost: " + parcelSizeCost);

        }

        static decimal parcelsizeMaltapost(int cost)
        {
            decimal pclsize;
            switch (cost)
            {
                case int n when n <= 1000:
                    pclsize = 10;
                    break;
                case int n when n > 1000 && n <= 2000:
                    pclsize = 20;
                    break;
                case int n when n <= 2000:
                    Console.WriteLine("Parcel Dimension exceded");
                    pclsize = 0;
                    break;
                default:
                    pclsize = 0;
                    break;
            }
            return pclsize;
        }

        static decimal weightcostMaltapost(int weight)
        {
            decimal wgtcst;
            switch (weight)
            {
                case int n when n <= 0:
                    wgtcst = 0;
                    Console.WriteLine("Local Shipping mostly depends on dimentions of the parcel");
                    break;
                default:
                    wgtcst = 0;
                    break;
            }
            return wgtcst;
        }

        static decimal weightcostCargo4You(int weight)
        {
            decimal wgtcst;
            switch (weight)
            {
                case int n when n <= 2000:
                    wgtcst = 15;
                    break;
                case int n when n > 2000 && n <= 15000:
                    wgtcst = 18;
                    break;
                case int n when n > 15000 && n <= 19999:
                    wgtcst = 35;
                    break;
                case int n when n >= 20000:
                    wgtcst = 0;
                    Console.WriteLine("Weight exceded");
                    break;
                default:
                    wgtcst = 0;
                    break;
            }
            return wgtcst;
        }

        static decimal weightcostShipFaster(int weight)
        {
            decimal wgtcst;
            switch (weight)
            {
                case int n when n >= 10000 && n <= 15000:

                    wgtcst = 16.50m;
                    break;
                case int n when n > 15000 && n <= 25000:
                    wgtcst = 36.50m;
                    break;
                case int n when n > 25000:
                    wgtcst = 40 + (weight - 25) * 0.417m;
                    break;
                case int n when n < 10000 && n <= 30000:
                    wgtcst = 0;
                    Console.WriteLine("Weight is to little or excided the maximum limit");
                    break;
                default:
                    wgtcst = 0;
                    break;
            }
            return wgtcst;
        }
    }
}

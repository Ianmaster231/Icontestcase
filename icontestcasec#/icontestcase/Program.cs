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
            //Programmed by Ian Zammit
            //console showing the user the three options that are avaliable as a mailing service
            Console.WriteLine("Please select a mail order option:");
            Console.WriteLine("1. Cargo4You 1");
            Console.WriteLine("2. ShipFaster 2");
            Console.WriteLine("3. MaltaShip 3");
            Console.WriteLine("Enter your selection (1 or 2 or 3):");
            //Storing the variable answer to be excituted 
            int selection = int.Parse(Console.ReadLine());
            //User enters the data and is stored in variables and then these values are put in functions
            Console.WriteLine("Enter the weight :");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the width: ");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the height: ");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the depth: ");
            int depth = Convert.ToInt32(Console.ReadLine());
            //the cost is combining all the valeus of width, height, depth for overall size of the package
            int cost = width + height + depth;

            decimal weightCost;
            decimal parcelSizeCost = cost;
            //this is the select switch fucntion where the user is 
            switch (selection)
            {
                case 1:
                    //uses the values inputed by the user and access the funcions according to there roles
                    weightCost = weightcostCargo4You(input);
                    parcelSizeCost = parcelsizeCargo4You(cost);
                    break;
                case 2:
                    weightCost = weightcostShipFaster(input);
                    parcelSizeCost = parcelsizeShipfaster(cost);
                    break;
                case 3:
                    weightCost = weightcostMaltapost(input);
                    parcelSizeCost = parcelsizeMaltapost(cost);
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    return;
            }
            //this is for the fucntion so when both prices are out the one that is more expensive gets shwon in the console application
            if (weightCost >= parcelSizeCost)
            {
                Console.WriteLine("Parcel cost: " + weightCost + "Eur");
            }
            else
            {
                Console.WriteLine("Parcel cost: " + parcelSizeCost + "Eur");
            }
            //the code below is to test to make sure the if statement is working properly
            //Console.WriteLine("Parcel cost: " + weightCost);
            //Console.WriteLine("Parcel cost: " + parcelSizeCost);

        }
        //math equation function for the parcel size 
        static decimal parcelsizeCargo4You(int cost)
        {
            decimal pclsize;
            switch (cost)
            {
                //Any parcel <= 1000cm  costs €10
                case int n when n <= 1000:
                    //
                    pclsize = 10;
                    break;
                //Any parcel > 1000cm3 and <= 2000cm3 costs €20
                case int n when n > 1000 && n <= 2000:
                    pclsize = 20;
                    break;
                //Any parcel <= 20Kg validations
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
        //math equation function for the parcel size 
        static decimal parcelsizeShipfaster(int cost)
        {
            decimal pclsize;
            switch (cost)
            {
                // Any parcel <= 1000cm3 costs €11.99
                case int n when n <= 1000:
                    pclsize = 11.99m;
                    break;
                //  Any parcel > 1000cm3 and <= 1700cm3 costs €21.99
                case int n when n > 1000 && n <= 1700:
                    pclsize = 21.99m;
                    break;
                // Any parcel <= 1700cm3 validations
                case int n when n <= 1701:
                    Console.WriteLine("Parcel Dimension exceded");
                    pclsize = 0;
                    break;
                default:
                    pclsize = 0;
                    break;
            }
            return pclsize;
        }
        //math equation function for the parcel size 
        static decimal parcelsizeMaltapost(int cost)
        {
            decimal pclsize;
            switch (cost)
            {
                // Any parcel >= 500cm3 validation
                case int n when n >= 500:
                    pclsize = 0;
                    Console.WriteLine("Parcel Dimension exceded");
                    break;
                // Any parcel <= 1000cm3 costs €9.50
                case int n when n <= 1000:
                    pclsize = 9.50m;
                    break;
                // Any parcel > 1000cm3 and <= 2000cm3 costs €19.50
                case int n when n > 1000 && n <= 2000:
                    pclsize = 19.50m;
                    break;
                // Any parcel > 2000cm3 and <= 5000cm3 costs €48.50
                case int n when n >= 2000 && n <= 5000:
                    pclsize = 48.50m;
                    break;
                // Any parcel > 5000cm3 costs €147.50
                case int n when n <= 5000:
                    pclsize = 147.50m;
                    break;
                default:
                    pclsize = 0;
                    break;
            }
            return pclsize;
        }
        //math equation function for the parcel weight 
        static decimal weightcostMaltapost(int weight)
        {
            decimal wgtcst;
            switch (weight)
            {
                // Any parcel > 10Kg and <= 20Kg costs €16.99
                case int n when n > 10000 && n <= 20000:
                    wgtcst = 16.99m;
                    break;
                // Any parcel > 20Kg and <= 30Kg costs €33.99
                case int n when n > 20000 && n <= 30000:
                    wgtcst = 33.99m;
                    break;
                // Any parcel > 30Kg costs €43.99 plus €0.41 for every Kg over 25Kg
                case int n when n > 30000:
                    wgtcst = 43.99m + (weight - 25) * 0.41m;
                    break;
                default:
                    wgtcst = 0;
                    break;
            }
            return wgtcst;
        }
        //math equation function for the parcel weight 
        static decimal weightcostCargo4You(int weight)
        {
            decimal wgtcst;
            switch (weight)
            {
                // Any parcel <= 2Kg costs €15
                case int n when n <= 2000:
                    wgtcst = 15;
                    break;
                // Any parcel > 2Kg and <= 15Kg costs €18
                case int n when n > 2000 && n <= 15000:
                    wgtcst = 18;
                    break;
                //  Any parcel > 15Kg and <= 20Kg costs €35 
                case int n when n > 15000 && n <= 19999:
                    wgtcst = 35;
                    break;
                // Any parcel <= 20Kg validation
                case int n when n >= 20000:
                    wgtcst = 0;
                    Console.WriteLine("Weight excided");
                    break;
                default:
                    wgtcst = 0;
                    break;
            }
            return wgtcst;
        }
        //math equation function for the parcel weight 
        static decimal weightcostShipFaster(int weight)
        {
            decimal wgtcst;
            switch (weight)
            {
                // Any parcel > 10Kg and <= 15Kg costs €16.50
                case int n when n >= 10000 && n <= 15000:
                    wgtcst = 16.50m;
                    break;
                // Any parcel > 15Kg and <= 25Kg costs €36.50
                case int n when n > 15000 && n <= 25000:
                    wgtcst = 36.50m;
                    break;
                // Any parcel > 25Kg costs €40 plus €0.417 for every  Kg over 25Kg
                case int n when n > 25000:
                    wgtcst = 40 + (weight - 25) * 0.417m;
                    break;
                // 10Kg < Any parcel <= 30Kg validation
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

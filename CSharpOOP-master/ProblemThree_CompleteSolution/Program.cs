using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemThree_CompleteSolution_BL;
namespace ProblemThree_CompleteSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            ////SampleCodeToTestYourClassImplementation
            Console.WriteLine("WELCOME TO SMARTSHOP");
            Console.WriteLine("Please ADD Product In GourmetOrganicShop");
            var organicPriceDict = new Dictionary<int, double>();
            int i = 1;
            
                Console.WriteLine("Enter Product Name");
                string gosProduct= Console.ReadLine();
                Console.WriteLine("Enter Product Price");
                double gosPr = Convert.ToDouble(Console.ReadLine());
                organicPriceDict.Add(i,gosPr);
                i++;
                var gosObj = new GourmetOrganicShop(i,gosProduct, organicPriceDict);
                Console.WriteLine("Please Enter Quantity ");
                int quantityToBuy = Convert.ToInt32(Console.ReadLine());
            var organicPriceDict2 = new Dictionary<int, double>();

            Console.WriteLine("Enter Product Name");
            string gosProduct2 = Console.ReadLine();
            Console.WriteLine("Enter Product Price");
            double gosPr2 = Convert.ToDouble(Console.ReadLine());
            organicPriceDict.Add(i, gosPr);
            i++;
            var gosObj2 = new GourmetOrganicShop(i, gosProduct2, organicPriceDict);
            Console.WriteLine("Please Enter QuantityInGram ");
            int quantityInGrams = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The total cost for {0} packets of {1} is {2}/- INR", quantityToBuy,gosObj.itemName,gosObj.PayPerPiece(quantityToBuy));
            Console.WriteLine("The total cost for {0} grams of {1} is {2}/- INR", quantityInGrams, gosObj2.itemName, gosObj2.PayPerWeight(quantityInGrams));
            

            ////Key 1 for first product
            //organicPriceDict.Add(1, 234.10);
            ////Key 2 for second product
            //organicPriceDict.Add(2, 100.100);
            //var gosObj = new GourmetOrganicShop(1, "Non Polished Tur Dal", organicPriceDict);
            //var gosTwoObj = new GourmetOrganicShop(2, "Non Polished Tur Dal", organicPriceDict);
            //int quantityToBuy = 2;
            //int quantityInGrams = 200;
            //Console.WriteLine("The total cost for {0} packets of {1} is {2}/- INR", quantityToBuy,gosObj.ItemName,gosObj.PayPerPiece(quantityToBuy));
            //Console.WriteLine("The total cost for {0} grams of {1} is {2}/- INR", quantityInGrams, gosTwoObj.ItemName, gosTwoObj.PayPerPiece(quantityToBuy));

            Console.WriteLine("WELCOME TO SMARTSHOP");
            Console.WriteLine("Please ADD Product In CoffeShop");
            var coffeePriceDict = new Dictionary<int, double>();
            int j = 1;

            Console.WriteLine("Enter Product Name");
            string coffeProduct = Console.ReadLine();
            Console.WriteLine("Enter Product Price");
            double coffePr = Convert.ToDouble(Console.ReadLine());
            coffeePriceDict.Add(j, coffePr);
            var cofeeObj = new GourmetCoffeeShop(j, coffeProduct, coffeePriceDict);
            Console.WriteLine("Please Enter Quantity ");
            int quantityToBuyCoffee = Convert.ToInt32(Console.ReadLine());
            var coffeePriceDict2 = new Dictionary<int, double>();
            j++;
            Console.WriteLine("Enter Product Name");
            string coffeProduct2 = Console.ReadLine();
            Console.WriteLine("Enter Product Price");
            double coffePr2 = Convert.ToDouble(Console.ReadLine());
            coffeePriceDict2.Add(j, coffePr2);
            
            var coffeObj2 = new GourmetCoffeeShop(j, coffeProduct2, coffeePriceDict2);
            Console.WriteLine("Please Enter QuantityInGram ");
            int quantityInGramsCoffee = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The total cost for {0} packets of {1} is {2}/- INR", quantityToBuy, cofeeObj.itemName, cofeeObj.PayPerPiece(quantityToBuyCoffee));
            Console.WriteLine("The total cost for {0} grams of {1} is {2}/- INR", quantityInGramsCoffee, coffeObj2.itemName, coffeObj2.PayPerWeight(quantityInGramsCoffee));
            Console.WriteLine("Thank you for shoping");
            var result=Console.ReadKey();
            Console.WriteLine(result);
        }
            ////Key 1 for first product
            //coffeePriceDict.Add(1, 400.40);
            ////Key 2 for second product
            //coffeePriceDict.Add(2, 250.50);
            //var coffObj = new GourmetCoffeeShop(1, "Arabica Coffee Powder Pre-Packed Container", coffeePriceDict);
            //var coffTwoObj = new GourmetOrganicShop(2, "Arabica Coffee Poweder", organicPriceDict);
            //int quantityToBuyCoffee = 2;
            //int quantityInGramsCoffee = 200;
            //Console.WriteLine("The total cost for {0} packets of {1} is {2}/- INR", quantityToBuyCoffee, coffObj.ItemName, coffObj.PayPerPiece(quantityToBuy));
            //Console.WriteLine("The total cost for {0} grams of {1} is {2}/- INR", quantityInGramsCoffee, coffTwoObj.ItemName, coffTwoObj.PayPerPiece(quantityToBuy));



        }
    }


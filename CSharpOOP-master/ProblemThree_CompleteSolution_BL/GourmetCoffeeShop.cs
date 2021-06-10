using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemThree_CompleteSolution_BL
{
    public class GourmetCoffeeShop : GourmetShop, ITaxCompute
    {
        public double TotalBillValue { get; set; }
        public GourmetCoffeeShop(int iCode, string iName, Dictionary<int, double> iPrice)
        {
            this.itemCode = iCode;
            this.itemName = iName;
            this.itemPrice = iPrice;
        }
        double ITaxCompute.TaxOnTotalBill(double total)
        {
            return 0;
        }

        public override double PayPerPiece(int quantity)
        {
            try
            {
                return quantity * itemPrice[1];
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return quantity * itemPrice[1];
            }

            
        }

        public override double PayPerWeight(int weight)
        {
            try
            {
                return weight * itemPrice[2];
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return weight * itemPrice[2];
            }
          

        }
    }
}

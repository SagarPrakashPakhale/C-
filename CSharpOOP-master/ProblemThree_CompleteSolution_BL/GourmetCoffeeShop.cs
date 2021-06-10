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
        double ITaxCompute.TaxOnTotalBill()
        {
            throw new NotImplementedException();
        }

        public override double PayPerPiece(int quantity)
        {

            return quantity * itemPrice[1];
        }

        public override double PayPerWeight(int weight)
        {
            return weight * itemPrice[2];
        }
    }
}

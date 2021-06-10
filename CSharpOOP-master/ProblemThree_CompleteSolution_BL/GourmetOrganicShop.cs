using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemThree_CompleteSolution_BL
{
    public class GourmetOrganicShop : GourmetShop,ITaxCompute
    {


        // public override double PayPerPiece(int quantity);
        //public override double PayPerWeight(int weight);
        /* public GourmetOrganicShop(int ProductNumber, string ProductName)
         {
             this.itemCode = ProductNumber;
             this.itemName = ProductName;
         }*/

        double totalBillValue { get; set; }


        public GourmetOrganicShop(int iCode, string iName,Dictionary<int,double>iPrice)
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

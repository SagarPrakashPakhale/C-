using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemThree_CompleteSolution_BL
{
    public abstract class GourmetShop
    {     
        public  string itemName { get; set; }
        public  int itemCode { get; set; }
        public  Dictionary<int,double> itemPrice { get; set; }
        public abstract double PayPerPiece(int quantity);
        public abstract double PayPerWeight(int weight);

        public GourmetShop()
        {

        }
        public GourmetShop(int iCode,string iName)
        {
            this.itemCode = iCode;
           this. itemName = iName;
        }

    }
}
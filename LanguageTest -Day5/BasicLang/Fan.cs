using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicLang
{
   public class Fan
    {
        // variables
         int _noOfWings = 0;
         public int WingsCount
         {
             set { _noOfWings = value; }
             get { return _noOfWings; }
         }

        //string Manufacturer = "";
         public string Manufacturer { get; set; }


        //float height = 0;
        //float speed = 0;
        float height = 0,  
            speed = 0;

        //float costPrice = 0;
        //public float getCostPrice()
        //{
        //    return costPrice;
        //}
        //public void setCostPrice(float price)
        //{
        //    costPrice = price;
        //}
        public float CostPrice { get; set; }

        //methods

    }
}

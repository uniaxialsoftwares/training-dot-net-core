using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicLang
{
    public class InventoryItems
    {
        public int ItemID { get; set; }
        public string Name { get; set; }
        public string Manufacture { get; set; }
        public DateTime DoE { get; set; }
        public DateTime DoM { get; set; }
        public float Price { get; set; }
        public int NoOfQty { get; set; }

        public InventoryItems(
            int paramItemID,
            string paramName, 
            string paramManu,
            DateTime paramDoE,
            float paramPrice)
        {
            this.Name = paramName;
            this.ItemID = paramItemID;
            this.Manufacture = paramManu;
            this.DoE = paramDoE;
            this.Price = paramPrice;
        }


        public string GetDeatils(int paramItemID)
        {
            float sp = Price + Price * 0.10F;

            return this.Manufacture + "-" +
                this.DoE.ToString("yyyy/MM/dd") + "-" +
                sp;    
        }
    }
}

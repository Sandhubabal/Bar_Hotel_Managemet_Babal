using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bar_Hotel_Managemet_Babal.Models
{
    public class FoodRateList
    {
        public int ID { get; set; }
        public int FoodItemID { get; set; }
        public decimal Rate { get; set; }
        public string PlatType { get; set; }

        public FoodItem FoodItems { get; set; }


    }
}
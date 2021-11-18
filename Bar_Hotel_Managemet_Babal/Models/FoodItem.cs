using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bar_Hotel_Managemet_Babal.Models
{
    public class FoodItem
    {
        public int ID { get; set; }
        public int FoodCategoryID { get; set; }
        public string Name { get; set; }

        public FoodCategory FoodCategories { get; set; }
        public List<FoodRateList> FoodRateList { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bar_Hotel_Managemet_Babal.Models
{
    public class FoodCategory
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public List<FoodItem> FoodItems { get; set; }
    }
}
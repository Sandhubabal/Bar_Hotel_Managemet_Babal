using System.Web;
using System.Web.Mvc;

namespace Bar_Hotel_Managemet_Babal
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

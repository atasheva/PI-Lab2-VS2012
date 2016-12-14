using System.Web;
using System.Web.Mvc;

namespace PI_Lab2_VS2012
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
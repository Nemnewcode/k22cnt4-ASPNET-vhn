using System.Web;
using System.Web.Mvc;

namespace VhnK22CNT4Lesson11_2210900050
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

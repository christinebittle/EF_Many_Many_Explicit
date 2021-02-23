using System.Web;
using System.Web.Mvc;

namespace _5204_mypassion_project_n1010101010
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

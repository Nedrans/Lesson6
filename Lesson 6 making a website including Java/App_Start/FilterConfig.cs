using System.Web;
using System.Web.Mvc;

namespace Lesson_6_making_a_website_including_Java
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

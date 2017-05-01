using Mvc_5_Empty_Template2.Infrastructure;

namespace Mvc_5_Empty_Template2.App_Start
{
    public class FilterConfig
    {
        public static void Configure(System.Web.Mvc.GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

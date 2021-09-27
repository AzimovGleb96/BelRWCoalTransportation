using System.Web;
using System.Web.Mvc;

namespace WebDolomit
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            //глобальный фильтр на авторизацию
            filters.Add(new AuthorizeAttribute());
        }
    }
}

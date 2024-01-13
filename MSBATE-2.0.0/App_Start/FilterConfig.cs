using System.Web;
using System.Web.Mvc;

namespace MSBATE_2._0._0
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}

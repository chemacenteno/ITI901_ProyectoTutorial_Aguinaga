using System.Web;
using System.Web.Mvc;

namespace ITI901_ProyectoTutorial_Aguinaga
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}

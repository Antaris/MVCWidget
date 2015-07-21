using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace MVCWidget
{
	public static class HtmlHelperExtensions
	{
		public static IHtmlString Component(this HtmlHelper helper, string name)
		{
			string controller = name, action = null;

			switch (name.ToLower())
			{
				case "contactus":
					action = "Form";
					break;
				default:
					return MvcHtmlString.Create("Sorry, that component does not exist.");
			}

			return helper.Action(action, controller, new
			{
				// Pass context data - such as the current page, etc?
			});
		}
	}
}

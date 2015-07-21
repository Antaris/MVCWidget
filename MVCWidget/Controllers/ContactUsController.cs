using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCWidget.Models;

namespace MVCWidget.Controllers
{
    public class ContactUsController : Controller
    {
		public PartialViewResult Form()
		{
			return PartialView("Form", new ContactUsViewModel());
		}

		[HttpPost]
		public PartialViewResult Form(ContactUsViewModel model)
		{
			if (ModelState.IsValid)
			{
				// Do something here with form.
				return PartialView("FormSaved", model);
			}

			return PartialView("Form", model);
		}
    }
}
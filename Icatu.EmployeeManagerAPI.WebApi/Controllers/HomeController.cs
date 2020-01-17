using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Icatu.EmployeeManagerAPI.WebApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() {
            return Redirect("http://localhost:63362/swagger");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace YWF.CAPTCHA.Controllers
{
    public class WidgetController : Controller
    {
        public ActionResult GetCaptcha()
        {
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevLaboratory.Models.FormBO.ContractModel;

namespace DevLaboratory.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ContractBO<ContractBOInformations> test = new ContractBO<ContractBOInformations>();
            test.LoadAttributesFromDbWithUuid("");
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}
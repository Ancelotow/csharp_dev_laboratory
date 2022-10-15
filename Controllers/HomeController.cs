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
        public void test()
        {
            ContractBO<ContractBOInformations> test = new ContractBO<ContractBOInformations>();
            test.LoadAttributesFromDbWithUuid("MON_UUID");
        }
    }
}
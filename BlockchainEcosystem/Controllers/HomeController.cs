using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using BLL;
using BLL.Helper;

namespace BlockchainEcosystem.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {

            var result =  await GraphManager.GetGraphData();
          

            return View(result);

        }

        public async Task<ActionResult> ImportLogo()
        {


            await ETCManager.ImportLogo();


            return View();

        }

    }
}
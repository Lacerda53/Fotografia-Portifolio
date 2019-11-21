using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fotografia.Controllers
{
    
    public class HomeController : Controller
    {
        /*https://livedemo00.template-help.com/wt_64615_v1/ */
        public IActionResult Index()
        {
            return View();
        }
    }
}
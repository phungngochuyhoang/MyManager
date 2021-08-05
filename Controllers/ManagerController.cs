using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Manager.Models;


namespace Manager.Controllers
{
    public class ManagerController: Controller {

        public ManagerController() {
           
        }

        public IActionResult Index()
        {
            var name = "";
            return View();
        }

        public IActionResult Login() 
        {
            return View();
        }
    }
}
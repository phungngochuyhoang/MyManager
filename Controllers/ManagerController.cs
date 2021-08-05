using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Manager.Models;
using Manager.Data;
using Manager.Service;


namespace Manager.Controllers
{
    public class ManagerController: Controller {

         private readonly IAccountService _accountService;
        public ManagerController(IAccountService accountService) {
           _accountService = accountService;
        }

        public IActionResult Index()
        {
        
            return View();
        }

        public IActionResult Login() 
        {
            return View();
        }
    }
}
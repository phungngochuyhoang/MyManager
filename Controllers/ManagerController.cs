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
using Manager.Data.Entities;

namespace Manager.Controllers
{
    public class ManagerController : Controller
    {

        private readonly IAccountService _accountService;
        public ManagerController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        public IActionResult Index()
        {
            var entity = new AccountEntity();

            var model = new AccountModel() {
                AccountName = "Hoang",
                Password = "1"
            };

            entity = model.toEntity(entity);
           var ids = _accountService.GetById(1);

            _accountService.Insert(entity);

            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
    }
}
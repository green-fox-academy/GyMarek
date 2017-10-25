using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankOfSimba.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BankOfSimba.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        [Route("simba")]
        public IActionResult Index()
        {
            var bankAccount = new BankAccount()
            {
                Name = "Simba",
                Balance = 2000.00,
                AnimalType = AnimalType.Lion
            };
            return View(bankAccount);
        }

        [Route("animals")]
        public IActionResult AnimalList()
        {
            BankAccountList bankAccounts = new BankAccountList();
            bankAccounts.Accounts.Add(new BankAccount()
            {
                Name = "Simba",
                Balance = 2000,
                AnimalType = AnimalType.Lion
            });
            bankAccounts.Accounts.Add(new BankAccount()
            {
                Name = "Timon",
                Balance = 1000,
                AnimalType = AnimalType.Meerktas
            });
            bankAccounts.Accounts.Add(new BankAccount()
            {
                Name = "Pumbaa",
                Balance = 5000,
                AnimalType = AnimalType.Boar
            });
            bankAccounts.Accounts.Add(new BankAccount()
            {
                Name = "Rafiki",
                Balance = 4000,
                AnimalType = AnimalType.Baboon
            });
            bankAccounts.Accounts.Add(new BankAccount()
            {
                Name = "Zazu",
                Balance = 3000,
                AnimalType = AnimalType.Hornbill
            });

            return View(bankAccounts);
        }
    }
}

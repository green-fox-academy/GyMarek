using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AlpagaDictionary.Models;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace AlpagaDictionary.Controllers
{
    [Route("/user")]
    public class HomeController : Controller
    {
        Definition definition;
        DefinitionList definitionList;
        User user;
        Users users;

        public HomeController(Definition definition, DefinitionList definitionList, User user, Users users)
        {
            this.definition = definition;
            this.definitionList = definitionList;
            this.user = user;
            this.users = users;
        }

        [HttpPost]
        public IActionResult LoginHandler(User inputUser)
        {
            if (users.UsersList.ContainsKey(user.LoginName))
            {
                return LocalRedirect("/user/" + inputUser);
            }
            else
            {
                return View("Alpaga");
            }
        }

        [HttpGet]
        [Route("/user/{userName}")]
        public IActionResult Alpaga(string userName)
        {
            return View(userName);
        }

        [HttpGet]
        [Route("/user/{userName}/upload")]
        public IActionResult IndexWithForm()
        {
            return View();
        }


        [HttpPost]
        [Route("submit")]
        public IActionResult Alpaga(string definitionName, string definitionDescription)
        {
            definition.DefinitionName = definitionName;
            definition.DefinitonDescription = definitionDescription;
            return RedirectToAction("Alpaga");
        }

        //[HttpGet]
        //[Route("/user/{userName}")]
        //public IActionResult Alpaga()
        //{
        //    return View(definition);
        //}
    }
}
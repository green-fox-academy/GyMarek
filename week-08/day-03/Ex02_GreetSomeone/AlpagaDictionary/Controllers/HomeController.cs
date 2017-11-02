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

        public HomeController(Definition definition, DefinitionList definitionList, User user)
        {
            this.definition = definition;
            this.definitionList = definitionList;
            this.user = user;
        }

        [HttpPost]
        public IActionResult LoginHandler(IFormCollection formCollection)
        {
            if (user.Users.ContainsKey(formCollection["Loginname"]))
            {
                return LocalRedirect("/user/" + formCollection["Loginname"]);
            }
            else
            {
                return Redirect("Login/IndexLogin");
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
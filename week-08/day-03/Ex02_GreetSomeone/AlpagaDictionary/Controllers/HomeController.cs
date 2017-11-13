using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AlpagaDictionary.Models;
using System.IO;
using Microsoft.AspNetCore.Http;
using AlpagaDictionary.Repositories;
using AlpagaDictionary.Services;

namespace AlpagaDictionary.Controllers
{
    [Route("/user")]
    public class HomeController : Controller
    {
        Definition definition;        
        User user;
        DefinitionRepository definitionRepository;
        private UserService userService;

        public HomeController(Definition definition, User user, UserService userService, DefinitionRepository definitionRepository)
        {
            this.definition = definition;            
            this.user = user;
            this.userService = userService;
            this.definitionRepository = definitionRepository; 
            //this.users = users;
        }

        [HttpPost]
        public IActionResult LoginHandler(User userFromForm)
        {
            if (userService.AuthenticateUser(userFromForm.LoginName, userFromForm.Password))
            {
                return LocalRedirect("/user");
            }

            return LocalRedirect("/");
        }

        [HttpGet]
        [Route("/user")]
        public IActionResult Alpaga(string userName)
        {                    

            return View(definitionRepository.GetList());
        }

        [HttpGet]
        [Route("/user/upload")]
        public IActionResult IndexWithForm()
        {
            return View();
        }

        [Route("/user/upload")]
        [HttpPost]
        public IActionResult Add(string definitionName, string definitionDescription)
        {
            definitionRepository.AddDefinition(definitionName,definitionDescription);
            return RedirectToAction("Alpaga");
        }

        [Route("/user/{id}/delete")]
        [HttpPost]
        public IActionResult Delete(int id)
        {
            definitionRepository.DeleteDefinition(id);
            return RedirectToAction("Alpaga");
        }

        [Route("user/{id}/update")]
        [HttpPost]
        public IActionResult Update(int id)
        {
            var definition = definitionRepository.Updating(id);
            return View(definition);
        }

        [Route("user/{id}/edit")]
        [HttpPost]
        public IActionResult Edit(Definition definition)
        {
            definitionRepository.UpdateDefinition(definition);
            return RedirectToAction("Alpaga");
        }

    }
}
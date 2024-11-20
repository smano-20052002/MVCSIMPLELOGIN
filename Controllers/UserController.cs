using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SimpleLoginPage1.Data;
using SimpleLoginPage1.Models;

namespace SimpleLoginPage1.Controllers
{
    public class UserController : Controller{
        private readonly ILogger<UserController> _logger;
        private readonly SMVCDbContext _sMVCDbContext;
        public UserController(ILogger<UserController> logger,SMVCDbContext sMVCDbContext){
            _logger=logger;
            _sMVCDbContext=sMVCDbContext;
        }

        public IActionResult Index(){
            return View();
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Login(LoginViewModel loginCredential){

           var userCredentials= _sMVCDbContext.Users.FirstOrDefault(user=>user.Email==loginCredential.Email);
           if(userCredentials==null){
                ModelState.AddModelError("","Invalid Email");
                return View("Index");
           }
           if(userCredentials.Password==loginCredential.Password){

            return RedirectToAction("Privacy","Home");
           }else{
            ModelState.AddModelError("","Wrong Password");
           }
            return View("Index");


        }
    }
    
}
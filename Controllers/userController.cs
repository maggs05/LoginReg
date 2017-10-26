using Microsoft.AspNetCore.Mvc;
using loginReg.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;


namespace loginReg.Controllers

{
    public class UserController : Controller {
     
        [HttpGet]
        [Route("")]
        public IActionResult Index(){
            
            return View();
        }     
    }

        //registration button...
        [HttpPost]
        [Route("/submit")] 
        public IActionResult submit(Register User)
        {
            if(ModelState.IsValid)
            {

                Register(User);
                
                return RedirectToAction("Success");
            }
            return View("Index");
        
        }

    
}
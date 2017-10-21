using Microsoft.AspNetCore.Mvc;
using System.Linq;
using DbConnection;
using System;
using loginReg.Models;

namespace loginReg {
    public class usersController : Controller {
     
        [HttpGet]
        [Route("")]
        public IActionResult Index(){
            
            return View();
        }

        //registration button...
        [HttpPost]
        [Route("Submit")] 
        public IActionResult Submit(userRegister Register){
            if(ModelState.IsValid){

                // userRegister(Register);
                return RedirectToAction("Success");
            }
            return View("Index");
        }

    }
}
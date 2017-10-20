using Microsoft.AspNetCore.Mvc;
using System.Linq;
// using DbConnection;
using System;

namespace loginReg {
    public class usersController : Controller {
        [HttpGet]
        [Route("")]
        public IActionResult Index(){
            
            return View();
        }

        //registration button...
        [HttpPost]
        [Route("Success")]
        public IActionResult Success(string firstName, string lastName){

            return View("Success");
        }

    }
}
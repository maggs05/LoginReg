using Microsoft.AspNetCore.Mvc;
using loginReg.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;


namespace loginReg.Controllers

{
    public class UserController : Controller {
     
        [HttpGet]
        [Route("")]
        public IActionResult Index(){
            
            return View();
        }     
    }
}
        //registration button...
        // [HttpPost]
        // [Route("submit")] 
    //     public IActionResult submit(userRegister Register){
    //         if(ModelState.IsValid){

    //             // Register(userRegister);
                
    //             return RedirectToAction("Index");
    //         return View("Index");
    //     }

    // }
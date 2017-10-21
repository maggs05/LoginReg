using Microsoft.AspNetCore.Mvc;
using loginReg.Models;

namespace loginReg
{
    public class usersController : Controller {
     
        [HttpGet]
        [Route("")]
        public IActionResult Index(){
            
            return View();
        }

        //registration button...
        [HttpPost]
        [Route("submit")] 
        public IActionResult Submit(userRegister Register){
            if(ModelState.IsValid){

                // userRegister(Register);
                return RedirectToAction("Success");
            }
            return View("Index");
        }

    }
}
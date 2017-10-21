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
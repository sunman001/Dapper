using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test.Repositories;

namespace Web.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            UserRepository userRepository = new UserRepository();
          
             var list=  userRepository.FindPagedList("");
         
            return View();
        }
    }
}
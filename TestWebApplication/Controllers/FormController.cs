using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using TestWebApplication.Models;
using Microsoft.AspNetCore.Identity;

namespace TestWebApplication.Controllers
{
    public class FormController : ApiController
    {
        private readonly UserManager<User> _userManager;

        meetingsContext db = new meetingsContext();


  //      var result = await _userManager.CreateAsync(user, model.Password);

    //    [HttpPost]
        
    }
}
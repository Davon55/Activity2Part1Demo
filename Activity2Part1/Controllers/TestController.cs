using Activity2Part1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Activity2Part1.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            List<UserModel> users = new List<UserModel>();
            users.Add(new UserModel("Donnell", "dondon@gmail.com", "623-333-3333"));
            users.Add(new UserModel("John", "don@gmail.com", "623-444-3333"));
            users.Add(new UserModel("Sam", "longjohn@gmail.com", "623-331-3898"));

            return View("Test",users);
        }
    }
}

using Activity2Part1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Activity2Part1.Controllers
{
    public class ButtonController : Controller
    {
        List<ButtonModel> buttons = new List<ButtonModel>();
        public IActionResult Index()
        {
            buttons.Add(new ButtonModel(true));
            buttons.Add(new ButtonModel(false));
            
            return View("Button", buttons);
        }
        public IActionResult OnButtonClick(string mine)
        {
            if(mine == "1")
            {
                buttons.Add(new ButtonModel(true));
            }
            else if (mine == "2")
            {
                buttons.Add(new ButtonModel(false));
            }
            return View("Button", buttons);
        }
    }
}

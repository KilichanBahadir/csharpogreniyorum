using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace works26.Controllers
{
    public class ToDoItems : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

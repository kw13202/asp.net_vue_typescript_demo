using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace OptionBindSample2.Controllers
{
    public class HomeController : Controller
    {
        private readonly Class _myClass;

        public HomeController(IOptions<Class> classOption)
        {
            _myClass = classOption.Value;
        }

        public IActionResult Index()
        {
            return View(_myClass);
        }

        public IActionResult Index2()
        {
            return View();
        }

    }
}
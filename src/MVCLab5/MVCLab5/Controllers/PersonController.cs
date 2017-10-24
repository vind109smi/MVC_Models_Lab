using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCLab5.Models;

namespace MVCLab5.Controllers
{

    public class PersonController : Controller
    {
        private static List<Person> persons = new List<Person>();
        public IActionResult Index()
        {
            return View(persons);
        }

        public IActionResult AddPerson()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPerson(Person p)
        {
            if(ModelState.IsValid)
            {
                persons.Add((p));
                return View("ViewPerson", p);
            }
            else
            {
                return View();
            }
        }

        public IActionResult ViewPerson(Person p)
        {
            return View(p);
        }

    }
};
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UniApp.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UniApp.Controllers
{
    public class StudentController : Controller
    {

        public IActionResult Index()
        {
            StudentIndexViewModel vm = new StudentIndexViewModel
            {
                Students = Data.Students,
                Groups = Data.Groups
            };








            return View(vm);
        }
        public IActionResult Detail(int id)
        {
            var stu = Data.Students.Find(x => x.Id == id);

            if (stu==null)
            
              return  View("error");
            

            StudentIndexViewModel vm = new StudentIndexViewModel
            {
                Student = stu,  
            Groups= Data.Groups
            };

            return View(vm);


        }
    }
}


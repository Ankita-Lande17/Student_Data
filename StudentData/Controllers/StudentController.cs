using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Caching.Memory;
using StudentData.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentData.Controllers
{
    public class StudentController : Controller
    {
        static List<Student> studentList = new List<Student>
        {
            new Student() {
                Roll = 1,
                Name = "Ankita",
                Age = 13,
                Address = "Pune",
            },
            new Student() {
                Roll = 2,
                Name = "Sayali",
                Age = 12,
                Address = "Sangli",
            },
            new Student() {
                Roll = 3,
                Name = "Nikita",
                Age = 13,
                Address = "Mumbai",
            },
            new Student() {
                Roll = 4,
                Name = "Prashant",
                Age = 14,
                Address = "Chandigad",
            },
        };

        public IActionResult Insert()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Insert(Student st)
        {
            studentList.Add(st);
            return RedirectToAction("StudentDetail");
        }
        public IActionResult StudentDetail()
        {

            return View(studentList.OrderBy(s => s.Roll).ToList());

        }



        public IActionResult Edit(int id)
        {

            var s = studentList.Where(s => s.Roll == id).FirstOrDefault();
            return View(s);
        }

        [HttpPost]
        public IActionResult Edit(Student st)
        {
            var student = studentList.Where(student => student.Roll == st.Roll).FirstOrDefault();
            studentList.Remove(student);
            studentList.Add(st);
            return RedirectToAction("StudentDetail");
        }


        public IActionResult Delete(int id)
        {

            var s = studentList.Where(s => s.Roll == id).FirstOrDefault();
            return View(s);
        }
        [HttpPost]
        public IActionResult Delete(Student st)
        {
            var student = studentList.Where(student => student.Roll == st.Roll).FirstOrDefault();
            studentList.Remove(student);
            return RedirectToAction("StudentDetail");
        }
    }
}

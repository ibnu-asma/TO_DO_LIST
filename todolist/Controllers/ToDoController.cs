using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using todolist.data;
using todolist.Models;

namespace todolist.Controllers
{
    public class ToDoController : Controller
    {
        private readonly ToDoDbContext context;
        public ToDoController(ToDoDbContext _context)
        {
            context = _context;
        }
         public IActionResult Index() {
            IEnumerable<ToDoList> obList = context.ToDoList;
            return View(obList);
        }
        public IActionResult Create()
        {
         
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ToDoList _obj)
        {
            context.ToDoList.Add(_obj);
            context.SaveChanges();

            return RedirectToAction("Index");
        }







    }
}

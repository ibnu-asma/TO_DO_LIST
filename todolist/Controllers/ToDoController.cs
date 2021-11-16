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
        public ToDoController(ToDoDbContext context)
        {
            this.context = context;
        }
        public async Task<ActionResult> Index()
        {
            IQueryable<ToDoList> items = from i in context.ToDoList orderby i.Id select i;
            List<ToDoList> todolist = await items.ToListAsync();
            return View(todolist);
        }
        public IActionResult Create() => View();
    }
}

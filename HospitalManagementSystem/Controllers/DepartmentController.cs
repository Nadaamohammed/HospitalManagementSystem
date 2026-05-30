using HospitalManagementSystem.Models.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagementSystem.Controllers
{
    [Authorize(Roles = "Admin")]
    public class DepartmentController : Controller
    {
        private readonly HospitalDbContext _context;

        public DepartmentController(HospitalDbContext context)
        {
            _context = context;
        }
        // GET: DepartmentControllers
        public async Task<IActionResult> Index()
        {
            var departments = await _context.Departments.ToListAsync(); // <- error here
            return View(departments);
        }

        public IActionResult Create()
        {
            return View();
        }

        // POST: Department/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Department department)
        {
            if (ModelState.IsValid)
            {
                _context.Departments.Add(department);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View(department);
        }
    }
}

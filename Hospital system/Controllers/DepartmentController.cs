using Hospital_system.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hospital_system.Controllers
{
    public class DepartmentController : Controller
    {
        AppdbContext db = new AppdbContext();
        public IActionResult AllDpartment()
        {
            var AllDepartment = db.Departments.Include(d => d.Doctors).ToList();
            return View(AllDepartment);
        }
        public IActionResult Details(int id)
        {
            var department = db.Departments.Include(d => d.Doctors).FirstOrDefault(d => d.DepartmentID == id);
            return View(department);
        }
    }
}

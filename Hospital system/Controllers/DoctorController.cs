using Hospital_system.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hospital_system.Controllers
{
    public class DoctorController : Controller

    {
        AppdbContext db = new AppdbContext();
        public IActionResult AllDoctors()
        {
            var doctors = db.Doctors.Include(d => d.Department).ToList();
            return View(doctors);
        }

        public IActionResult Details(int id)
        {
            var doctor = db.Doctors.Include(d => d.Department).FirstOrDefault(d => d.DoctorID == id);
            return View(doctor);
        }
    }
}

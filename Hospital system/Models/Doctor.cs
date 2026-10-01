using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital_system.Models
{
    public class Doctor
    {
    
            public int DoctorID { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public decimal Salary { get; set; }
            public string Image { get; set; }

            [ForeignKey("DepartmentID")]
            public int DepartmentID { get; set; }
            public Department Department { get; set; }
        
    }
}

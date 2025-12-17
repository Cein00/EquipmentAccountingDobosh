using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDobosh.DAL.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public string HeadOfDepartment { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}

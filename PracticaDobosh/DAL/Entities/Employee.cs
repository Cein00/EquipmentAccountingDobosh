using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDobosh.DAL.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string FIO { get; set; }
        public string Position { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public ICollection<Equipment> ResponsibleEquipment { get; set; }
        public ICollection<MovementHistory> OldMovements { get; set; }
        public ICollection<MovementHistory> NewMovements { get; set; }
        
    }
}

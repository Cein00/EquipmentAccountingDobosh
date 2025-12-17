using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDobosh.DAL.Entities
{
    public class MovementHistory
    {
        public int Id { get; set; }
        public DateTime MovementDate { get; set; }
        public string EquipmentInventoryNumber { get; set; }
        public int? OldEmployeeId { get; set; } 
        public int NewEmployeeId { get; set; }
        public Equipment Equipment { get; set; }
        public Employee OldEmployee { get; set; }
        public Employee NewEmployee { get; set; }
    }
}

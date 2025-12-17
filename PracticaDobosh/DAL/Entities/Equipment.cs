using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDobosh.DAL.Entities
{
    public class Equipment
    {
        public string InventoryNumber { get; set; }
        public string EquipmentName { get; set; }
        public string SerialNumber { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Status { get; set; }
        public int TypeId { get; set; }
        public int EmployeeId { get; set; }
        public EquipmentType EquipmentType { get; set; }
        public Employee ResponsibleEmployee { get; set; }
        public ICollection<InstalledSoftware> InstalledSoftware { get; set; }
        public ICollection<MovementHistory> MovementHistory { get; set; }
    }
}

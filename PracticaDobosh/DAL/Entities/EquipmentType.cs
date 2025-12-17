using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDobosh.DAL.Entities
{
    public class EquipmentType
    {
        public int Id { get; set; }
        public string EquipmentTypeName { get; set; }

        public ICollection<Equipment> Equipments { get; set; }
    }
}

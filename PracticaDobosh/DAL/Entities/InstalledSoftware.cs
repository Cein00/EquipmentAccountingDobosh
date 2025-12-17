using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDobosh.DAL.Entities
{
    public class InstalledSoftware
    {
        public string EquipmentInventoryNumber { get; set; }
        public int LicenseId { get; set; }

        public DateTime InstallonDate { get; set; }
        public Equipment Equipment { get; set; }
        public SoftwareLicenses License { get; set; }
    }
}

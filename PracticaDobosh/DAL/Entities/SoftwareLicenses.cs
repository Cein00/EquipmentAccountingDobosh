using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDobosh.DAL.Entities
{
    public class SoftwareLicenses
    {
        public int Id { get; set; }
        public string SoftwareName { get; set; }
        public string Manufacturer { get; set; }
        public string LicenseKey { get; set; }
        public DateTime? EndDate { get; set; }
        public ICollection<InstalledSoftware> InstalledSoftware { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyInventory.Data
{
    class Vendor
    {
        [Key]
        public int VendorId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string ActNumber { get; set; }

        public string SalesRep { get; set; }

        public string SalesRepPhoneNumber { get; set; }

        [Required]
        public string VendorPhoneNumber { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string DeliveryType { get; set; }

        public int EstimatedLeadTime { get; set; }
    }
}

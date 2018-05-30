using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyInventory.Models
{
    public class VendorListItem
    {
        public int VendorId { get; set; }

        [Display(Name = "Vendor Name :")]
        public string Name { get; set; }

        [Display(Name = "Act Number :")]
        public string ActNumber { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}


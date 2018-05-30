using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyInventory.Models
{
   public class DrugListItem
    {

        public string Name { get; set; }
        public string NDC { get; set; }
        public string Manufacturer { get; set; }
        public string Vendor { get; set; }

        [Display(Name = "Reorder Number")]
        public string ReOrderNumber { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}




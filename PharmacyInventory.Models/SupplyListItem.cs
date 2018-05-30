using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyInventory.Models
{
   public class SupplyListItem
    {

        public string CustomInventoryNumber { get; set; }

        public string Name { get; set; }

        public string Vendor { get; set; }

        public string ReOrderNumber { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}


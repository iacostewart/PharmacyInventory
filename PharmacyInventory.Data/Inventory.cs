using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyInventory.Data
{
   public class Inventory
    {
        [Key]
        public int InventoryId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public bool Drug { get; set; }

        [Required]
        public bool Supply { get; set; }

        [Required]
        public bool RoomTemp { get; set; }

        [Required]
        public bool Refigerator { get; set; }

        [Required]
        public string Vendor { get; set; }

        [Required]
        public int Quanity { get; set; }

        [Required]
        public string EachesCases { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyInventory.Data
{
    class Equipment
    {
        [Key]
        public int EquipmentId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Manufacture { get; set; }

        [Required]
        public string SerialNumber { get; set; }

        [Required]
        public bool InStock { get; set; }

        public bool? NeedsPm { get; set; }

        public bool? LostOrBroken { get; set; }

        [Required]
        public string PurchaseDate { get; set; }


        public string LastCalibration { get; set; }

    }
}

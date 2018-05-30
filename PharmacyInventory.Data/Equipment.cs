using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyInventory.Data
{
  public class Equipment
    {
        [Key]
        public int EquipmentId { get; set; }

        [Required]
        [Display(Name = "Name :")]
        public string Name { get; set; }

        [Required]
        [Display(Name ="Manufacture ")]
        public string Manufacture { get; set; }

        [Required]
        [Display(Name = "SSN #")]
        public string SerialNumber { get; set; }

        [Required]
        [Display(Name = "In Stock")]
        public bool InStock { get; set; }

        [Display(Name = "PM Over Due ")]
        public bool? NeedsPm { get; set; }

        [Display(Name = "Lost or Broken " )]
        public bool? LostOrBroken { get; set; }

        [Required]
        [Display(Name = "Purchase Date :")]
        public string PurchaseDate { get; set; }

        [Display(Name = "Date of Last Calibration ")]
        public string LastCalibration { get; set; }

    }
}

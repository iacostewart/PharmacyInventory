using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyInventory.Data
{
   public class Drug
    {
        [Key]
        public int DrugId { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage ="There are too many characters in this field.")]
        [Display(Name = "Name :")]
        public string Name { get; set; }

        [Required]

        [MaxLength(13, ErrorMessage = "There are too many characters in this field.")]
        [Display(Name = "NDC :")]
        public string NDC { get; set; }

        [Required]
        [Display]
        public string LotNumber  { get; set; }

        [Required]
        [MaxLength(10, ErrorMessage = "There are too many characters in this field.")]
        [Display]
        public string ExpirationDate { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "There are too many characters in this field.")]
        [Display]
        public string Manufacturer { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "There are too many characters in this field.")]
        [Display]
        public string Vendor { get; set; }

        [Required]
        [MaxLength(15, ErrorMessage = "There are too many characters in this field.")]
        [Display]
        public string ReOrderNumber { get; set; }

        [Display]
        public bool? Each { get; set; }

        [Display]
        public bool? Case { get; set; }

        [Display(Name = "Last Purchase Price")]
        public int LastPurchasePrice { get; set; }

        [Display(Name = "Last Purchase Date")]
        public string LastPurchaseDate { get; set; }

        [MaxLength(10, ErrorMessage = "There are too many characters in this field.")]
        [Display(Name = "Last Quantity Purchased ")]
        public string LastPurchaseQuanity { get; set; }

        [MaxLength(10, ErrorMessage = "There are too many characters in this field.")]
        [Display(Name = "Custom inventory Number: ")]
        public string CustomInventoryNumber { get; set; }

        [Required]
        [Display]
        public bool CII { get; set; }

        [Required]
        [Display(Name = "Added To Inventory")]
        public DateTimeOffset CreatedUtc { get; set; }


        public DateTimeOffset? ModifiedUtc { get; set; }

        [MaxLength(10, ErrorMessage = "There are too many characters in this field.")]
        [Display(Name = "Created By ")]
        public string CreatedBy { get; set; }
    }
}

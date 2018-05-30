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
        public string Name { get; set; }

        [Required]
        public string NDC { get; set; }

        [Required]
        public string LotNumber  { get; set; }

        [Required]
        public string ExpirationDate { get; set; }

        [Required]
        public string Manufacturer { get; set; }

        [Required]
        public string Vendor { get; set; }


        public string? ReOrderNumber { get; set; }

        public bool? Each { get; set; }

        public bool? Case { get; set; }

        public int? LastPurchasePrice { get; set; }

        public string? LastPurchaseDate { get; set; }

        public string? LastPurchaseQuanity { get; set; }

        public string? CustomInventoryNumber { get; set; }

        [Required]
        public bool CII { get; set; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }

        public string? CreatedBy { get; set; }
    }
}

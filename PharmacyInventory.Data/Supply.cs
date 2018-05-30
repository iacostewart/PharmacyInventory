using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyInventory.Data
{
  public  class Supply
    {

        [Key]
        public int SupplyNumber { get; set; }

        [Required]
        public string Name { get; set; }


        public string LotNumber { get; set; }


        public string ExpirationDate { get; set; }

        [Required]
        public string Vendor { get; set; }

        [Required]
        public string ReOrderNumber { get; set; }

        [Required]
        public int PriceEach { get; set; }

        [Required]
        public int PriceCase { get; set; }

        public string LastOrderDate { get; set; }

        [Required]
        public string ParLevelMin { get; set; }

        [Required]
        public string ParLevelMax { get; set; }

        [Required]
        public string StorageLocation { get; set; }

        [Required]
        public string CustomInventoryNumber { get; set; }

        public string LastDispensed { get; set; }




    }
}

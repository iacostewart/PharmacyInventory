using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyInventory.Models
{
   public class CenterCreate
    {
        [Required]
        public string CenterName { get; set; }

        [Required]
        public string CenterAddress { get; set; }

        [Required]
        public string CenterManager { get; set; }

        [Required]
        public string RegionNumber { get; set; }

        [Required]
        public int CenterNumber { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

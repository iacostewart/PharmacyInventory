using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyInventory.Data
{
    public class RegionalManager
    {
        [Key]
        public int managerId { get; set; }

        [Required]
        public int RegionalNumber { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string OutSideEmail { get; set; }

        [Required]
        public string CellPhoneContractNumber { get; set; }

        [Required]
        public int TravelExpenses { get; set; }
    }
}

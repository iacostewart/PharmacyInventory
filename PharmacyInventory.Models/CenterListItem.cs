using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyInventory.Models
{
    public class CenterListItem
    {

        [Display(Name ="Center Name")]
        public string CenterName { get; set; }

        [Display(Name = "Center Number :")]
        public int CenterNumber { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}



using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyInventory.Models
{
   public class RegionalManagerListItem
    {
        [Display(Name = "Region #")]
        public int RegionalNumber { get; set; }

        public string Name { get; set; }

        [Display(Name ="Email Address")]
        public int OutSideEmail { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }   
}


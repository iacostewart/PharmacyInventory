using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyInventory.Models
{
   public class VendorCreate
    {
        
        [Required]
        [Display]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Account Number :")]
        public string ActNumber { get; set; }

        [Display(Name = "Name of Sales Rep :")]
        public string SalesRep { get; set; }

        [Display(Name = "Sales Rep Phone Number: ")]
        public string SalesRepPhoneNumber { get; set; }

        [Required]
        [Display(Name = "Vendor Phone Number")]
        public string VendorPhoneNumber { get; set; }

        [Required]
        [Display(Name = "Street Address  Street,City,State, Zip")]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Delivery Type, Ups..Fedex.. courier etc.. ")]
        public string DeliveryType { get; set; }

        [Display(Name = "Estimated Lead Time ")]
        public int EstimatedLeadTime { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
   
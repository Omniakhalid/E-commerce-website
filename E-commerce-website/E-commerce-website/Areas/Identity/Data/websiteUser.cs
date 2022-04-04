using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace E_commerce_website.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the websiteUser class
    public enum UserType
    {
        Vendor, User , Admin
    }

    
    public class websiteUser : IdentityUser
    {
        [Required]
        [StringLength(50)]
        public string UserFirstName { get; set; }
        
        [Required]
        [StringLength(10)]
        public string UserCity { get; set; }
        public string UserPhone { get; set; }
      
        [Required]
        [StringLength(100)]
        public string UserAddress { get; set; }

        
        public UserType type { get; set; }

    }
}

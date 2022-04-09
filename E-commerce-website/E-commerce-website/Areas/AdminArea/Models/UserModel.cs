using System.Collections.Generic;

namespace E_commerce_website.Areas.AdminArea.Models
{
    
    public class UserModel
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        
        public IEnumerable<string> Roles { get; set; }
    }
}

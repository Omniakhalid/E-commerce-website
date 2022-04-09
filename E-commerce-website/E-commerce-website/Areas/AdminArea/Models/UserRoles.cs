using System.Collections.Generic;

namespace E_commerce_website.Areas.AdminArea.Models
{
    public class UserRoles
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public List<RoleViewModel> Roles { get; set; }

    }
}

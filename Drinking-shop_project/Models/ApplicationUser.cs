using Microsoft.AspNetCore.Identity;

namespace Drinking_shop_project.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string User_Name { get; set; }
    }
}

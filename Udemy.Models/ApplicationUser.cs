using Microsoft.AspNetCore.Identity;

namespace Udemy.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string FLastName { get; set; }
    }
}

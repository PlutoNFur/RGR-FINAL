using Microsoft.AspNetCore.Identity;

namespace RGR_FINAL.Data.Identity
{
    public class ApplicationIdentityUser : IdentityUser
    {
        public  long ApplicationId { get; set; }
    }
}

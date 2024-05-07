using Microsoft.AspNetCore.Identity;

namespace DungeonsAndDragons_ToolAndBuilder.Client.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string? NickName { get; set; }
    }

}

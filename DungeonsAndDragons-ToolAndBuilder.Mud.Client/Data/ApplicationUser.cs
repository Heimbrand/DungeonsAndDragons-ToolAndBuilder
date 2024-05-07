using Microsoft.AspNetCore.Identity;

namespace DungeonsAndDragons_ToolAndBuilder.Mud.Client.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public int NickName { get; set; }
    }

}

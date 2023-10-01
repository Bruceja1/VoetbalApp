using Microsoft.AspNetCore.Identity;

namespace VoetbalApp.Models
{
    public class Player : IdentityUser
    {
        public int? TeamId { get; set; }
        public Team? Team { get; set; }
        
    }
}

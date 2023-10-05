using Microsoft.AspNetCore.Identity;

namespace VoetbalApp.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<IdentityUser> Players { get; set; } = new List<IdentityUser>();
        public IdentityUser? TeamLeader { get; set; }
        public string? TeamLeaderId { get; set; }

        public Team()
        {
            Players = new List<IdentityUser>();
        }
    }
}

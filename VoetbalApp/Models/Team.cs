using Microsoft.AspNetCore.Identity;

namespace VoetbalApp.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Player> Players { get; set; }       
        public Player TeamLeader { get; set; }
        public int TeamLeaderId { get; set; }

    }
}

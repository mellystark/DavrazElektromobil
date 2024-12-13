namespace DavrazElektromobil.Models
{
    public class HomeViewModel
    {
        public string Quote { get; set; }
        public string Author { get; set; }
        public string IntroText { get; set; }
        public string AboutText { get; set; }
        public List<TeamMember> TeamMembers { get; set; }
    }
}

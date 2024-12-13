using DavrazElektromobil.Models;
using Microsoft.EntityFrameworkCore;

public class CommunityDbContext : DbContext
{
    public CommunityDbContext(DbContextOptions<CommunityDbContext> options) : base(options) { }

    public DbSet<TeamMember> TeamMembers { get; set; }
    public DbSet<Gallery> Gallery { get; set; }
    public DbSet<Sponsorship> Sponsorships { get; set; }
    public DbSet<ContactMessage> ContactMessages { get; set; }
}

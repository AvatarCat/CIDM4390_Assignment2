using Microsoft.EntityFrameworkCore;
using CodingClubMembers.Models;

namespace CodingClubMembers.Data
{
    public class CodingClubMembersContext : DbContext
    {
        public CodingClubMembersContext (
            DbContextOptions<CodingClubMembersContext> options)
            : base(options)
        {
        }

        public DbSet<CodingClubMembers.Models.Member> Member { get; set; }

        public DbSet<CodingClubMembers.Models.Client> Client { get; set; }
    }
}
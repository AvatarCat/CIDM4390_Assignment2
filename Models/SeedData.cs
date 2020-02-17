using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CodingClubMembers.Data;
using System;
using System.Linq;

namespace CodingClubMembers.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CodingClubMembersContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<CodingClubMembersContext>>()))
            {
                // Look for any members.
                if (context.Member.Any())
                {
                    return;   // DB has been seeded
                }
                // Look for any clients.
                if (context.Client.Any())
                {
                    return;   // DB has been seeded
                }

                context.Member.AddRange(
                    new Member
                    {
                        FName = "Sally",
                        LName = "Johnston",
                        Email = "sallyjohnston@test.com",
                        JoinDate = DateTime.Parse("2015-2-12")
                    },

                    new Member
                    {
                        FName = "Fred",
                        LName = "Weasly",
                        Email = "frednomore@test.com",
                        JoinDate = DateTime.Parse("2018-9-25")
                    },

                    new Member
                    {
                        FName = "George",
                        LName = "Weasly",
                        Email = "georgetheholy@test.com",
                        JoinDate = DateTime.Parse("2018-9-25")
                    },

                    new Member
                    {
                        FName = "Rick",
                        LName = "Vader",
                        Email = "thedarkside@test.com",
                        JoinDate = DateTime.Parse("2017-10-31")
                    }
                );

                context.Client.AddRange(
                    new Client
                    {
                        CName = "WTAMU",
                        Email = "wtamu@wtamu.com",
                        Number = "8066557348"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CodingClubMembers.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CodingClubMembers.Pages_Members
{
    public class IndexModel : PageModel
    {
        private readonly CodingClubMembers.Data.CodingClubMembersContext _context;

        public IndexModel(CodingClubMembers.Data.CodingClubMembersContext context)
        {
            _context = context;
        }

        public IList<Member> Member { get;set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList FNames { get; set; }
        [BindProperty(SupportsGet = true)]
    public string MemberName { get; set; }

        public async Task OnGetAsync()
        {
            var members = from m in _context.Member
                 select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                members = members.Where(s => s.FName.Contains(SearchString));
            }
            Member = await members.ToListAsync();
        }
    }
}

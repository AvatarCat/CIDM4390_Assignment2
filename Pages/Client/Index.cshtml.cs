using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CodingClubMembers.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CodingClubMembers.Pages_Client
{
    public class IndexModel : PageModel
    {
        private readonly CodingClubMembers.Data.CodingClubMembersContext _context;

        public IndexModel(CodingClubMembers.Data.CodingClubMembersContext context)
        {
            _context = context;
        }

        public IList<Client> Client { get;set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList CNames { get; set; }
        [BindProperty(SupportsGet = true)]
        public string ClientCompany { get; set; }

        public async Task OnGetAsync()
        {
            var clients = from m in _context.Client
                 select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                clients = clients.Where(s => s.CName.Contains(SearchString));
            }

            Client = await clients.ToListAsync();
        }
    }
}

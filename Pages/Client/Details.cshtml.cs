using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CodingClubMembers.Data;
using CodingClubMembers.Models;

namespace CodingClubMembers.Pages_Client
{
    public class DetailsModel : PageModel
    {
        private readonly CodingClubMembers.Data.CodingClubMembersContext _context;

        public DetailsModel(CodingClubMembers.Data.CodingClubMembersContext context)
        {
            _context = context;
        }

        public Client Client { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Client = await _context.Client.FirstOrDefaultAsync(m => m.ID == id);

            if (Client == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

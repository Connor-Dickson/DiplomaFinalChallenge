using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FinalChallenge.Data;
using FinalChallenge.Models;
using Microsoft.AspNetCore.Authorization;

namespace FinalChallenge
{
    
    public class CreateModel : PageModel
    {
        private readonly FinalChallenge.Data.FinalChallengeContext _context;

        public CreateModel(FinalChallenge.Data.FinalChallengeContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            if(User.Identity.Name == "admin@admin.com")
            {
                return Page();
            }
            return RedirectToPage("./Index");
        }

        [BindProperty]
        public Game Game { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Game.Add(Game);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

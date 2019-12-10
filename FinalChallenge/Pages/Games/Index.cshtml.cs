using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FinalChallenge.Data;
using FinalChallenge.Models;
using Microsoft.AspNetCore.Authorization;

namespace FinalChallenge
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly FinalChallenge.Data.FinalChallengeContext _context;

        public IndexModel(FinalChallenge.Data.FinalChallengeContext context)
        {
            _context = context;
            getTotal();
        }

        public IList<Game> Game { get;set; }
        public decimal Total = 0;

        
        public decimal getTotal()
        {
            Total = _context.Game.Sum(g => g.amtPaid);
            return Total;
        }

        public async Task OnGetAsync()
        {
            string routeAddress = (string)this.RouteData.Values["action"];
            bool flag = this.Request.QueryString.Value.Contains("future");

            if (!flag)
            {
                Game = await _context.Game.Where<Game>(g => g.dateTime < DateTime.Now).ToListAsync();
            }
            else
            {
                Game = await _context.Game.Where<Game>(g => g.dateTime > DateTime.Now).ToListAsync();
            }
        }
    }
}

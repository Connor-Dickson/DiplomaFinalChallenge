using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FinalChallenge.Models;

namespace FinalChallenge.Data
{
    public class FinalChallengeContext : DbContext
    {
        public FinalChallengeContext (DbContextOptions<FinalChallengeContext> options)
            : base(options)
        {
        }

        public DbSet<FinalChallenge.Models.Game> Game { get; set; }
    }
}

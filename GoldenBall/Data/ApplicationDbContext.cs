using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using GoldenBall.Models;

namespace GoldenBall.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<GoldenBall.Models.Club> Clubs { get; set; }

        public DbSet<GoldenBall.Models.Player> Players { get; set; }
    }
}

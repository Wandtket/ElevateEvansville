﻿using ElevateEvansville_API.Models;
using Microsoft.EntityFrameworkCore;

namespace ElevateEvansville_API
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Balances> Balances { get; set; }

        public DbSet<Transactions> Transactions { get; set;  }

        public DatabaseContext(DbContextOptions options) : base(options) { }
    }
}

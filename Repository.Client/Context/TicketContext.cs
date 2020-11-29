using Microsoft.EntityFrameworkCore;
using Repository.Client.Helpers;
using Repository.Client.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Client.Context
{
    public class TicketContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string strConnection = Config.GetConnectionString("TicketingDb");
            optionsBuilder.UseSqlServer(strConnection);
        }

        public DbSet<Ticket> Tickets { get; set; }
    }
}

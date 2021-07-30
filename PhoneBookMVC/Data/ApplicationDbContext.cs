using Microsoft.EntityFrameworkCore;
using PhoneBookMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBookMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) 
            : base(options)
        {
        }
        public DbSet<Contact> Contacts { get; set; }
    }
}

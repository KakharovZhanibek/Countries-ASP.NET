namespace WebApplication1
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using WebFormsEmpty.Models;

    public class Context : DbContext
    {
      
        public Context()
            : base("name=MyDB")
        {
        }

        public DbSet<Country> Country { get; set; }
      
    }


}
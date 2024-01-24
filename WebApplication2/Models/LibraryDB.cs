using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class LibraryDB:DbContext
    {
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Book> Books { get; set; }

        public DbSet<UserInfo> Users { get; set; }

        public LibraryDB() : base("MyJanuaryexamLibrarydb2")
        {

        }
    }
}
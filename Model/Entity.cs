using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace DbCreate
{
    public class Users
    {
        [Key]
        [JsonIgnore]
        public int Id { set; get; }
        public string User { set; get; }
        public string Password { set; get; }
    }

    public class DbCreateContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbCreateContext(DbContextOptions<DbCreateContext> options) : base(options) { }

    }
}
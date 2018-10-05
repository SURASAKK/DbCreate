using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace DbCreate
{
    public class Manager
    {
        [Key]
        [JsonIgnore]
        public int Id_Manager { set; get; }
        public string Manager_name { set; get; }
        public string Telephone { set; get; }
        public string Username { set; get; }
        public string M_Password { set; get; }
    }
    public class Users
    {
        [Key]
        [JsonIgnore]
        public int Id_User { set; get; }
        public string User_name { set; get; }
        public string Email { set; get; }
        public string Telephone { set; get; }
        public string Address { set; get; }
        public string User_Name { set; get; }
        public string User_Password { set; get; }
        public string Gender { set; get; }
    }

    public class Selling
    {
        [Key]
        public string Id_Sell { set; get; }
        public DateTime Date_Sell { set; get; }
        public string Id_User { set; get; }
        public string Id_Product { set; get; }
    }

    public class Product
    {
        [Key]
        public string Id_Product { set; get; }
        public string ProductName { set; get; }
        public string image { set; get; }
        public int count { set; get; }
        public float cost { set; get; }

    }
    public class DbCreateContext : DbContext
    {
        public DbSet<Manager> Managers { set; get; }
        public DbSet<Users> Users { set; get; }
        public DbSet<Selling> Selles { set; get; }
        public DbSet<Product> Products { set; get; }

        public DbCreateContext(DbContextOptions<DbCreateContext> options) : base(options) { }

    }
}
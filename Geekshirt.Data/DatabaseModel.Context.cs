﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Geekshirt.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DatabaseEntities : DbContext
    {
        public DatabaseEntities()
            : base("name=DatabaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<UserData> UserData { get; set; }
        public virtual DbSet<UserLogIn> UserLogIn { get; set; }
        public virtual DbSet<Articles> Articles { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<ShopLists> ShopLists { get; set; }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalProject1.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LocalDatabaseEntities1 : DbContext
    {
        public LocalDatabaseEntities1()
            : base("name=LocalDatabaseEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Detail> Details { get; set; }
        public virtual DbSet<Header> Headers { get; set; }
        public virtual DbSet<Meat> Meats { get; set; }
        public virtual DbSet<Ramen> Ramen1 { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}

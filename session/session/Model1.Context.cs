﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace session
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Абоненты_КалмыковEntities : DbContext
    {
        public Абоненты_КалмыковEntities()
            : base("name=Абоненты_КалмыковEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
        public DbSet<Абонент> Абонент { get; set; }
        public DbSet<Разговоры> Разговоры { get; set; }
        public DbSet<Тариф> Тариф { get; set; }
        public DbSet<Телефон> Телефон { get; set; }
    }
}

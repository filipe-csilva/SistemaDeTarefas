﻿using Microsoft.EntityFrameworkCore;
using ApiDeTarefas.Data.Map;
using ApiDeTarefas.Models;

namespace ApiDeTarefas.Data
{
    public class SystemContext : DbContext
    {
        public SystemContext(DbContextOptions<SystemContext> options) : base(options)
        {
        }

        public DbSet<TaskMd> Tasks { get; set; }
        public DbSet<UserMd> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new TaskMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}

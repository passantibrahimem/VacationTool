using Domain;
using Domain.EmployeeAggregate;
using Domain.VacationAggregate;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Infrastructure.DataBase.Context
{
    public class VacationToolContext : IdentityDbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<VacationRequest> VacationRequests { get; set; }

        public VacationToolContext(DbContextOptions<VacationToolContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //views

            base.OnModelCreating(modelBuilder);


            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            #region Sequence
            modelBuilder.HasSequence<long>(SequenceKeys.VacationKeySequence);
            

            #endregion


        }

    }
}

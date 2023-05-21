using EFCoreClinicaEstrada.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreClinicaEstrada.Data
{
    public class FisioEstradaDbContext : DbContext
    {

       
        #region DbSets

        public DbSet<Terapeuta> Terapeutas { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Consulta> Consultas { get; set; }
        public DbSet<NotaSoap> NotasSoap { get; set; }
        public DbSet<Terapia> Terapias { get; set; }
        public DbSet<ExpedienteClinico> ExpedientesClinicos { get; set; }

        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FisioEstradaDBTest"
            );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Seed Terapeutas

            modelBuilder.Entity<Terapeuta>().HasData(new Terapeuta { Id = Guid.NewGuid(), Nombre = "Kevin David Estrada Posada", CedulaProfesional = "12345678", Celular = "7331525813", FechaIngreso= DateTime.Today, Titulo = "Lic. Fisioterapeuta", RFC = "EAPK930905QD7" , FechaNacimiento = new DateTime(1993,09,05) });
            modelBuilder.Entity<Terapeuta>().HasData(new Terapeuta { Id = Guid.NewGuid(), Nombre = "David Estrada Aguilar", CedulaProfesional = "87654321", Celular = "7331251176", FechaIngreso = DateTime.Today.AddDays(-3), Titulo = "Lic. Fisioterapeuta", RFC = "EAAD651015AKA", FechaNacimiento = new DateTime(1965, 10, 15) });

            #endregion


            #region Seed Terapias

            modelBuilder.Entity<Terapia>().HasData(new Terapia { Id = Guid.NewGuid(), Nombre = "Electro Introacticula" });
            modelBuilder.Entity<Terapia>().HasData(new Terapia { Id = Guid.NewGuid(), Nombre = "Fortalecimiento" });
            modelBuilder.Entity<Terapia>().HasData(new Terapia { Id = Guid.NewGuid(), Nombre = "Movilidad" });
            modelBuilder.Entity<Terapia>().HasData(new Terapia { Id = Guid.NewGuid(), Nombre = "Recuperacion Activa" });
            modelBuilder.Entity<Terapia>().HasData(new Terapia { Id = Guid.NewGuid(), Nombre = "Bicicleta" });

            #endregion



        }
    }
}

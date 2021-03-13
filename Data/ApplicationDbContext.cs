using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TareaIglesia.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Iglesia> iglesias { get; set; }
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<AppUser>(entityTypebuilder =>
            {
                entityTypebuilder.ToTable("Users");
                entityTypebuilder.Property(u => u.IdUser).HasMaxLength(100).IsRequired();
                entityTypebuilder.Property(u => u.Nombre).HasMaxLength(100);
            });
        }
    }

    
    public class AppUser : IdentityUser
    {
        [Key]
        public Guid IdUser { get; set; }
        public string Nombre { get; set; }

    }
    public class Iglesia
    {
        [Key]
        public int HermanoID { get; set; }
        public byte[] foto { get; set; }
       
        public string Sexo { get; set; }
       
        public string Nombre { get; set; }
       
        public string Apellido { get; set; }
       
        public DateTime FechaDeNacimiento { get; set; }
       
        public string PaisNacimiento { get; set; }
       
        public string CiudadNacimiento { get; set; }
       
        public string PaisActual { get; set; }
       
        public string CiudadActual { get; set; }
       
        public string Direccion { get; set; }
       
        public string Telefono { get; set; }
       
        public string Celular { get; set; }
       
        public string Email { get; set; }
       
        public string TipoDocumentoIDentidad { get; set; }
       
        public string DocumentoIdentidad { get; set; }
       
        public string EstadoCivil { get; set; }
       
        public string NombreEsposo { get; set; }
       
        public string Hijos { get; set; }
       
        public string NoHijos { get; set; }
       
        public string Profesion { get; set; }
       
        public string OcupacionActu { get; set; }
       
        public string NombreEmpre { get; set; }
       
        public string TelefonoEmpre { get; set; }
       
        public DateTime FechaDeConversion { get; set; }
       
        public DateTime Fechabautismo { get; set; }
       
        public DateTime FechaAceptmiembro { get; set; }
       
        public string Denominacion { get; set; }
       
        public string NombreIglesia { get; set; }
       
        public string IglesiaAnterior { get; set; }
       
        public string Pastor { get; set; }
       
        public string Disciplina { get; set; }
       
        public string CausasDisciplina { get; set; }
       
        public string FuncionIglesia { get; set; }
       
        public string Ministerios { get; set; }
       
        public string MinisteriosFruto { get; set; }
       
        public string MinisterioDios { get; set; }
       
        public string Metas { get; set; }
       
        public string RespaldoAutoridades { get; set; }
       
        public string NivEstudio { get; set; }
       
        public string Expulsado { get; set; }
       
        public string RazonExpulsado { get; set; }


    }

}

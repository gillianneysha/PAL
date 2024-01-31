using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PAL.DataModel
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions opts) : base(opts)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=STORMHIE\\SQLEXPRESS;Database=ENTPROGFINALS;" +
                "Integrated Security=SSPI;" +
                "TrustServerCertificate=true;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //DAC
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<DACSlot>().ToTable("SlotsINV");
            modelBuilder.Entity<DACSlot>().Property(p => p.DACCampus).HasColumnType("nvarchar(max)");
            modelBuilder.Entity<DACSlot>().Property(p => p.UserId).HasColumnType("nvarchar(max)");
            modelBuilder.Entity<DACSlot>().Property(p => p.DACReservationId).HasColumnType("int");
            modelBuilder.Entity<DACSlot>().Property(p => p.Status).HasColumnType("nvarchar(max)");
            //AKIC
            modelBuilder.Entity<AKICSlot>().ToTable("AKICSlotsINV");
            modelBuilder.Entity<AKICSlot>().Property(p => p.AKICCampus).HasColumnType("nvarchar(max)");
            modelBuilder.Entity<AKICSlot>().Property(p => p.UserId).HasColumnType("nvarchar(max)");
            modelBuilder.Entity<AKICSlot>().Property(p => p.AKICReservationId).HasColumnType("int");
            modelBuilder.Entity<AKICSlot>().Property(p => p.Status).HasColumnType("nvarchar(max)");
            //PETER
            modelBuilder.Entity<PETERSlot>().ToTable("PETERSlotsINV");
            modelBuilder.Entity<PETERSlot>().Property(p => p.PETERCampus).HasColumnType("nvarchar(max)");
            modelBuilder.Entity<PETERSlot>().Property(p => p.UserId).HasColumnType("nvarchar(max)");
            modelBuilder.Entity<PETERSlot>().Property(p => p.PETERReservationId).HasColumnType("int");
            modelBuilder.Entity<PETERSlot>().Property(p => p.Status).HasColumnType("nvarchar(max)");
            //DOMINGA
            modelBuilder.Entity<DOMINGASlot>().ToTable("DOMINGASlotsINV");
            modelBuilder.Entity<DOMINGASlot>().Property(p => p.DOMINGACampus).HasColumnType("nvarchar(max)");
            modelBuilder.Entity<DOMINGASlot>().Property(p => p.UserId).HasColumnType("nvarchar(max)");
            modelBuilder.Entity<DOMINGASlot>().Property(p => p.DOMINGAReservationId).HasColumnType("int");
            modelBuilder.Entity<DOMINGASlot>().Property(p => p.Status).HasColumnType("nvarchar(max)");

            //dac
            modelBuilder.Entity<DACSlot>().HasData(new DACSlot
            {
                DACSlotId = 1,
                DACCampus = "DAC",
                Status = "Unoccupied",
            });
            modelBuilder.Entity<DACSlot>().HasData(new DACSlot
            {
                DACSlotId = 2,
                DACCampus = "DAC",
                Status = "Unoccupied",
            });
            modelBuilder.Entity<DACSlot>().HasData(new DACSlot
            {
                DACSlotId = 3,
                DACCampus = "DAC",
                Status = "Unoccupied",
            });
            modelBuilder.Entity<DACSlot>().HasData(new DACSlot
            {
                DACSlotId = 4,
                DACCampus = "DAC",
                Status = "Unoccupied",
            });
            modelBuilder.Entity<DACSlot>().HasData(new DACSlot
            {
                DACSlotId = 5,
                DACCampus = "DAC",
                Status = "Unoccupied",
            });
            modelBuilder.Entity<DACSlot>().HasData(new DACSlot
            {
                DACSlotId = 6,
                DACCampus = "DAC",
                Status = "Unoccupied",
            });
            modelBuilder.Entity<DACSlot>().HasData(new DACSlot
            {
                DACSlotId = 7,
                DACCampus = "DAC",
                Status = "Unoccupied",
            });
            modelBuilder.Entity<DACSlot>().HasData(new DACSlot
            {
                DACSlotId = 8,
                DACCampus = "DAC",
                Status = "Unoccupied",
            });
            modelBuilder.Entity<DACSlot>().HasData(new DACSlot
            {
                DACSlotId = 9,
                DACCampus = "DAC",
                Status = "Unoccupied",
            });
            modelBuilder.Entity<DACSlot>().HasData(new DACSlot
            {
                DACSlotId = 10,
                DACCampus = "DAC",
                Status = "Unoccupied",
            });

            //---akic
            modelBuilder.Entity<AKICSlot>().HasData(new AKICSlot
            {
                AKICSlotId = 1,
                AKICCampus = "AKIC",
                Status = "Unoccupied",
            });
            modelBuilder.Entity<AKICSlot>().HasData(new AKICSlot
            {
                AKICSlotId = 2,
                AKICCampus = "AKIC",
                Status = "Unoccupied",
            });
            modelBuilder.Entity<AKICSlot>().HasData(new AKICSlot
            {
                AKICSlotId = 3,
                AKICCampus = "AKIC",
                Status = "Unoccupied",
            });
            modelBuilder.Entity<AKICSlot>().HasData(new AKICSlot
            {
                AKICSlotId = 4,
                AKICCampus = "AKIC",
                Status = "Unoccupied",
            });
            modelBuilder.Entity<AKICSlot>().HasData(new AKICSlot
            {
                AKICSlotId = 5,
                AKICCampus = "AKIC",
                Status = "Unoccupied",
            });
            modelBuilder.Entity<AKICSlot>().HasData(new AKICSlot
            {
                AKICSlotId = 6,
                AKICCampus = "AKIC",
                Status = "Unoccupied",
            });
            modelBuilder.Entity<AKICSlot>().HasData(new AKICSlot
            {
                AKICSlotId = 7,
                AKICCampus = "AKIC",
                Status = "Unoccupied",
            });
            modelBuilder.Entity<AKICSlot>().HasData(new AKICSlot
            {
                AKICSlotId = 8,
                AKICCampus = "AKIC",
                Status = "Unoccupied",
            });
            modelBuilder.Entity<AKICSlot>().HasData(new AKICSlot
            {
                AKICSlotId = 9,
                AKICCampus = "AKIC",
                Status = "Unoccupied",
            });
            modelBuilder.Entity<AKICSlot>().HasData(new AKICSlot
            {
                AKICSlotId = 10,
                AKICCampus = "AKIC",
                Status = "Unoccupied",
            });

            //--- PETER
            modelBuilder.Entity<PETERSlot>().HasData(new PETERSlot
            {
                PETERSlotId = 1,
                PETERCampus = "PDGII",
                Status = "Unoccupied",
            });
            modelBuilder.Entity<PETERSlot>().HasData(new PETERSlot
            {
                PETERSlotId = 2,
                PETERCampus = "PDGII",
                Status = "Unoccupied",
            });
            modelBuilder.Entity<PETERSlot>().HasData(new PETERSlot
            {
                PETERSlotId = 3,
                PETERCampus = "PDGII",
                Status = "Unoccupied",
            });
            modelBuilder.Entity<PETERSlot>().HasData(new PETERSlot
            {
                PETERSlotId = 4,
                PETERCampus = "PDGII",
                Status = "Unoccupied",
            });
            modelBuilder.Entity<PETERSlot>().HasData(new PETERSlot
            {
                PETERSlotId = 5,
                PETERCampus = "PDGII",
                Status = "Unoccupied",
            });
            modelBuilder.Entity<PETERSlot>().HasData(new PETERSlot
            {
                PETERSlotId = 6,
                PETERCampus = "PDGII",
                Status = "Unoccupied",
            });
            modelBuilder.Entity<PETERSlot>().HasData(new PETERSlot
            {
                PETERSlotId = 7,
                PETERCampus = "PDGII",
                Status = "Unoccupied",
            });
            modelBuilder.Entity<PETERSlot>().HasData(new PETERSlot
            {
                PETERSlotId = 8,
                PETERCampus = "PDGII",
                Status = "Unoccupied",
            });
            modelBuilder.Entity<PETERSlot>().HasData(new PETERSlot
            {
                PETERSlotId = 9,
                PETERCampus = "PDGII",
                Status = "Unoccupied",
            });
            modelBuilder.Entity<PETERSlot>().HasData(new PETERSlot
            {
                PETERSlotId = 10,
                PETERCampus = "PDGII",
                Status = "Unoccupied",
            });

            //--- DOMINGA
            //dac
            modelBuilder.Entity<DOMINGASlot>().HasData(new DOMINGASlot
            {
                DOMINGASlotId = 1,
                DOMINGACampus = "DOMINGA",
                Status = "Unoccupied",
            });
            modelBuilder.Entity<DOMINGASlot>().HasData(new DOMINGASlot
            {
                DOMINGASlotId = 2,
                DOMINGACampus = "DOMINGA",
                Status = "Unoccupied",
            });
            modelBuilder.Entity<DOMINGASlot>().HasData(new DOMINGASlot
            {
                DOMINGASlotId = 3,
                DOMINGACampus = "DOMINGA",
                Status = "Unoccupied",
            });
            modelBuilder.Entity<DOMINGASlot>().HasData(new DOMINGASlot
            {
                DOMINGASlotId = 4,
                DOMINGACampus = "DOMINGA",
                Status = "Unoccupied",
            });
            modelBuilder.Entity<DOMINGASlot>().HasData(new DOMINGASlot
            {
                DOMINGASlotId = 5,
                DOMINGACampus = "DOMINGA",
                Status = "Unoccupied",
            });
            modelBuilder.Entity<DOMINGASlot>().HasData(new DOMINGASlot
            {
                DOMINGASlotId = 6,
                DOMINGACampus = "DOMINGA",
                Status = "Unoccupied",
            });
            modelBuilder.Entity<DOMINGASlot>().HasData(new DOMINGASlot
            {
                DOMINGASlotId = 7,
                DOMINGACampus = "DOMINGA",
                Status = "Unoccupied",
            });
            modelBuilder.Entity<DOMINGASlot>().HasData(new DOMINGASlot
            {
                DOMINGASlotId = 8,
                DOMINGACampus = "DOMINGA",
                Status = "Unoccupied",
            });
            modelBuilder.Entity<DOMINGASlot>().HasData(new DOMINGASlot
            {
                DOMINGASlotId = 9,
                DOMINGACampus = "DOMINGA",
                Status = "Unoccupied",
            });
            modelBuilder.Entity<DOMINGASlot>().HasData(new DOMINGASlot
            {
                DOMINGASlotId = 10,
                DOMINGACampus = "DOMINGA",
                Status = "Unoccupied",
            });

           
            //Campus Reservation
            modelBuilder.Entity<CampusReservation>().ToTable("CampusReserveINV");
            modelBuilder.Entity<CampusReservation>().Property(p => p.UserId).HasColumnType("nvarchar(MAX)");
            modelBuilder.Entity<CampusReservation>().Property(p => p.SlotId).HasColumnType("int");
            modelBuilder.Entity<CampusReservation>().Property(p => p.Campus).HasColumnType("nvarchar(MAX)");
            modelBuilder.Entity<CampusReservation>().Property(p => p.ContactNo).HasColumnType("nvarchar(MAX)");
            modelBuilder.Entity<CampusReservation>().Property(p => p.PlateNo).HasColumnType("nvarchar(MAX)");
            modelBuilder.Entity<CampusReservation>().Property(p => p.StartTime).HasColumnType("DateTime2(7)");
            modelBuilder.Entity<CampusReservation>().Property(p => p.EndTime).HasColumnType("DateTime2(7)");
            modelBuilder.Entity<CampusReservation>().Property(p => p.Paid).HasColumnType("tinyint");
        }
        public DbSet<DACSlot> Slots { get; set; }
       
        public DbSet<AKICSlot> AKICSlots { get; set; }
 
        public DbSet<PETERSlot> PETERSlots { get; set; }
       
        public DbSet<DOMINGASlot> DOMINGASlots { get; set; }
      
        public DbSet<CampusReservation> CampusReservations { get; set; }
    }
}

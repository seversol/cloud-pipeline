using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GasTrackerAPI.Models
{
    public partial class nrelContext : DbContext
    {
        public nrelContext()
        {
        }

        public nrelContext(DbContextOptions<nrelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AltFuelStations> AltFuelStations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=ftwrp1.lfwc.us.lmco.com\\db2008;Database=nrel;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AltFuelStations>(entity =>
            {
                entity.ToTable("alt_fuel_stations");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AccessDaysTime)
                    .HasColumnName("Access_Days_Time")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.BdBlends)
                    .HasColumnName("BD_Blends")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.CardsAccepted)
                    .HasColumnName("Cards_Accepted")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.DateLastConfirmed)
                    .HasColumnName("Date_Last_Confirmed")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.E85BlenderPump)
                    .HasColumnName("E85_Blender_Pump")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.EvConnectorTypes)
                    .HasColumnName("EV_Connector_Types")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.EvDcFastCount)
                    .HasColumnName("EV_DC_Fast_Count")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.EvLevel1EvseNum)
                    .HasColumnName("EV_Level1_EVSE_Num")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.EvLevel2EvseNum)
                    .HasColumnName("EV_Level2_EVSE_Num")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.EvNetwork)
                    .HasColumnName("EV_Network")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.EvNetworkWeb)
                    .HasColumnName("EV_Network_Web")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.EvOtherInfo)
                    .HasColumnName("EV_Other_Info")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.ExpectedDate)
                    .HasColumnName("Expected_Date")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.FederalAgencyId)
                    .HasColumnName("Federal_Agency_ID")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.FederalAgencyName)
                    .HasColumnName("Federal_Agency_Name")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.FuelTypeCode)
                    .HasColumnName("Fuel_Type_Code")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.GeocodeStatus)
                    .HasColumnName("Geocode_Status")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.GroupsWithAccessCode)
                    .HasColumnName("Groups_With_Access_Code")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.HydrogenStatusLink)
                    .HasColumnName("Hydrogen_Status_Link")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.IntersectionDirections)
                    .HasColumnName("Intersection_Directions")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Latitude)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.Longitude)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.LpgPrimary)
                    .HasColumnName("LPG_Primary")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.NgFillTypeCode)
                    .HasColumnName("NG_Fill_Type_Code")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.NgPsi)
                    .HasColumnName("NG_PSI")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.NgVehicleClass)
                    .HasColumnName("NG_Vehicle_Class")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.OpenDate)
                    .HasColumnName("Open_Date")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.OwnerTypeCode)
                    .HasColumnName("Owner_Type_Code")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.Plus4)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.StationName)
                    .HasColumnName("Station_Name")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.StationPhone)
                    .HasColumnName("Station_Phone")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.StatusCode)
                    .HasColumnName("Status_Code")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.StreetAddress)
                    .HasColumnName("Street_Address")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("Updated_At")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasColumnName("ZIP")
                    .HasMaxLength(400)
                    .IsUnicode(false);
            });
        }
    }
}

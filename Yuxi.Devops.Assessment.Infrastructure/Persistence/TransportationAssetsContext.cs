using Microsoft.EntityFrameworkCore;
using Yuxi.Devops.Assessment.Core.Companies;
using Yuxi.Devops.Assessment.Core.Drivers;
using Yuxi.Devops.Assessment.Core.Shared;
using Yuxi.Devops.Assessment.Core.Vehicles;

namespace Yuxi.Devops.Assessment.Infrastructure.Persistence
{

    public class TransportationAssetsContext : DbContext
    {
        private readonly string _connectionString;

        public TransportationAssetsContext(string connectionString)
            : base()
        {
            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

        public DbSet<Vehicle> Vehicle { get; set; }
        public DbSet<IdentificationType> IdentificationType { get; set; }
        public DbSet<BodyworkType> TrailerType { get; set; }
        public DbSet<LoadType> LoadType { get; set; }
        public DbSet<SubClasification> SubClasification { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<DrivingLicense> DrivingLicense { get; set; }
        public DbSet<CompanyVehicle> CompanyVehicle { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Designation> Designation { get; set; }
        public DbSet<Driver> Driver { get; set; }
        public DbSet<Clasification> Clasification { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Accessory> Accessory { get; set; }
        public DbSet<VehicleAccessory> VehicleAccessory { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            #region Company

            modelBuilder.Entity<Company>()
                .HasMany(e => e.CompanyVehicles)
                .WithOne(e => e.Company).IsRequired()
                .HasForeignKey(e => e.CompanyCode)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Company>()
                .ToTable("EmpresaTransportadora").HasKey(e => e.Code);

            modelBuilder.Entity<Company>()
                .Property(e => e.Code)
                .HasColumnName("Codigo").HasColumnType("bigint");

            modelBuilder.Entity<Company>()
                .Property(e => e.Name)
                .HasColumnName("Nombre").HasMaxLength(300).HasColumnType("nvarchar");

            #endregion

            #region Person

            modelBuilder.Entity<Person>()
                .HasMany(e => e.Drivers)
                .WithOne(e => e.Person).IsRequired()
                .HasForeignKey(e => e.PersonCode)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.VehiclesAsOwner)
                .WithOne(e => e.Owner)
                .HasForeignKey(e => e.OwnerCode);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.VehiclesAsAdministrator)
                .WithOne(e => e.Administrator)
                .HasForeignKey(e => e.AdministratorCode);

            modelBuilder.Entity<Person>().ToTable("Persona").HasKey(e => e.Code);
            modelBuilder.Entity<Person>()
                .Property(e => e.Code)
                .HasColumnName("Codigo").HasColumnType("bigint");

            modelBuilder.Entity<Person>()
                .Property(e => e.IdentificationTypeCode)
                .HasColumnName("CodigoTipoIdentificacion").HasColumnType("int");

            modelBuilder.Entity<Person>()
                .Property(e => e.Identification)
                .HasColumnName("Identificacion").HasMaxLength(50).HasColumnType("nvarchar");

            modelBuilder.Entity<Person>()
                .Property(e => e.Name)
                .HasColumnName("Nombres").HasMaxLength(50).HasColumnType("nvarchar");

            modelBuilder.Entity<Person>()
                .Property(e => e.LastName)
                .HasColumnName("Apellidos").HasMaxLength(50).HasColumnType("nvarchar");

            modelBuilder.Entity<Person>()
                .Property(e => e.Email)
                .HasColumnName("CorreoElectronico").HasMaxLength(100).HasColumnType("nvarchar");

            modelBuilder.Entity<Person>()
                .Property(e => e.Mobile)
                .HasColumnName("Celular").HasColumnType("numeric");

            #endregion

            #region Vehicle

            modelBuilder.Entity<Vehicle>()
                .HasMany(e => e.VehicleAccessories)
                .WithOne(e => e.Vehicle).IsRequired()
                .HasForeignKey(e => e.VehicleCode)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Vehicle>()
                .HasMany(e => e.CompanyVehicles)
                .WithOne(e => e.Vehicle).IsRequired()
                .HasForeignKey(e => e.VehicleCode)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Vehicle>().ToTable("Vehiculo").HasKey(e => e.Code);
            modelBuilder.Entity<Vehicle>()
                .Property(e => e.Code)
                .HasColumnName("Codigo").HasColumnType("bigint");

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.Plate)
                .HasColumnName("Placa").HasMaxLength(15).HasColumnType("nvarchar");

            modelBuilder.Entity<Vehicle>()
               .Property(e => e.Brand)
               .HasColumnName("Marca").HasMaxLength(50).HasColumnType("nvarchar");

            modelBuilder.Entity<Vehicle>()
              .Property(e => e.Line)
              .HasColumnName("Linea").HasMaxLength(50).HasColumnType("nvarchar");

            modelBuilder.Entity<Vehicle>()
              .Property(e => e.Model)
              .HasColumnName("Modelo").HasColumnType("numeric");

            modelBuilder.Entity<Vehicle>()
              .Property(e => e.OwnerCode)
              .HasColumnName("CodigoPropietario").HasColumnType("bigint");

            modelBuilder.Entity<Vehicle>()
              .Property(e => e.AdministratorCode)
              .HasColumnName("CodigoAdministrador").HasColumnType("bigint");

            modelBuilder.Entity<Vehicle>()
              .Property(e => e.DriverCode)
              .HasColumnName("CodigoConductor").HasColumnType("bigint");

            modelBuilder.Entity<Vehicle>()
              .Property(e => e.DesignationCode)
              .HasColumnName("CodigoDesignacion").HasColumnType("int");

            modelBuilder.Entity<Vehicle>()
              .Property(e => e.TrailerPlate)
              .HasColumnName("PlacaRemolque").HasMaxLength(15).HasColumnType("nvarchar");

            modelBuilder.Entity<Vehicle>()
              .Property(e => e.TrailerBrand)
              .HasColumnName("MarcaRemolque").HasMaxLength(50).HasColumnType("nvarchar");

            modelBuilder.Entity<Vehicle>()
              .Property(e => e.BodyworkLine)
              .HasColumnName("LineaCarroceria").HasMaxLength(50).HasColumnType("nvarchar");

            modelBuilder.Entity<Vehicle>()
              .Property(e => e.BodyworkModel)
              .HasColumnName("ModeloCarroceria").HasMaxLength(50).HasColumnType("nvarchar");

            modelBuilder.Entity<Vehicle>()
              .Property(e => e.BodyworkTypeCode)
              .HasColumnName("CodigoTipoCarroceria").HasColumnType("int");

            modelBuilder.Entity<Vehicle>()
              .Property(e => e.LoadTypeCode)
              .HasColumnName("CodigoTipoCarga").HasColumnType("int");

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.LoadCapacity)
                .HasColumnName("CapacidadCarga")
                .HasColumnType("decimal(5,2)");


            modelBuilder.Entity<Vehicle>()
                .Property(e => e.VolumetricCapacity)
                .HasColumnName("CapacidadVolumetrica")
                .HasColumnType("decimal(5,2)");

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.Length)
                .HasColumnName("Largo")
                .HasColumnType("decimal(5,2)");

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.Width)
                .HasColumnName("Ancho")
                .HasColumnType("decimal(5,2)");

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.Height)
                .HasColumnName("Alto")
                .HasColumnType("decimal(5,2)");

            #endregion

            #region IdentificationType

            modelBuilder.Entity<IdentificationType>()
                .HasMany(e => e.Persons)
                .WithOne(e => e.IdentificationType).IsRequired()
                .HasForeignKey(e => e.IdentificationTypeCode)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<IdentificationType>().ToTable("TipoIdentificacion").HasKey(e => e.Code);
            modelBuilder.Entity<IdentificationType>()
                .Property(e => e.Code)
                .HasColumnName("Codigo").HasColumnType("int");

            modelBuilder.Entity<IdentificationType>()
               .Property(e => e.Name)
               .HasColumnName("Nombre").HasMaxLength(50).HasColumnType("nvarchar");

            modelBuilder.Entity<IdentificationType>()
               .Property(e => e.Acronym)
               .HasColumnName("Acronimo").HasMaxLength(5).HasColumnType("nvarchar");

            #endregion

            #region BodyworkType

            modelBuilder.Entity<BodyworkType>()
                .HasMany(e => e.Vehicles)
                .WithOne(e => e.BodyworkType).IsRequired()
                .HasForeignKey(e => e.BodyworkTypeCode)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<BodyworkType>().ToTable("TipoCarroceria").HasKey(e => e.Code);
            modelBuilder.Entity<BodyworkType>()
                .Property(e => e.Code)
                .HasColumnName("Codigo").HasColumnType("int");

            modelBuilder.Entity<BodyworkType>()
               .Property(e => e.Name)
               .HasColumnName("Nombre").HasMaxLength(100).HasColumnType("nvarchar");

            #endregion

            #region LoadType

            modelBuilder.Entity<LoadType>()
                .HasMany(e => e.Vehicles)
                .WithOne(e => e.LoadType).IsRequired()
                .HasForeignKey(e => e.LoadTypeCode)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<LoadType>().ToTable("TipoCarga").HasKey(e => e.Code);
            modelBuilder.Entity<LoadType>()
                .Property(e => e.Code)
                .HasColumnName("Codigo").HasColumnType("int");

            modelBuilder.Entity<LoadType>()
               .Property(e => e.Name)
               .HasColumnName("Nombre").HasMaxLength(100).HasColumnType("nvarchar");

            #endregion

            #region SubClasification

            modelBuilder.Entity<SubClasification>()
                .HasMany(e => e.Designations)
                .WithOne(e => e.SubClasification).IsRequired()
                .HasForeignKey(e => e.SubClasificationCode)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<SubClasification>().ToTable("SubClasificacion").HasKey(e => e.Code);
            modelBuilder.Entity<SubClasification>()
                .Property(e => e.Code)
                .HasColumnName("Codigo").HasColumnType("int");

            modelBuilder.Entity<SubClasification>()
              .Property(e => e.ClasificationCode)
              .HasColumnName("CodigoClasificacion").HasColumnType("int");

            modelBuilder.Entity<SubClasification>()
               .Property(e => e.Name)
               .HasColumnName("Nombre").HasMaxLength(50).HasColumnType("nvarchar");

            #endregion

            #region DrivingLicense

            modelBuilder.Entity<DrivingLicense>()
                .HasMany(e => e.Drivers)
                .WithOne(e => e.DrivingLicense).IsRequired()
                .HasForeignKey(e => e.DrivingLicenseCode)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DrivingLicense>().ToTable("LicenciaConduccion").HasKey(e => e.Code);
            modelBuilder.Entity<DrivingLicense>()
                .Property(e => e.Code)
                .HasColumnName("Codigo").HasColumnType("int");

            modelBuilder.Entity<DrivingLicense>()
                .Property(e => e.Category)
                .HasColumnName("Categoria").HasMaxLength(3).HasColumnType("varchar")
                .IsUnicode(false);

            modelBuilder.Entity<DrivingLicense>()
                .Property(e => e.Description)
                .HasColumnName("Descripcion").HasMaxLength(200).HasColumnType("nvarchar");

            #endregion

            #region CompanyVehicle

            modelBuilder.Entity<CompanyVehicle>().ToTable("EmpresaTransportadoraVehiculo").HasKey(e => e.Code);
            modelBuilder.Entity<CompanyVehicle>()
                .Property(e => e.Code)
                .HasColumnName("Codigo").HasColumnType("bigint");

            modelBuilder.Entity<CompanyVehicle>()
              .Property(e => e.CompanyCode)
              .HasColumnName("CodigoEmpresaTransportadora").HasColumnType("bigint");

            modelBuilder.Entity<CompanyVehicle>()
              .Property(e => e.VehicleCode)
              .HasColumnName("CodigoVehiculo").HasColumnType("bigint");

            modelBuilder.Entity<CompanyVehicle>()
              .Property(e => e.CategoryCode)
              .HasColumnName("CodigoCategoria").HasColumnType("int");

            #endregion

            #region Designation

            modelBuilder.Entity<Designation>()
                .HasMany(e => e.Vehicles)
                .WithOne(e => e.Designation).IsRequired()
                .HasForeignKey(e => e.DesignationCode)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Designation>().ToTable("Designacion").HasKey(e => e.Code);
            modelBuilder.Entity<Designation>()
                .Property(e => e.Code)
                .HasColumnName("Codigo").HasColumnType("int");

            modelBuilder.Entity<Designation>()
                .Property(e => e.Configuration)
                .HasColumnName("Configuracion").HasMaxLength(5).HasColumnType("varchar")
                .IsUnicode(false);

            modelBuilder.Entity<Designation>()
              .Property(e => e.SubClasificationCode)
              .HasColumnName("CodigoSubClasificacion").HasColumnType("int");

            modelBuilder.Entity<Designation>()
                .Property(e => e.Description)
                .HasColumnName("Descripcion").HasMaxLength(500).HasColumnType("nvarchar");

            modelBuilder.Entity<Designation>()
                .Property(e => e.AutomotiveAxles)
                .HasColumnName("EjesAutomotor").HasColumnType("int");

            modelBuilder.Entity<Designation>()
                .Property(e => e.NoAutomotiveAxles)
                .HasColumnName("EjesNoAutomotor").HasColumnType("int");

            modelBuilder.Entity<Designation>()
                .Property(e => e.MaxWidth)
                .HasColumnName("AnchoMaximo").HasColumnType("decimal")
                .HasColumnType("decimal(5,2)");

            modelBuilder.Entity<Designation>()
                .Property(e => e.MaxHeight)
                .HasColumnName("AlturaMaxima").HasColumnType("decimal")
                .HasColumnType("decimal(5,2)");

            modelBuilder.Entity<Designation>()
                .Property(e => e.MaxLength)
                .HasColumnName("LongitudMaxima").HasColumnType("decimal")
                .HasColumnType("decimal(5,2)");

            modelBuilder.Entity<Designation>()
                .Property(e => e.GVWR)
                .HasColumnName("PesoBrutoVehicular").HasColumnType("numeric")
                .HasColumnType("numeric(8,0)");

            modelBuilder.Entity<Designation>()
                .Property(e => e.Tolerance)
                .HasColumnName("Tolerancia").HasColumnType("numeric")
                .HasColumnType("numeric(4,0)");

            #endregion

            #region Driver

            modelBuilder.Entity<Driver>()
                .HasMany(e => e.Vehicles)
                .WithOne(e => e.Driver)
                .HasForeignKey(e => e.DriverCode);

            modelBuilder.Entity<Driver>().ToTable("Conductor").HasKey(e => e.Code);
            modelBuilder.Entity<Driver>()
                .Property(e => e.Code)
                .HasColumnName("Codigo").HasColumnType("bigint");

            modelBuilder.Entity<Driver>()
              .Property(e => e.PersonCode)
              .HasColumnName("CodigoUsuario").HasColumnType("bigint");

            modelBuilder.Entity<Driver>()
              .Property(e => e.DrivingLicenseCode)
              .HasColumnName("CodigoLicenciaConduccion").HasColumnType("int");

            #endregion

            #region Clasification

            modelBuilder.Entity<Clasification>()
                .HasMany(e => e.SubClasification)
                .WithOne(e => e.Clasification).IsRequired()
                .HasForeignKey(e => e.ClasificationCode)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Clasification>().ToTable("Clasificacion").HasKey(e => e.Code);
            modelBuilder.Entity<Clasification>()
                .Property(e => e.Code)
                .HasColumnName("Codigo").HasColumnType("int");

            modelBuilder.Entity<Clasification>()
                .Property(e => e.Name)
                .HasColumnName("Nombre").HasMaxLength(50).HasColumnType("nvarchar");

            #endregion

            #region Category

            modelBuilder.Entity<Category>()
                .HasMany(e => e.CompanyVehicles)
                .WithOne(e => e.Category).IsRequired()
                .HasForeignKey(e => e.CategoryCode)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Category>().ToTable("Categoria").HasKey(e => e.Code);
            modelBuilder.Entity<Category>()
                .Property(e => e.Code)
                .HasColumnName("Codigo").HasColumnType("int");

            modelBuilder.Entity<Category>()
                .Property(e => e.Name)
                .HasColumnName("Nombre").HasMaxLength(50).HasColumnType("nvarchar");

            #endregion

            #region Accessory

            modelBuilder.Entity<Accessory>()
                .HasMany(e => e.VehicleAccessories)
                .WithOne(e => e.Accessory).IsRequired()
                .HasForeignKey(e => e.AccessoryCode)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Accessory>().ToTable("Accesorio").HasKey(e => e.Code);
            modelBuilder.Entity<Accessory>()
                .Property(e => e.Code)
                .HasColumnName("Codigo").HasColumnType("int");

            modelBuilder.Entity<Accessory>()
                .Property(e => e.Name)
                .HasColumnName("Nombre").HasMaxLength(50).HasColumnType("nvarchar");

            #endregion

            #region VehicleAccessory

            modelBuilder.Entity<VehicleAccessory>().ToTable("AccesorioVehiculo").HasKey(e => e.Code);
            modelBuilder.Entity<VehicleAccessory>()
                .Property(e => e.Code)
                .HasColumnName("Codigo").HasColumnType("bigint");

            modelBuilder.Entity<VehicleAccessory>()
                .Property(e => e.AccessoryCode)
                .HasColumnName("CodigoAccesorio").HasColumnType("int");

            modelBuilder.Entity<VehicleAccessory>()
                .Property(e => e.VehicleCode)
                .HasColumnName("CodigoVehiculo").HasColumnType("bigint");

            modelBuilder.Entity<VehicleAccessory>()
                .Property(e => e.Quantity)
                .HasColumnName("Cantidad").HasColumnType("smallint");

            #endregion

        }
    }
}

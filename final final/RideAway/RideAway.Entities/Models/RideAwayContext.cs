using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace RideAway.Entities.Models
{
    public partial class RideAwayContext : DbContext
    {
        public RideAwayContext()
        {
        }

        public RideAwayContext(DbContextOptions<RideAwayContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Agency> Agencies { get; set; }
        public virtual DbSet<Calendar> Calendars { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Passenger> Passengers { get; set; }
        public virtual DbSet<PassengerWaitingLine> PassengerWaitingLines { get; set; }
        public virtual DbSet<ReasonOfDelay> ReasonOfDelays { get; set; }
        public virtual DbSet<Route> Routes { get; set; }
        public virtual DbSet<StationByLine> StationByLines { get; set; }
        public virtual DbSet<Stop> Stops { get; set; }
        public virtual DbSet<StopTime> StopTimes { get; set; }
        public virtual DbSet<StopTimesBack> StopTimesBacks { get; set; }
        public virtual DbSet<Trip> Trips { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-1I5EU6P;Database=RideAway;Trusted_Connection=True;Integrated Security=True;Connect Timeout=3000");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Hebrew_CI_AS");

            modelBuilder.Entity<Agency>(entity =>
            {
                entity.ToTable("agency");

                entity.Property(e => e.AgencyId)
                    .ValueGeneratedNever()
                    .HasColumnName("agency_id");

                entity.Property(e => e.AgencyFareUrl)
                    .HasMaxLength(1)
                    .HasColumnName("agency_fare_url");

                entity.Property(e => e.AgencyLang)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("agency_lang");

                entity.Property(e => e.AgencyName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("agency_name");

                entity.Property(e => e.AgencyPhone)
                    .HasMaxLength(1)
                    .HasColumnName("agency_phone");

                entity.Property(e => e.AgencyTimezone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("agency_timezone");

                entity.Property(e => e.AgencyUrl)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("agency_url");
            });

            modelBuilder.Entity<Calendar>(entity =>
            {
                entity.HasKey(e => e.ServiceId)
                    .HasName("pk_calendar_service");

                entity.ToTable("calendar");

                entity.Property(e => e.ServiceId)
                    .ValueGeneratedNever()
                    .HasColumnName("service_id");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.Friday).HasColumnName("friday");

                entity.Property(e => e.Monday).HasColumnName("monday");

                entity.Property(e => e.Saturday).HasColumnName("saturday");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.Sunday).HasColumnName("sunday");

                entity.Property(e => e.Thursday).HasColumnName("thursday");

                entity.Property(e => e.Tuesday).HasColumnName("tuesday");

                entity.Property(e => e.Wednesday).HasColumnName("wednesday");
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.ToTable("comments");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.FromStopId).HasColumnName("from_stop_id");

                entity.Property(e => e.FromTime)
                    .HasColumnType("datetime")
                    .HasColumnName("from_time");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.ToStopId).HasColumnName("to_stop_id");

                entity.Property(e => e.ToTime)
                    .HasColumnType("datetime")
                    .HasColumnName("to_time");
            });

            modelBuilder.Entity<Passenger>(entity =>
            {
                entity.ToTable("passenger");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DestinationRouteId).HasColumnName("destination_route_id");

                entity.Property(e => e.DestinationStationId).HasColumnName("destination_station_id");

                entity.Property(e => e.IdentityNumber).HasColumnName("identity_number");

                entity.Property(e => e.RavKavId)
                    .IsUnicode(false)
                    .HasColumnName("rav_kav_id");

                entity.Property(e => e.ReasonOfDelayId).HasColumnName("reason_of_delay_id");

                entity.Property(e => e.SourceStationId).HasColumnName("source_station_id");

                entity.Property(e => e.ValidationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("validation_date");
            });

            modelBuilder.Entity<PassengerWaitingLine>(entity =>
            {
                entity.HasKey(e => new { e.PassengerId, e.RouteId });

                entity.ToTable("passenger_waiting_line");

                entity.Property(e => e.PassengerId).HasColumnName("passenger_id");

                entity.Property(e => e.RouteId).HasColumnName("route_id");
            });

            modelBuilder.Entity<ReasonOfDelay>(entity =>
            {
                entity.HasKey(e => e.ReasonId);

                entity.ToTable("reason_of_delay");

                entity.Property(e => e.ReasonId).HasColumnName("reason_id");

                entity.Property(e => e.IsResetWaitingTime).HasColumnName("is_reset_waiting_time");

                entity.Property(e => e.ReasonDescription)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("reason_description");
            });

            modelBuilder.Entity<Route>(entity =>
            {
                entity.ToTable("routes");

                entity.Property(e => e.RouteId)
                    .ValueGeneratedNever()
                    .HasColumnName("route_id");

                entity.Property(e => e.AgencyId).HasColumnName("agency_id");

                entity.Property(e => e.RouteColor)
                    .HasMaxLength(50)
                    .HasColumnName("route_color");

                entity.Property(e => e.RouteDesc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("route_desc");

                entity.Property(e => e.RouteLongName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("route_long_name");

                entity.Property(e => e.RouteShortName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("route_short_name");

                entity.Property(e => e.RouteType).HasColumnName("route_type");
            });

            modelBuilder.Entity<StationByLine>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("station_by_line");

                entity.Property(e => e.ArrivalTime)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("arrival_time");

                entity.Property(e => e.Line)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("line");

                entity.Property(e => e.RouteDesc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("route_desc");

                entity.Property(e => e.RouteId).HasColumnName("route_id");

                entity.Property(e => e.StopDesc)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("stop_desc");

                entity.Property(e => e.StopId).HasColumnName("stop_id");

                entity.Property(e => e.StopSequence).HasColumnName("stop_sequence");

                entity.Property(e => e.TripId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("trip_id");
            });

            modelBuilder.Entity<Stop>(entity =>
            {
                entity.ToTable("stops");

                entity.Property(e => e.StopId)
                    .ValueGeneratedNever()
                    .HasColumnName("stop_id");

                entity.Property(e => e.LocationType).HasColumnName("location_type");

                entity.Property(e => e.ParentStation)
                    .HasMaxLength(1)
                    .HasColumnName("parent_station");

                entity.Property(e => e.StopCode).HasColumnName("stop_code");

                entity.Property(e => e.StopDesc)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("stop_desc");

                entity.Property(e => e.StopLat).HasColumnName("stop_lat");

                entity.Property(e => e.StopLon).HasColumnName("stop_lon");

                entity.Property(e => e.StopName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("stop_name");

                entity.Property(e => e.ZoneId).HasColumnName("zone_id");
            });

            modelBuilder.Entity<StopTime>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("stop_times");

                entity.Property(e => e.ArrivalTime)
                    .HasMaxLength(50)
                    .HasColumnName("arrival_time");

                entity.Property(e => e.DepartureTime)
                    .HasMaxLength(50)
                    .HasColumnName("departure_time");

                entity.Property(e => e.DropOffType).HasColumnName("drop_off_type");

                entity.Property(e => e.PickupType).HasColumnName("pickup_type");

                entity.Property(e => e.ShapeDistTraveled).HasColumnName("shape_dist_traveled");

                entity.Property(e => e.StopId).HasColumnName("stop_id");

                entity.Property(e => e.StopSequence).HasColumnName("stop_sequence");

                entity.Property(e => e.TripId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("trip_id");
            });

            modelBuilder.Entity<StopTimesBack>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("stop_times_back");

                entity.Property(e => e.ArrivalTime)
                    .HasMaxLength(50)
                    .HasColumnName("arrival_time");

                entity.Property(e => e.DepartureTime)
                    .HasMaxLength(50)
                    .HasColumnName("departure_time");

                entity.Property(e => e.DropOffType).HasColumnName("drop_off_type");

                entity.Property(e => e.PickupType).HasColumnName("pickup_type");

                entity.Property(e => e.ShapeDistTraveled).HasColumnName("shape_dist_traveled");

                entity.Property(e => e.StopId).HasColumnName("stop_id");

                entity.Property(e => e.StopSequence).HasColumnName("stop_sequence");

                entity.Property(e => e.TripId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("trip_id");
            });

            modelBuilder.Entity<Trip>(entity =>
            {
                entity.ToTable("trips");

                entity.Property(e => e.TripId)
                    .HasMaxLength(50)
                    .HasColumnName("trip_id");

                entity.Property(e => e.DirectionId).HasColumnName("direction_id");

                entity.Property(e => e.RouteId).HasColumnName("route_id");

                entity.Property(e => e.ServiceId).HasColumnName("service_id");

                entity.Property(e => e.ShapeId).HasColumnName("shape_id");

                entity.Property(e => e.TripHeadsign)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("trip_headsign");

                entity.HasOne(d => d.Route)
                    .WithMany(p => p.Trips)
                    .HasForeignKey(d => d.RouteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_trips_routes");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.Trips)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_trips_calendar");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

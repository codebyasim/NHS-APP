using Microsoft.EntityFrameworkCore;
using NhsSystem.Domain.Entities;

namespace NhsSystem.Infrastructure.Data;

public class NhsDbContext : DbContext
{
    public NhsDbContext(DbContextOptions<NhsDbContext> options) : base(options) { }

    public DbSet<Patient> Patients => Set<Patient>();
    public DbSet<Clinician> Clinicians => Set<Clinician>();
    public DbSet<Appointment> Appointments => Set<Appointment>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // Entity configurations can be added here if needed
    }
}
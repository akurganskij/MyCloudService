using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

public class DBContext : DbContext
{
    public DBContext(DbContextOptions<DBContext> options) : base(options) { }

    public DbSet<Image> images { get; set; } = null!;
    public DbSet<Tasks> tasks { get; set; } = null!;
    //public DbSet<Problems> problems { get; set; } = null!;

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	=> optionsBuilder
	.UseSqlite("Data Source=cloud.db");

	/*protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

		#region TableSplitting
		modelBuilder.Entity<Tasks>(
		dob =>
		{
			dob.ToTable("Tasks");
			dob.Property(o => o.ImageId).HasColumnName("ImageId");
		});

		modelBuilder.Entity<Image>(
		ob =>
		{
			ob.ToTable("Images");
			ob.Property(o => o.Id).HasColumnName("Id");
			ob.HasMany(o => o.Tasks).WithOne()
		.HasForeignKey<Tasks>(o => o.ImageId);
		});
		#endregion
	}
	*/
}

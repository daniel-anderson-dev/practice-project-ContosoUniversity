using ReHashContosoUniversity.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace ReHashContosoUniversity.DAL
{
	public class SchoolContext : DbContext
	{

		public DbSet<Course> Courses { get; set; }
		public DbSet<Department> Departments { get; set; }
		public DbSet<Enrollment> Enrollments { get; set; }
		public DbSet<Instructor> Instructors { get; set; }
		public DbSet<Student> Students { get; set; }
		public DbSet<OfficeAssignment> OfficeAssignments { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

			modelBuilder.Entity<Course>()
				.HasMany(course => course.Instructors)
				.WithMany(instructor => instructor.Courses)
				.Map(table => table.MapLeftKey("CourseID")
					.MapRightKey("InstructorID")
					.ToTable("CourseInstructor"));
		}

	}
}
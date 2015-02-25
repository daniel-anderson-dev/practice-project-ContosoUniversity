using System;
using System.Collections.Generic;


namespace ReHashContosoUniversity.Models
{

	public enum Grade
	{
		A = 1, B = 2, C = 3, D = 4, F = 5
	}

	public class Enrollment
	{

		public int EnrollmentID { get; set; }
		public int CourseID { get; set; }
		public int StudentID { get; set; }
		public Grade? Grade { get; set; }

		public virtual Course Course { get; set; }
		public virtual Student Student { get; set; }

	}
}
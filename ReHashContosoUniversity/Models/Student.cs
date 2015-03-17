using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace ReHashContosoUniversity.Models
{
	public class Student
	{

		public int ID { get; set; }
		[StringLength(50, ErrorMessage = "Last Name cannot be more than 50 characters.")]
		public string LastName { get; set; }
		[StringLength(50, ErrorMessage = "First Name cannot be more than 50 characters.")]
		public string FirstMidName { get; set; }
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
		public DateTime EnrollmentDate { get; set; }

		public virtual ICollection<Enrollment> Enrollments { get; set; }

	}
}
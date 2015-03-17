using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ReHashContosoUniversity.Models
{
	public class Student
	{

		public int ID { get; set; }

		[Required]
		[StringLength(50, ErrorMessage = "Last Name cannot be more than 50 characters.")]
		[Display(Name = "Last Name")]
		public string LastName { get; set; }

		[Required]
		[StringLength(50, ErrorMessage = "First Name cannot be more than 50 characters.")]
		[Column("First Name")]
		[Display(Name = "First Name")]
		public string FirstMidName { get; set; }

		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
		[Display(Name = "Enrollment Date")]
		public DateTime EnrollmentDate { get; set; }

		[Display(Name = "Full Name")]
		public string FullName
		{
			get
			{
				return LastName + ", " + FirstMidName;
			}
		}

		public virtual ICollection<Enrollment> Enrollments { get; set; }

	}
}
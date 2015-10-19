using System;
using System.ComponentModel.DataAnnotations;


namespace ReHashContosoUniversity.ViewModels
{
	public class EnrollmentDateGroup
	{

		[DataType(DataType.Date)]
		public DateTime? EnrollmentDate { get; set; }

		public int StudentCount { get; set; }

	}
}
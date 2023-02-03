using Microsoft.AspNetCore.Mvc;

namespace Mentor.Models
{
	 public class Courses
	{
		public int Id { get; set; }
		public string Image { get; set; }
		public string CourseName { get; set; }
		
		public string CourseDescription { get; set; }
		public string CourseTitle { get; set;}
		public string	TeacherImg { get; set; }
	}
}

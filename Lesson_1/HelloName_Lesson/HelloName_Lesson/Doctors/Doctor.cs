using System;
namespace HelloName_Lesson.Doctors
{
	public class Doctor
	{
		public string doctorName;
		public int yearsOfExperience;
		
		public Doctor(string doctorName, int yearsOfExperience)
		{
			this.doctorName = doctorName;
			this.yearsOfExperience = yearsOfExperience;
		}

		public virtual string Treat()
		{
			return "Basic treatment";
		}

		public virtual string Treatment()
		{
			return "Drink more liquid!";
		}
	}
}
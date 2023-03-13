using System;
namespace HelloName_Lesson.Doctors
{
	public class Dentist : Doctor
	{
        public Dentist(string doctorName, int yearsOfExperience) : base (doctorName,yearsOfExperience)
        {
            this.doctorName = doctorName;
            this.yearsOfExperience = yearsOfExperience;
        }

        public override string Treat()
		{
            return $"The Dentist {doctorName} with the {yearsOfExperience} years of expirience is treating the patient!\nConclusion: Teeth Cleanings. This is by far the most common reason people visit the dentist.\n";
		}
    }
}
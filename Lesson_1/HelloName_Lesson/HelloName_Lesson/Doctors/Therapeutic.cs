using System;
namespace HelloName_Lesson.Doctors
{
	public class Therapeutic : Doctor
	{
        public string specialist = "Therapeutic";

        public Therapeutic(string doctorName, int yearsOfExperience) : base(doctorName, yearsOfExperience)
        {
            this.doctorName = doctorName;
            this.yearsOfExperience = yearsOfExperience;
        }

        public override string Treat()
        {
            return $"The Therapeutic {doctorName} with the {yearsOfExperience} years of expirience is treating the patient!\nConclusion: Sign up for a complete examination of the body to clarify the diagnosis\n";
        }
    }
}
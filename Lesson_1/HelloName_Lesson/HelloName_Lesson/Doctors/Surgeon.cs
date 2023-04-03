using System;
namespace HelloName_Lesson.Doctors
{
	public class Surgeon : Doctor
	{
        public string specialist = "Surgeon";

        public Surgeon(string doctorName, int yearsOfExperience) : base(doctorName, yearsOfExperience)
        {
            this.doctorName = doctorName;
            this.yearsOfExperience = yearsOfExperience;
        }

        public override string Treat()
        {
            return $"The Surgeon {doctorName} with the {yearsOfExperience} years of expirience is treating the patient!\nConclusion: Tonsillectomy. The surgical removal of one or both tonsils.\nTonsils are located at the back of the mouth and help fight infections.\n";
        }
    }
}
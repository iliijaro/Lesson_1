using System;
namespace HelloName_Lesson.Doctors
{
	public class Patient
	{
		public string patientName;
		public int patientAge;
		public int TreatmentPlan;

		public Patient(string patientName, int patientAge, int TreatmentPlan)
		{
			this.patientName = patientName;
			this.patientAge = patientAge;
			this.TreatmentPlan = TreatmentPlan;
		}

		public void GetInfo()
		{
			Console.WriteLine($"Patient's name: {patientName}. At the age of {patientAge}.");
		}

		public void assignTheDoctor()
		{
			if (TreatmentPlan == 1)
			{
				Console.WriteLine(new Surgeon("Silvester Alexadrovich", 11).Treat());
			}
			else if (TreatmentPlan == 2)
			{
				Console.WriteLine(new Dentist("Dmitrii Vasilev", 8).Treat());
			}
			else if ((TreatmentPlan != 1) && (TreatmentPlan != 2))
			{
				Console.WriteLine(new Therapeutic("George Makalkin", 25).Treat());
			}
		}
	}
}
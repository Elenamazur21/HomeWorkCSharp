using System;
namespace Lesson3
{

    public static class Program
    {

        public static void Main()
        {
            var neurologist = new Neurologist("Анатолий", 34, 8, "неврологом");
           
            var ophthalmologist= new Ophthalmologist("Иван", 56, 32, "офтальмологом");
          
            var therapist = new Therapist("Сергей", 43, 19, "терапевтом");

            var patient1 = new Patient("Михаил", " Воронов ", 43, "улица Мира д.43 ",false);

            var patient2 = new Patient("Павел", " Романюк ", 64, "Попова д.3",false);

            var patient3 = new Patient("Сергей", " Горошко",26, "Афанасьева д.4 ",true);


            var doctors = new List<Doctor>();
            doctors.Add(neurologist);
            doctors.Add(ophthalmologist);
            doctors.Add(therapist);

            foreach (var d in doctors)
            {
                d.DisplayInfo();
            }

            var patients = new List<Patient>();
            patients.Add(patient1);
            patients.Add(patient2);
            patients.Add(patient3);

            foreach (var p in patients)
            {
                p.DisplayInfo();
            }


            therapist.Cure(patient2);
            patient2.DisplayInfo();

            ophthalmologist.Cure(patient3);
            patient3.DisplayInfo();

        }














    }









}

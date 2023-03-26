using System;
namespace Lesson3
{
    public class Ophthalmologist : Doctor
    {
        public Ophthalmologist(string name, int age, int exper, string spec) : base(name, age, exper, spec)
        {
        }

        public override void Cure(Patient patient)
        {
            if (patient.Status == true)
            {
                Console.WriteLine("Ты здоров,иди домой");

            }
            else
            {
                patient.Status = true;
                Console.WriteLine("Ура,чудесная сила исцеления!");
            }
        }
    }

}
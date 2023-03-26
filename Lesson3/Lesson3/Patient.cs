using System;
namespace Lesson3
{
	public class Patient
	{
		public Patient(string name, string surname, int age, string adres, bool status)

		{
			Name = name;
			Surname = surname;
			Age = age;
			Adres = adres;
			Status = status;


		}

		public string Name { get; set; }
		public string Surname { get; set; }
		public int Age { get; set; }
		public string Adres { get; set; }
		public bool Status { get; set; }


        public virtual void DisplayInfo()
        {
			Console.WriteLine($"Меня зовут {Name}{Surname}, {Age} лет отроду");
			Console.WriteLine($"{Status}\n");
        }
    }

	
}


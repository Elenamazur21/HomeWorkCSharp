using System;
namespace Lesson3
{ 
		public abstract class Doctor : ICure
	{

			public Doctor (string name, int age, int exper, string spec)

			{
			Name = name;
			Age = age;
			Exper = exper;
			Spec = spec;

			}

		public string Name { get; set; }
		public int Age { get; set; }
		public int Exper { get; set; }
		public string Spec { get; set; }

	
		public virtual void DisplayInfo()
		{
			Console.WriteLine($"Мое имя - {Name},мне {Age} лет,из них {Exper} я работаю врачом {Spec}\n");
		}


		public abstract void Cure(Patient patient);
		

	}
	
}




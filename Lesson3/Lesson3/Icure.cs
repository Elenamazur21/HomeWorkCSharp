using System;
namespace Lesson3
{
	public interface ICure
	{
		public void CureInfo(Patient patient)
		{
			patient.DisplayInfo();

        }
    }
}


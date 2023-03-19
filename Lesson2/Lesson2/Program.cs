namespace System;

public static class Program
{

    public static void Main()
    {
        int maxValue = 0;
        int secondMaxValue = 0;

        Console.WriteLine("Задай размер массива");

        try
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Введите элемент массива под индексом {i}:");
                numbers[i] = Convert.ToInt32(Console.ReadLine());

            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > maxValue)
                {
                    secondMaxValue = maxValue;
                    maxValue = numbers[i];
                }
                else if (numbers[i] > secondMaxValue && numbers[i] != maxValue)
                {
                    secondMaxValue = numbers[i];
                }
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }

        catch (OverflowException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine($"Второй наибольший элемент массива : {secondMaxValue}");

    }

}

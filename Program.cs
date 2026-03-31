using System;
using System.Collections.Generic;
using System.Text;

namespace s32429_apbd_cw1
{
    public class Program
    {
        public float CalculateAverage(int[] values)
        {
            float  avg = 0;

            for(int i = 0; i < values.Length; i++)
            {
                avg += values[i];
            }

            avg = (avg / values.Length);

            return avg;
        }

        public int CalculateMax(int[] values)
        {
            int max = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] > max)
                {
                    max = values[i];
                }
            }
            return max;
        }

        public int CalculateMin(int[] values)
        {
            int min = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] < min)
                {
                    min = values[i];
                }
            }
            return min;
        }

        public static void Main(string[] args)
        {
            int [] numbers = { 1, 2, 3, 4, 5, -6, 7 }; 
            try
            {
                var pawel = new Osoba("Paweł", "Kowalski", "90080375334");

                Console.WriteLine($"Imię: {pawel.Imie}");
                Console.WriteLine($"Nazwisko: {pawel.Nazwisko}");
                Console.WriteLine($"PESEL: {pawel.Pesel}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            int minValue = new Program().CalculateMin(numbers);
            Console.WriteLine($"Max value: {minValue}");
        }
    }
}
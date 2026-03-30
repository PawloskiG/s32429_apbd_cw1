using System;
using System.Collections.Generic;
using System.Text;

namespace s32429_apbd_cw1
{
    public class Program
    {
        public static void Main(string[] args)
        {

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
        }
    }
}
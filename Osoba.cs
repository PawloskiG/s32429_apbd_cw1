using System;
using System.Collections.Generic;
using System.Text;

namespace s32429_apbd_cw1
{
    public class Osoba
    {
        private string _imie;
        private string _nazwisko;
        private string _pesel;

        public Osoba(string imie, string nazwisko, string pesel)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Pesel = pesel;
        }

        public string Imie
        {
            get => _imie;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Imię nie może być puste.", nameof(Imie));
                _imie = value;
            }
        }

        public string Nazwisko
        {
            get => _nazwisko;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Nazwisko nie może być puste.", nameof(Nazwisko));
                _nazwisko = value;
            }
        }

        public string Pesel
        {
            get => _pesel;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("PESEL nie może być pusty.", nameof(Pesel));
                _pesel = value;
            }
        }
    }
}

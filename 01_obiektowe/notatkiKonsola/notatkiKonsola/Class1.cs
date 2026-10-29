using System;

namespace NotatkiKonsola
{
    // klasa Notatka polegająca na stworzeniu licznika i wyświetlenia notatki w odpowiedniej kolejności w consoli, pola = (licznik, id, tytól, treść, wyświetl, diagostyka, pobierzid, main), najprostrzy licznik i prosta diagnostyka polegająca na wypisaniu id numer notatki tytółu i treści notatki też wyśweitlanie notatek w konsoli, Jakub Grzegorzek
    class Notatka
    {
        private static int licznik = 0;

        private int id;

        protected string tytul;
        protected string tresc;

        public Notatka(string tytul, string tresc)
        {
            licznik++;
            this.id = licznik;
            this.tytul = tytul;
            this.tresc = tresc;
        }

        public void Wyswietl()
        {
            Console.WriteLine($"Tytuł: {tytul}");
            Console.WriteLine($"Treść: {tresc}");
            Console.WriteLine(); 
        }

        public void Diagnostyka()
        {
            Console.WriteLine($"ID: {id}; Licznik: {licznik}; Tytuł: {tytul}; Treść: {tresc}");
        }

        public int pobierzid()
        {
            return id;
        }

        public static int GetLicznik()
        {
            return licznik;
        }
        static void Main(string[] args)
        {
            Notatka notatka1 = new Notatka("Gry do skończenia", "Wiedzmin 3, Dying Light 2");
            Notatka notatka2 = new Notatka("Wymarzone Auta", "Ford Mustang, BMW M3");

            Console.WriteLine("Notatka 1:");
            notatka1.Wyswietl();

            Console.WriteLine("Notatka 2:");
            notatka2.Wyswietl();

            Console.WriteLine("Diagnostyka notatki 1:");
            notatka1.Diagnostyka();

            Console.WriteLine("Diagnostyka notatki 2:");
            notatka2.Diagnostyka();
        }
    }
}
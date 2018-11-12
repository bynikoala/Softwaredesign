using System;

namespace A04
{
    class Program
    {
        static void Main(string[] args)
        {
            Person mois = new Person("Nikosan", "Hack", new DateTime(1997, 06, 01));
            Person rob = new Person("Robinsan", "Schwab", new DateTime(2000, 01, 01));
            Person tomi = new Person("Tomisan", "Sever", new DateTime(1945, 01, 01));
            Person moin = new Person("Moin", "Hallo", new DateTime(1337, 1, 1));
            Person salle = new Person("Salle", "Sers", new DateTime(2018, 12, 01));
            Person[] array  = new Person[] {mois, rob, tomi, moin, salle};

            var today = DateTime.Today;
            for(int i = 0; i < array.Length; i++) {
                var age = today.Year - array[i].age.Year;
                if (array[i].age > today.AddYears(-age)) age--;

                if (age > 20) {
                    Console.WriteLine(array[i].ToString());
                }
            }
        }
    }
}
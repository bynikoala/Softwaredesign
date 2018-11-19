// using System;

// namespace Person {
//     class Person {
//         String FirstName;
//         String LastName;
//         DateTime Age;

//         public override string ToString() {
//             return $"Vorname: {FirstName}\nNachname: {LastName}\nAlter: {Age}";
//         }
        
//         static void Main(String[] args) {
//             Person Tomisan = new Person{FirstName = "Tomislav", LastName = "Sever", Age = new DateTime(1960, 15, 3)};
//             Person Robinsan = new Person{FirstName = "Robin", LastName = "Schwab", Age = new DateTime(1945, 3, 2)};
//             Person Nikusan = new Person{FirstName = "Niku", LastName = "San", Age = new DateTime(1997, 06, 01)};
//             Person Jonnarsan = new Person{FirstName = "Jona", LastName ="Wentz", Age = new DateTime(2000, 01, 01)};
//             Person Hola = new Person{FirstName = "Hola", LastName = "Senor", Age = new DateTime(2001, 08, 09)};            
//             Person[] personen = new Person[]{Tomisan, Robinsan, Nikusan, Jonnarsan, Hola};

//             foreach(Person moin in personen) {
                
//                 DateTime today = DateTime.Today;
//                 int age = today.Year - moin.Age.Year;
//                 if (moin.Age.Year > today.AddYears(-age)) age--;
                
//                 if(age >= 20) {

//                     Console.WriteLine(moin.ToString());
//                 }
//             }
//         }
//     }
// }
//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Lifeprojects.de">
//     Class: Program
//     Copyright © Lifeprojects.de 2025
// </copyright>
// <Template>
// 	Version 2.0.2025.0, 28.4.2025
// </Template>
//
// <author>Gerhard Ahrens - Lifeprojects.de</author>
// <email>developer@lifeprojects.de</email>
// <date>28.04.2025 20:15:48</date>
//
// <summary>
// Konsolen Applikation mit Menü
// </summary>
//-----------------------------------------------------------------------

namespace Console.FluentInterfaceDesign
{
    /* Imports from NET Framework */
    using System;
    using System.ComponentModel;

    public class Program
    {
        private static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("1. Create FluentContact");
                Console.WriteLine("X. Beenden");
                Console.WriteLine("Wählen Sie einen Menüpunkt oder 'x' für beenden");
                ConsoleKey key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.X)
                {
                    Environment.Exit(0);
                }
                else
                {
                    if (key == ConsoleKey.D1)
                    {
                        MenuPoint1();
                    }
                }
            }
            while (true);
        }

        private static void MenuPoint1()
        {
            Console.Clear();

            FluentContact obj = new FluentContact();

            obj.NameOfTheContact("Gerhard Ahrens")
                    .BornOf(new DateTime(1960,6,28))
                    .DeveloperOf("C#")
                    .Salery(5000)
                    .StateOf(true);
            obj.ShowDetails();

            Console.WriteLine("Mit einer beliebigen Taste zurück zum Menü!");
            Console.ReadKey();
        }
    }

    public class Contact
    {
        #region Properties
        public Guid Id { get; set; }

        public string FullName { get; set; }

        public string Developer { get; set; }

        public DateTime DateOfBirth { get; set; }

        public float Gehalt { get; set; }

        public bool Status { get; set; } 

        #endregion Properties
    }

    public class FluentContact
    {
        private Contact contact = new Contact();

        public FluentContact NameOfTheContact(string FullName)
        {
            contact.Id = Guid.NewGuid();
            contact.FullName = FullName;
            return this;
        }

        public FluentContact BornOf(DateTime DateOfBirth)
        {
            contact.DateOfBirth = Convert.ToDateTime(DateOfBirth);
            return this;
        }

        public FluentContact DeveloperOf(string developer)
        {
            contact.Developer = developer;
            return this;
        }

        public FluentContact Salery(float salery)
        {
            contact.Gehalt = salery;
            return this;
        }

        public FluentContact StateOf(bool state)
        {
            contact.Status = state;
            return this;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Name: {contact.FullName}, " +
                $"\nDateOfBirth: {contact.DateOfBirth}, " +
                $"\nDeveloper: {contact.Developer}, " +
                $"\nSalery: {contact.Gehalt}, " +
                $"\nStatus: {contact.Status}");
        }
    }
}

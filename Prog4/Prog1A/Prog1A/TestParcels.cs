//Grading ID:E1749
//Prog 4
//Due: 11/23/2020
//CIS 200-76
//display and sort for comparer and comparable

// File: TestParcels.cs
// This is a simple, console application designed to exercise the Parcel hierarchy.
// It creates several different Parcels and prints them.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Prog1
{
    class TestParcels
    {
        // Precondition:  None
        // Postcondition: Parcels have been created and displayed
        static void Main(string[] args)
        {
            // Test Data - Magic Numbers OK
            Address a1 = new Address("  John Smith  ", "   123 Any St.   ", "  Apt. 45 ",
                "  Louisville   ", "  KY   ", 40202); // Test Address 1
            Address a2 = new Address("Jane Doe", "987 Main St.",
                "Beverly Hills", "CA", 90210); // Test Address 2
            Address a3 = new Address("James Kirk", "654 Roddenberry Way", "Suite 321",
                "El Paso", "TX", 79901); // Test Address 3
            Address a4 = new Address("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4

            Letter letter1 = new Letter(a1, a2, 3.95M);                            // Letter test object
            Letter letter2 = new Letter(a2, a1, 4.67M);
            Letter letter3 = new Letter(a4, a3, 2.11M);
            GroundPackage gp1 = new GroundPackage(a3, a4, 14, 10, 5, 12.5);        // Ground test object
            GroundPackage gp2 = new GroundPackage(a1, a4, 16, 17, 6, 9.8);        // Ground test object
            GroundPackage gp3 = new GroundPackage(a3, a2, 9, 19, 5, 12.5);        // Ground test object

            NextDayAirPackage ndap1 = new NextDayAirPackage(a1, a3, 25, 15, 15,    // Next Day test object
                85, 7.50M);
            TwoDayAirPackage tdap1 = new TwoDayAirPackage(a4, a1, 46.5, 39.5, 28.0, // Two Day test object
                80.5, TwoDayAirPackage.Delivery.Saver);


            List<Parcel> parcels;      // List of test parcels

            parcels = new List<Parcel>();

            parcels.Add(letter1); // Populate list
            parcels.Add(letter2);
            parcels.Add(letter3);
            parcels.Add(gp1);
            parcels.Add(gp2);
            parcels.Add(gp3);
            parcels.Add(ndap1);
            parcels.Add(tdap1);
            

            WriteLine("****Original List:****");
            WriteLine("====================");
            foreach (Parcel p in parcels)
            {
                WriteLine(p);
                WriteLine("====================");
            }
            Pause();

            parcels.Sort();
            WriteLine("Sorted list in default order (w/ Comparer)");
            foreach (Parcel p in parcels)
                WriteLine(p);
            Pause();

            parcels.Sort(new DescendingOrder()); //sort by descending order class comparer
            WriteLine("Sorted list in descending default order (w/ Comparer)");
            foreach (Parcel p in parcels)
                WriteLine(p);
            Pause();

       }

        // Precondition:  None
        // Postcondition: Pauses program execution until user presses Enter and
        //                then clears the screen
        public static void Pause()
        {
            WriteLine("Press Enter to Continue...");
            ReadLine();

            Console.Clear(); // Clear screen
        }
    }
}

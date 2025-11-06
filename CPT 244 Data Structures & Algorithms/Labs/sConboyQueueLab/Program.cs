// Shawn Conboy
// CPT 244 A01H
// Queue Lab

using System;
using System.Collections.Generic;

namespace QueueLab
{
    class Program
    {
        // queue creation
        static Queue<Patient> patientLine = new Queue<Patient>();
        static int counter = 0;

        public static void Main(string[] args)
        {
            int userChoice = 0;

            while (userChoice != 3)
            {
                showMenu();

                // validate input safely
                bool validInput = int.TryParse(Console.ReadLine(), out userChoice);
                if (!validInput)
                {
                    Console.WriteLine("\nInvalid choice");
                    Console.ReadLine();
                    continue;
                }

                // void bad entries
                if (userChoice > 3 || userChoice < 1)
                {
                    Console.WriteLine("\nInvalid choice");
                    Console.ReadLine();
                    continue;
                }

                if (userChoice == 1)
                {
                    // create patient object
                    Patient newPatient = createPatient();
                    // add patient to queue
                    patientLine.Enqueue(newPatient);
                    counter++;
                    checkedIn();

                    // dequeue 1st person if 2 people are in line
                    if (counter % 2 == 0 && patientLine.Count > 0)
                    {
                        Patient served = patientLine.Dequeue();
                        Console.WriteLine($"{served.firstName} was called in.");
                    }

                    showNext();
                    Console.ReadLine();
                }

                if (userChoice == 2)
                {
                    // see waiting list
                    showQueue();
                }

                if (userChoice == 3)
                {
                    // show goodbye message
                    goodbye();
                }
            }
        }

        private static void checkedIn()
        {
            Console.Clear();
            Console.WriteLine("Thank you. You're checked in.");
            Console.WriteLine($"{patientLine.Count} patient(s) waiting.");
            Console.ReadLine();
        }

        private static void showMenu()
        {
            Console.Clear();
            Console.WriteLine("Hello. Welcome to Dr.Bone's ED Clinic.");
            Console.WriteLine("Please make a selection below.");
            Console.WriteLine();
            Console.WriteLine("1 Check In");
            Console.WriteLine("2 See Waiting List");
            Console.WriteLine("3 Exit");
        }

        private static Patient createPatient()
        {
            Console.Clear();

            Patient newPatient = new Patient();

            Console.WriteLine("Please enter your first name.");
            newPatient.firstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name.");
            newPatient.lastName = Console.ReadLine();

            Console.WriteLine("Please enter your date of birth.");
            newPatient.dob = Console.ReadLine();

            Console.WriteLine("Please state reason for visit.");
            newPatient.reasonForVisit = Console.ReadLine();

            return newPatient;
        }

        private static void showQueue()
        {
            Console.Clear();

            if (patientLine.Count == 0)
            {
                Console.WriteLine("No patients currently waiting.");
                Console.ReadLine();
                return;
            }
            else
            {
                Console.WriteLine("Waiting List\n");

                Console.WriteLine("Name\t\tReason For Visit");

                foreach (Patient person in patientLine)
                {
                    Console.WriteLine($"{person.firstName} {person.lastName} \t {person.reasonForVisit}");
                }
                Console.ReadLine();
            }
        }

        private static void showNext()
        {
            if (patientLine.Count > 0)
            {
                Patient next = patientLine.Peek();
                Console.WriteLine($"Next up: {next.firstName} {next.lastName}  {next.reasonForVisit}");
            }
            else
            {
                Console.WriteLine("\nNo one is currently waiting.");
            }
        }

        private static void goodbye()
        {
            Console.Clear();
            Console.WriteLine("Thank you. See you later.");
            Console.ReadLine();
        }
    }

    // class creation for patients
    class Patient
    {
        public string firstName = "";
        public string lastName = "";
        public string dob = "";
        public string reasonForVisit = "";
    }
}

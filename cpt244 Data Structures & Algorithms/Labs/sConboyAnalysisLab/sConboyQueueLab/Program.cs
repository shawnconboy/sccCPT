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
        static Queue<Patient> patientLine = new Queue<Patient>();                                       //1
        static int counter = 0;                                                                         //1

        public static void Main(string[] args)
        {
            int userChoice = 0;                                                                         //1

            while (userChoice != 3)                                                                     //n can go as many times as user wants
            {
                showMenu();                                                                             //1

                // validate input safely
                bool validInput = int.TryParse(Console.ReadLine(), out userChoice);                     //1
                if (!validInput)                                                                        //1 returns true or false
                {
                    Console.WriteLine("\nInvalid choice");                                              //1
                    Console.ReadLine();                                                                 //1
                    continue;                                                                           //1
                }

                // void bad entries
                if (userChoice > 3 || userChoice < 1)                                                   //1 returns true or false
                {
                    Console.WriteLine("\nInvalid choice");                                              //1
                    Console.ReadLine();                                                                 //1
                    continue;                                                                           //1
                }

                if (userChoice == 1)                                                                    //1 returns true or false
                {
                    // create patient object
                    Patient newPatient = createPatient();                                               //1
                    // add patient to queue
                    patientLine.Enqueue(newPatient);                                                    //1
                    counter++;                                                                          //1
                    checkedIn();                                                                        //1

                    // dequeue 1st person if 2 people are in line
                    if (counter % 2 == 0 && patientLine.Count > 0)                                      //1 returns true or false
                    {
                        Patient served = patientLine.Dequeue();                                         //1
                        Console.WriteLine($"{served.firstName} was called in.");                        //1
                    }

                    showNext();                                                                         //1
                    Console.ReadLine();                                                                 //1
                }                       

                if (userChoice == 2)                                                                    //1 returns true or false
                {
                    // see waiting list
                    showQueue();                                                                        //1
                }

                if (userChoice == 3)                                                                    //1 returns true or false
                {
                    // show goodbye message
                    goodbye();                                                                          //1
                }
            }
        }

        private static void checkedIn()                                                                 //1 sets up method
        {
            Console.Clear();                                                                            //1
            Console.WriteLine("Thank you. You're checked in.");                                         //1
            Console.WriteLine($"{patientLine.Count} patient(s) waiting.");                              //1
            Console.ReadLine();                                                                         //1
        }

        private static void showMenu()                                                                  //1 sets up method
        {
            Console.Clear();                                                                            //1
            Console.WriteLine("Hello. Welcome to Dr.Bone's ED Clinic.");                                //1
            Console.WriteLine("Please make a selection below.");                                        //1
            Console.WriteLine();                                                                        //1
            Console.WriteLine("1 Check In");                                                            //1
            Console.WriteLine("2 See Waiting List");                                                    //1
            Console.WriteLine("3 Exit");                                                                //1
        }

        private static Patient createPatient()                                                          //1 sets up method
        {
            Console.Clear();                                                                            //1

            Patient newPatient = new Patient();                                                         //1

            Console.WriteLine("Please enter your first name.");                                         //1
            newPatient.firstName = Console.ReadLine();                                                  //1

            Console.WriteLine("Please enter your last name.");                                          //1
            newPatient.lastName = Console.ReadLine();                                                   //1

            Console.WriteLine("Please enter your date of birth.");                                      //1
            newPatient.dob = Console.ReadLine();                                                        //1

            Console.WriteLine("Please state reason for visit.");                                        //1
            newPatient.reasonForVisit = Console.ReadLine();                                             //1

            return newPatient;                                                                          //1
        }

        private static void showQueue()                                                                 //1 sets up method
        {
            Console.Clear();                                                                            //1

            if (patientLine.Count == 0)                                                                 //1 returns true or false
            {
                Console.WriteLine("No patients currently waiting.");                                    //1
                Console.ReadLine();                                                                     //1
                return;                                                                                 //1
            }
            else                                                                                        //1
            {
                Console.WriteLine("Waiting List\n");                                                    //1
                
                Console.WriteLine("Name\t\tReason For Visit");                                          //1

                foreach (Patient person in patientLine)                                                 //n this is subjective on how many persons are in the patientLine
                {
                    Console.WriteLine($"{person.firstName} {person.lastName} \t {person.reasonForVisit}");//1
                }
                Console.ReadLine();                                                                     //1
            }
        }

        private static void showNext()                                                                  //1
        {
            if (patientLine.Count > 0)                                                                  //1 returns true or false
            {
                Patient next = patientLine.Peek();                                                      //1
                Console.WriteLine($"Next up: {next.firstName} {next.lastName}  {next.reasonForVisit}"); //1
            }
            else                                                                                        //1
            {
                Console.WriteLine("\nNo one is currently waiting.");                                    //1
            }
        }

        private static void goodbye()                                                                   //1
        {
            Console.Clear();                                                                            //1
            Console.WriteLine("Thank you. See you later.");                                             //1
            Console.ReadLine();                                                                         //1
        }
    }

    // class creation for patients
    class Patient                                                                                       //1
    {
        public string firstName = "";                                                                   //1
        public string lastName = "";                                                                    //1
        public string dob = "";                                                                         //1
        public string reasonForVisit = "";                                                              //1
    }
}

// overall, this was a simple project in terms of time complexity and computations

// the main function runs in a while loop. so however many times the user decides
// to run that over and over will still be based on that one decision. N.


// There's a nested loop that makes the showQueue method run in bigO(n)  Everything else
// either a basic statement or an if/else.

//*****************************************************

// how I can make this better?
// i Definitely could have used constructors to clean up the create patient function.
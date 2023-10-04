using System;

namespace OOP_Introduction
{
    class Person
    {
        public string firstName;
        public string lastName;
        public DateTime dateOfBirth;

        // static is an outlier, most times you wont include static
        public static string getGreeting()
        {
            return "Hello, how are you?";
        }

        // class variables as properties
        //public string firstName { get; set; }

        // static variables
        // public variables can be accessed by other classes
        // other: public/private (default)/protected
        // private: only current class can access this variable
        // protected: any class within namespace can access
        public static string salutationMr = "Mr";

        /// <summary>
        /// Method to return the person's name
        ///   in a printable version
        /// </summary>
        /// <returns>Person's full name</returns>
        public string getName()
        {
            return firstName + " " + lastName + " " + dateOfBirth.ToShortDateString();
        }   


        /// <summary>
        /// Default constructor
        /// </summary>
        public Person()
        {
            firstName = "John";
            lastName = "Doe";
        }

        /// <summary>
        /// A simple parametrized constructor
        /// </summary>
        /// <param name="lname">last name of the person</param>
        public Person(string lname)
        {
            lastName = lname;
        }
    }
}
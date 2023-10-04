using System.Diagnostics;

namespace OOP_Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            // initial access attempt
            Person Student = new Person
            {
                firstName = "John",
                lastName = "Doe",
                dateOfBirth = new DateTime(1994,11,10)
            };


            // after fixing access permissions
            // <class>.<item>
            // "run firstname method on student object"
            Debug.WriteLine(Student.firstName);
            Debug.WriteLine(Student.getName());
            
            // this works, but not Person.getName() because this is static. static is associated with class types
            // static keyword makes it unassociated with an object like "student" or "teacher"
            Debug.WriteLine(Person.getGreeting());

            // using the constructor
            Person Teacher = new Person();
            Person Manager = new Person("Jane");

            // passing by value
            int testVar1 = 3;
            int result1 = ModifyPrimitiveArgument(testVar1);
            Debug.WriteLine(testVar1 + " " + result1);

            // passing by reference
            Person testVar2 = new Person("Doe");
            Person result2 = ModifyObjectArgument(testVar2);
            Debug.WriteLine(testVar2.lastName + " " + result2.lastName);

            // using a child class
            Student Student1 = new Student();

            // interfaces
            GraduateStudent Grad = new GraduateStudent();
            Debug.WriteLine(Grad.Study());
        }

        static int ModifyPrimitiveArgument(int x)
        {
            x = 6;
            return x;
        }

        static Person ModifyObjectArgument(Person x)
        {
            x.lastName = "Dane";
            return x;
        }
    }
}
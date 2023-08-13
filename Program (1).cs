//Name: Nikita Bains
using System;

namespace Assignment 1
{
    class Program
    {
        static void Main()
        {   //ask the user to input age:
            Console.WriteLine("Please enter your age:");
            //get the input and convert to int
            int age = Convert.ToInt32(Console.ReadLine());
            //ask the user to input first name and get the input 
            Console.WriteLine("Please enter the patient's first name:");
            string firstName = Console.ReadLine();

            //ask the user to input last name and get the input 
            Console.WriteLine("Please enter the patient's last name:");
            string lastName = Console.ReadLine();

            //ask the user to input weight and get the input convert into double using ToDouble()
            Console.WriteLine("Please enter the patient's weight in KG:");
            double weight = Convert.ToDouble(Console.ReadLine());
            //ask the user to input height and get the input convert into double using ToDouble()
            Console.WriteLine("Please enter the patient's height in CM:");
            double height = Convert.ToDouble(Console.ReadLine());
            //ask the user to input systolic and get the input convert into int using ToInt32()
            Console.WriteLine("Please enter the systolic value for blood pressure:");
            int systolic = Convert.ToInt32(Console.ReadLine());
            //ask the user to input diastolic and get the input convert into int using ToInt32()
            Console.WriteLine("Please enter the diastolic value for blood pressure:");
            int diastolic = Convert.ToInt32(Console.ReadLine());
            //call the Patient with a new instance of the Patient 
            Patient patient = new Patient(firstName, lastName, weight, height);

            Console.WriteLine("\nPatient Information:");
            //call the patientInformation()
            patient.patientInformation(systolic, diastolic);
        }
    }
}

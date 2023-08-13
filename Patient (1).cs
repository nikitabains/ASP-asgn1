//Name: Nikita Bains
// Assignment 1
using System;
namespace Csharp_Assignment1
{
    public class Patient
    {
        // 4 properties using shorthand getter and setters
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }

        // to accept thefirst name, last name, weight, and height , i am creating a custom constructor.
        public Patient(string firstName, string lastName, double weight, double height)
        {
            FirstName = firstName;
            LastName = lastName;
            Weight = weight;
            Height = height;
        }

        // public method CalculateBloodPressure to calculate the blood pressure of the patient:
        public string CalculateBloodPressure(int systolic, int diastolic)
        {
            // an empty string called bloodPressureResult to assign value later
            string bloodPressureResult = "";
            //if the systolic is less than 120 and the dastolic is less than 80, it is normal
            if (systolic < 120 && diastolic < 80)
            {
                bloodPressureResult = "Normal";
            }
            //if the systolic is 120 - 129 (inclusively) and the dastolic is less than 80, it is elevated
            else if ((systolic >= 120 && systolic <= 129) && diastolic < 80)
            {
                bloodPressureResult ="Elevated";
            }
            //if the systolic is 130 - 139 (inclusively) OR the dastolic is 80 to 89(inclusively), it is stage 1
            else if ((systolic >= 130 && systolic <= 139) || (diastolic > 80 && diastolic < 89))
            {
                bloodPressureResult= "HIGH BLOOD PRESSURE (HYPERTENSION) STAGE 1";
            }
            //if the systolic is equal to or more than 140  OR the dastolic is equal to or more than 90, it is stage 2
            else if (systolic >= 140 || diastolic >= 90)
            {
                bloodPressureResult= "HIGH BLOOD PRESSURE (HYPERTENSION) STAGE 2";
            }
            //if the systolic is equal to or more than 180 OR the dastolic is equal to or more than 120, it is in crisis 
            else if (systolic >= 180 || diastolic >= 120)
            {
                bloodPressureResult= "HYPERTENSIVE CRISIS (consult your doctor immediately)";
            }
            return bloodPressureResult;//return the result
        }
        //Create a method CalculateBMI() to calculate the Body Mass Index(BMI)
        public double CalculateBMI()
        {
            double heightInMeters = Height / 100.0; // convert cm to m
            double bmi = Weight / (heightInMeters * heightInMeters);
            return bmi;
        }
        //Create a public method to show patient information
        public void patientInformation(int systolic, int diastolic)
        {
            //print the patient information using Console.WriteLine()
            Console.WriteLine($"Patinet Full Name: {FirstName} {LastName}");
            Console.WriteLine($"Weight: {Weight} Kg");
            Console.WriteLine($"Height: {Height} Cm");

            //use the method CalculateBloodPressure() and assign value to bloodPressureResult then print it
            string bloodPressureResult = CalculateBloodPressure(systolic, diastolic);
            Console.WriteLine($"Blood Pressure: {bloodPressureResult}");

            //use CalculateBMI() method 
            double bmi = CalculateBMI();
            // show BMI value with only two decimal places using ToString()
            Console.WriteLine($"BMI: {bmi.ToString("0.00")}"); 

            //create an empty string bmiStatus for assignment result later
            string bmiStatus = "";
            if (bmi <18.5)
            {
                bmiStatus = "Underweight";
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                bmiStatus = "Normal";
            }
            else if (bmi >= 25.0 && bmi <= 29.9)
            {
                bmiStatus = "Overweight";
            }
            else if (bmi >= 30.0 && bmi <= 34.9)
            {
                bmiStatus = "Obese class I";
            }
            else if (bmi >= 35.0 && bmi <= 39.9)
            {
                bmiStatus = "Obese class II";
            }
            else
            {
                bmiStatus = "Obese class III";
            }
            Console.WriteLine($"BMI Status: {bmiStatus}"); //print the BMI result
        }
    }
}

//Program 4
//CIS 199-50
//Due Date: 12/02/2024
//By: Helen Le

//This file consists of a Student class that represents a student at a university.
//The class will contain attributes and methods, and tracks a student's name, gpa, credit hours,
//classification, major, and enrollment status.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_4
{
    internal class Student
    {
        public const double DEFAULT_GPA = 4.0; //Default GPA
        public const int DEFAULT_CREDIT_HOURS = 12; //Default credit hours

        //Backing fields
        private string _name; //Stores student's name
        private double _gpa; //Stores student's GPA (Grade Point Average)
        private int _creditHours; //Stores student's credit hours
        private string _classification; //Stores student's classification
        private string _major; //Stores student's major
        private bool _enrollmentStatus; //Stores student's enrollment status

        //Constructor
        public Student(string name, double gpa, int creditHours, string classification, string major, bool enrollmentStatus)
        {
            //Backing field = parameter
            _name = name;
            _gpa = gpa;
            _creditHours = creditHours;
            _classification = classification;
            _major = major;
            _enrollmentStatus = enrollmentStatus;
        }

        public string Name 
        { 
            //Precondition: None
            //Postcondition: Returns student's name
            get { return _name; } 
            //Precondition: None
            //Postcondition: Sets student's name to provided value
            set { _name = value; }
        }

        public double GPA
        {
            //Precondition: None
            //Postcondition: Return student's GPA
            get { return _gpa; }
            set
            {
                //Precondition: 0.0 <= value <= 4.0
                //Postcondition: Sets GPA to valid value or to default of 4.0 if value is invalid
                if (value >= 0.0 && value <= 4.0)
                    _gpa = value;
                else
                    _gpa = DEFAULT_GPA;
            }
        }

        public int CreditHours
        {
            //Precondition: None
            //Postcondition: Returns the number of credit hours
            get { return _creditHours; }
            set
            {
                //Precondition: 0 <= value <= 18
                //Postcondition: Sets credit hours to valid value or defaults to 12 if value is invalid
                if (value >= 0 && value <= 18)
                    _creditHours = value;
                else
                    _creditHours = DEFAULT_CREDIT_HOURS;
            }
        }

        public string Classification
        {
            //Precondition: None
            get { return _classification; }
            //Postcondition: Returns the student's classification
            set { _classification = value; }
        }

        public string Major
        {
            //Precondition: None
            //Postcondition: Returns the student's major
            get { return _major; }
            //Precondition: None
            //Postcondition: Sets student's major to value
            set { _major = value; }
        }

        public void Enroll()
        {
            //Precondition: None
            //Postcondition: Sets student's enrollment status to true, meaning enrolled
            _enrollmentStatus = true;
        }

        public void Unenroll()
        {
            //Precondition: None
            //Postcondition: Sets student's enrollment status to false, meaning unenrolled
            _enrollmentStatus = false;
        }

        public bool IsEnrolled()
        {
            //Precondition: None
            //Postcondition: Returns current enrollment status (true or false)
            return _enrollmentStatus;
        }

        public override string ToString()
        {
            //Precondition: None
            //Postcondition: Returns a string representing the student's information
            return $"Name: {Name}{Environment.NewLine}" + 
                    $"GPA: {GPA:F1}{Environment.NewLine}" +
                    $"Credit Hours: {CreditHours}{Environment.NewLine}" +
                    $"Classification: {Classification}{Environment.NewLine}" +
                    $"Major: {Major}{Environment.NewLine}" +
                    $"Enrolled: {(_enrollmentStatus ? "True" : "False")}{Environment.NewLine}";
        }
    }
}

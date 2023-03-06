using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalCSharp
{
    public class Student
    {
        string firstName;
        string lastName;
        Node<Course> courses;

        public Student(string firstName, string lastName, Node<Course> courses)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.courses = courses;
        }
        public Student(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public Student(Student obj)
        {
            this.firstName = obj.firstName;
            this.lastName = obj.lastName;
            this.courses = obj.courses;
        }

        public void SetStudentFirstName(string firstName)
        {
            this.firstName = firstName;
        }
        public void SetStudentLastName(string lastName)
        {
            this.lastName = lastName;
        }
        public void SetStudentCourses(Node<Course> courses)
        {
            this.courses = courses;
        }


        public string GetFirstName()
        {
            return this.firstName;
        }
        public string GetLastName()
        {
            return this.lastName;
        }
        public Node<Course> GetCourses()
        {
            return this.courses;
        }

        public override string ToString()
        {
            return $"First Name : {this.firstName}\n" +
                $"Last Name : {this.lastName}\n" +
                $"Course :\n" +
                $"{this.courses}";
        }

        public double Average()
        {
            if (this.courses == null)
            {
                return 0;
            }
            double sumGrades = 0;
            double sumCoursse = 0;
            Node<Course> temp = new Node<Course>(this.courses);
            while (temp.GetValue() != null)
            {
                sumGrades = ((double)temp.GetValue().getCourseGrade()) + sumGrades;
                sumCoursse++;
                temp = temp.GetNext();
            }
            return sumGrades / sumCoursse;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalCSharp
{
    public class Course
    {
        private int courseCode;
        private int courseGrade;

        public int CourseCode { get { return courseCode; } set { courseCode = value; } }
        public int CourseGrade { get { return courseGrade; } set { courseGrade = value; } }
        public double getCourseGrade() { return courseGrade; }

        public Course(int courseCode, int courseGrade)
        {
            this.courseCode = courseCode;
            this.courseGrade = courseGrade;
        }

        public Course(Course other)
        {
            this.CourseCode = other.courseCode;
            this.courseGrade = other.courseGrade;
        }

        public override string ToString()
        {
            return $"courseCode = {courseCode} courseGrade = {courseGrade}";
        }

    }
}

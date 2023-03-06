using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalCSharp
{
    public class Worker : IComparable<Worker>
    {
        private string name;
        private double salary;

        public string Name { get { return name; } set { name = value; } }
        public double Salary { get { return salary; } set { salary = value; } }


        public Worker(string name, double salary)
        {
            this.name = name;
            this.salary = salary;
        }
        public Worker(Worker worker)
        {
            this.name = worker.Name;
            this.salary = worker.Salary;
        }

        public int CompareTo(Worker obj)
        {
            if (obj == null)
                return 1;

            if (this.salary > obj.salary)
                return 1;
            else if (this.salary < obj.salary)
                return -1;
            else
                return this.name.CompareTo(obj.name);
        }

        public override string ToString()
        {
            return $"Name = {this.name} , Salary = {this.salary}";
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (this == obj)
                return true;

            if (!(obj is Worker))
                return false;

            Worker w1 = (Worker)obj;

            if (this.name == w1.name && this.salary == w1.salary)//w1.Equals(w2);
            {
                return true;
            }

            return false;
        }
    }
}

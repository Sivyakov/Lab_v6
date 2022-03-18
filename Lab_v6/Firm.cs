using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_v6
{
 
        class Firm
        {
        public enum Status
        {
            подходит, не_подходит

        }
        private string name, insurance;
        private int age, salary, rating, index, index2;

        private Status status;
        public string Name
        {
            get { return name; }
            set { if (name != "") name = value; }
        }
        public int Age
        {
            get { return age; }
            set
            {
                age = value;
                if (age >= 5)
                {
                    index++;

                }
                Console.WriteLine($"{index}");
            }
        }
        public int Salary
        {
            get { return salary; }
            set
            {
                salary = value;
                if (salary > 70000)
                {
                    index++;
                }
            }
        }
        public int Rating
        {
            get { return rating; }
            set
            {
                rating = value;
                if (rating >= 3.5)
                {

                    index++;
                }

            }
        }
        public string Insurance
        {
            get { return insurance; }
            set
            {
                insurance = value;
                if (insurance == "да")
                {

                    index++;
                }
            }
        }
        public int Index
        {
            get { return index; }
        }
        public int Index2
        {
            get
            {
                return index2;

            }
            set
            {
                index2 = value;
                if (index2 > 2) status = Status.подходит;
                else status = Status.не_подходит;
            }

        }
        public Status GetStatus
        {
            get { return status; }
        }
    }
}


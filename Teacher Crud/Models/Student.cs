using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teacher_Crud.Models
{
    internal class Student : Person
    {
        internal Group Group { get; set; }

        internal DateTime EntryDate { get; set; }

        internal int Course { get; set; }

        internal string[] Subjects { get; set; } = new string[10];

        public override string ToString()
        {
            string subjects = "";

            Subjects[0] = "Literature";
            Subjects[1] = "Geography";
            Subjects[2] = "Mathematics";
            Subjects[3] = "Chemistry";
            Subjects[4] = "Biology";

            foreach (var item in Subjects)
            {
                if (item == null)
                    continue;

                subjects += item.ToString() + ",";
            }

            return $"Student ID: {Id}\nStudent FullName: {FirstName} {LastName} {FatherName}\nAge: {Age}\nGroup: {Group}\nEnter date: {EntryDate}\nCourse: {Course}\nSubjects:{subjects}\n";
        }
    }
}

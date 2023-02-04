using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teacher_Crud.Models
{
    internal class Teacher : Person
    {
        internal Group[] Groups { get; set; } = new Group[10];

        public override string ToString()
        {
            string groups = "";

            foreach (var item in Groups)
            {
                if (item == null)
                    continue;

                groups += item.ToString() + " ";
            }

            return $"Teacher ID: {Id}\nTeacher FullName: {FirstName} {LastName} {FatherName}\nAge: {Age}\nGroups: {groups}\n";
        }
    }

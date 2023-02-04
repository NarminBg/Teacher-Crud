using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teacher_Crud.Models
{
    internal class Group : Entity
    {

        public string Name { get; set; }

        public Student[] Students { get; set; } = new Student[50];

        public override string ToString()
        {
            string students = "";

            foreach (var item in Students)
            {
                if (item == null)
                    continue;

                students += item.ToString() + "";
            }

            return $"Group ID: {Id}\nGroup Name: {Name}\n Students:\n{students}";
        }
    }
}

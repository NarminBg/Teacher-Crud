using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teacher_Crud.Models;
using Teacher_Crud.Services.Contracts;

namespace Teacher_Crud.Services
{
    internal class TeacherManager : ICrudService, IPrintService
    {
        private Teacher[] _teachers = new Teacher[8];
        private int _currentIndex = 0;

        public void Add(Entity entity)
        {
            if (_currentIndex > 7)
            {
                Console.WriteLine("You can add only 8 teachers!");

                return;
            }

            _teachers[_currentIndex++] = (Teacher)entity;
            Console.WriteLine("Added!");
        }

        public void Delete(int id)
        {
            bool found = false;

            for (int i = 0; i < _teachers.Length; i++)
            {
                if (_teachers[i] == null)
                    continue;

                if (id == _teachers[i].Id)
                {
                    found = true;

                    for (int j = i; j < _teachers.Length - 1; j++)
                    {
                        _teachers[j] = _teachers[j + 1];
                    }
                    _currentIndex--;

                    Console.WriteLine("Deleted!");

                    return;
                }
            }

            if (!found)
            {
                Console.WriteLine("Not found!");
            }
        }

        public Entity Get(int id)
        {
            foreach (var item in _teachers)
            {
                if (item == null)
                    continue;

                if (item.Id == id)
                {
                    Console.Write(item);

                    return item;
                }
            }

            Console.WriteLine("Not found!");

            return null;
        }

        public Entity[] GetAll()
        {
            return _teachers;
        }

        public void Print()
        {
            foreach (var item in _teachers)
            {
                if (item == null)
                    continue;

                Console.WriteLine(item);
            }
        }

        public void Update(int id, Entity entity)
        {
            for (int i = 0; i < _teachers.Length; i++)
            {
                if (_teachers[i] == null)
                    continue;

                if (_teachers[i].Id == id)
                {
                    _teachers[i] = (Teacher)entity;
                    Console.WriteLine("Changed!");

                    return;
                }
            }

            Console.WriteLine("Not found");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teacher_Crud.Models;
using Teacher_Crud.Services.Contracts;

namespace Teacher_Crud.Services
{
    internal class DepartmentManager : ICrudService, IPrintService
    {
        private Department[] _departments = new Department[7];
        private int _currentIndex = 0;

        public void Add(Entity entity)
        {
            if (_currentIndex > 6)
            {
                Console.WriteLine("You can add only 7 departments");

                return;
            }

            _departments[_currentIndex++] = (Department)entity;
            Console.WriteLine("Added successfully");
        }

        public void Delete(int id)
        {
            bool found = false;

            for (int i = 0; i < _departments.Length; i++)
            {
                if (_departments[i] == null)
                    continue;

                if (id == _departments[i].Id)
                {
                    found = true;

                    for (int j = i; j < _departments.Length - 1; j++)
                    {
                        _departments[j] = _departments[j + 1];
                    }
                    _currentIndex--;

                    Console.WriteLine("Deleted successfully!");

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
            foreach (var item in _departments)
            {
                if (item == null)
                    continue;

                if (item.Id == id)
                {
                    Console.Write(item);

                    return item;
                }
            }

            Console.WriteLine("Department is not found!");

            return null;
        }

        public Entity[] GetAll()
        {
            return _departments;
        }

        public void Print()
        {
            foreach (var item in _departments)
            {
                if (item == null)
                    continue;

                Console.WriteLine(item);
            }
        }

        public void Update(int id, Entity entity)
        {
            for (int i = 0; i < _departments.Length; i++)
            {
                if (_departments[i] == null)
                    continue;

                if (_departments[i].Id == id)
                {
                    _departments[i] = (Department)entity;
                    Console.WriteLine("Department is changed");

                    return;
                }
            }

            Console.WriteLine("Not found");
        }
    }
}

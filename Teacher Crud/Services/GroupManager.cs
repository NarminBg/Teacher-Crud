using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teacher_Crud.Models;
using Teacher_Crud.Services.Contracts;

namespace Teacher_Crud.Services
{
    internal class GroupManager : ICrudService, IPrintService
    {
        private Group[] _groups = new Group[10];
        private int _currentIndex = 0;

        public void Add(Entity entity)
        {
            if (_currentIndex > 9)
            {
                Console.WriteLine("You can add only 10!");

                return;
            }

            _groups[_currentIndex++] = (Group)entity;
            Console.WriteLine("Added!");
        }

        public void Delete(int id)
        {
            bool found = false;

            for (int i = 0; i < _groups.Length; i++)
            {
                if (_groups[i] == null)
                    continue;

                if (id == _groups[i].Id)
                {
                    found = true;

                    for (int j = i; j < _groups.Length - 1; j++)
                    {
                        _groups[j] = _groups[j + 1];
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
            foreach (var item in _groups)
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
            return _groups;
        }

        public void Print()
        {
            foreach (var item in _groups)
            {
                if (item == null)
                    continue;

                Console.WriteLine(item);
            }
        }

        public void Update(int id, Entity entity)
        {
            for (int i = 0; i < _groups.Length; i++)
            {
                if (_groups[i] == null)
                    continue;

                if (_groups[i].Id == id)
                {
                    _groups[i] = (Group)entity;
                    Console.WriteLine("Changed successfully!");

                    return;
                }
            }

            Console.WriteLine("Not found");
        }

    }
}

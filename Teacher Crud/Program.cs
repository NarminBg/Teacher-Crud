using Teacher_Crud.Models;
using Teacher_Crud.Services;

namespace Teacher_Crud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var studentManager = new StudentManager();
            var groupManager = new GroupManager();
            var teacherManager = new TeacherManager();
            var departmentMangaer = new DepartmentManager();
            string command = "";

            do
            {
                Console.Write("Enter the command:");
                command = Console.ReadLine();

                if (command.ToLower().Equals("add group"))
                {
                    var group1 = new Group
                    {
                        Id = 1,
                        Name = "K743",
                        Students = new Student[]
                        {
                          (Student)studentManager.Get(1),
                          (Student)studentManager.Get(2),
                          (Student)studentManager.Get(3),
                        },
                    };

                    var group2 = new Group
                    {
                        Id = 2,
                        Name = "J231",
                        Students = new Student[]
                        {
                           (Student)studentManager.Get(4),
                           (Student)studentManager.Get(5),
                        },
                    };

                    var group3 = new Group
                    {
                        Id = 3,
                        Name = "G121",
                        Students = new Student[]
                        {
                           (Student)studentManager.Get(6),
                           (Student)studentManager.Get(7),
                        },
                    };

                    groupManager.Add(group1);
                    groupManager.Add(group2);
                    groupManager.Add(group3);
                }

                else if (command.ToLower().Equals("print groups"))
                {
                    groupManager.Print();
                }

                else if (command.ToLower().Equals("delete group"))
                {
                    Console.Write("ID:");
                    var id = int.Parse(Console.ReadLine());

                    groupManager.Delete(id);
                }

                else if (command.ToLower().Equals("get group"))
                {
                    Console.Write("ID:");
                    var id = int.Parse(Console.ReadLine());

                    groupManager.Get(id);
                }

                else if (command.ToLower().Equals("update group"))
                {
                    Console.Write("ID:");
                    var id = int.Parse(Console.ReadLine());

                    var existGroup = groupManager.Get(id);

                    if (existGroup == null)
                        continue;

                    Console.WriteLine(existGroup);

                    var group1 = new Teacher
                    {
                        Id = 1,
                        FirstName = "Calal",
                        LastName = "Hasanli",
                        Age = 33,
                    };

                    groupManager.Update(id, group1);
                }

                else if (command.ToLower().Equals("add student"))
                {
                    var student1 = new Student
                    {
                        Id = 1,
                        FirstName = "Narmin",
                        LastName = "Bagirova",
                        Age = 23,
                        Course = 3,
                        EntryDate = DateTime.Now,
                    };

                    var student2 = new Student
                    {
                        Id = 2,
                        FirstName = "Reshad",
                        LastName = "Ahmedov",
                        Age = 22,
                        Course = 1,
                        EntryDate = DateTime.Now,
                    };

                    var student3 = new Student
                    {
                        Id = 3,
                        FirstName = "Alina",
                        LastName = "Rzayeva",
                        Age = 25,
                        Course = 4,
                        EntryDate = DateTime.Now,

                    };

                    var student4 = new Student
                    {
                        Id = 4,
                        FirstName = "Elmira",
                        LastName = "Aghayeva",
                        Age = 20,
                        Course = 1,
                        EntryDate = DateTime.Now,
                    };
                    var student5 = new Student
                    {
                        Id = 5,
                        FirstName = "Emin",
                        LastName = "Aliyarov",
                        Age = 23,
                        Course = 3,
                        EntryDate = DateTime.Now,
                    };

                    studentManager.Add(student1);
                    studentManager.Add(student2);
                    studentManager.Add(student3);
                    studentManager.Add(student4);
                    studentManager.Add(student5);
                }

                else if (command.ToLower().Equals("print students"))
                {
                    studentManager.Print();
                }

                else if (command.ToLower().Equals("delete student"))
                {
                    Console.Write("ID: ");
                    var id = int.Parse(Console.ReadLine());

                    studentManager.Delete(id);
                }

                else if (command.ToLower().Equals("get student"))
                {
                    Console.Write("ID: ");
                    var id = int.Parse(Console.ReadLine());

                    studentManager.Get(id);
                }

                else if (command.ToLower().Equals("update student"))
                {
                    Console.Write("ID: ");
                    var id = int.Parse(Console.ReadLine());

                    var existStudent = studentManager.Get(id);

                    if (existStudent == null)
                        continue;

                    Console.WriteLine(existStudent);
                    var student3 = new Student
                    {
                        Id = 3,
                        FirstName = "Alina",
                        LastName = "Rzayeva",
                        Age = 25,
                        Course = 4,
                        EntryDate = DateTime.Now,

                    };
                    studentManager.Update(id, student3);
                }

                else if (command.ToLower().Equals("add teacher"))
                {
                    var teacher1 = new Teacher
                    {
                        Id = 1,
                        FirstName = "Calal",
                        LastName = "Hasanli",
                        Age = 33,
                        Groups = new Group[]
                        {
                           (Group)groupManager.Get(3),
                        },

                    };

                    var teacher2 = new Teacher
                    {
                        Id = 2,
                        FirstName = "Pervin",
                        LastName = "Qasimov",
                        Age = 32,
                        Groups = new Group[]
                        {
                            (Group)groupManager.Get(1),
                            (Group)groupManager.Get(2),
                        },

                    };

                    teacherManager.Add(teacher1);
                    teacherManager.Add(teacher2);
                }

                else if (command.ToLower().Equals("print teachers"))
                {
                    teacherManager.Print();
                }

                else if (command.ToLower().Equals("delete teacher"))
                {
                    Console.Write("ID:");
                    var id = int.Parse(Console.ReadLine());

                    teacherManager.Delete(id);
                }

                else if (command.ToLower().Equals("get teacher"))
                {
                    Console.Write("ID:");
                    var id = int.Parse(Console.ReadLine());

                    teacherManager.Get(id);
                }

                else if (command.ToLower().Equals("update teacher"))
                {
                    Console.Write("ID-ni qeyd edin: ");
                    var id = int.Parse(Console.ReadLine());

                    var existTeacher = teacherManager.Get(id);

                    if (existTeacher == null)
                        continue;

                    Console.WriteLine(existTeacher);

                    var teacher1 = new Teacher
                    {
                        Id = 1,
                        FirstName = "Calal",
                        LastName = "Hasanli",
                        Age = 33,
                    };

                    teacherManager.Update(id, teacher1);
                }

                else if (command.ToLower().Equals("add department"))
                {
                    var department1 = new Department
                    {
                        Id = 1,
                        Name = "Humanitar",
                        Teachers = new Teacher[]
                        {
                            (Teacher)teacherManager.Get(1),
                            (Teacher)teacherManager.Get(2),
                        },
                        Leader = new Person
                        {
                            Id = 1,
                            FirstName = "Elza",
                            LastName = "Ibrahimli",
                            Age = 46,
                        },
                    };

                    var department2 = new Department
                    {
                        Id = 2,
                        Name = "IT Technology",
                        Teachers = new Teacher[]
                        {
                            (Teacher)teacherManager.Get(2),
                        },
                        Leader = new Person
                        {
                            Id = 2,
                            FirstName = "Huseyn",
                            LastName = "Nasibli",
                            Age = 45,
                        },
                    };

                    departmentMangaer.Add(department1);
                    departmentMangaer.Add(department2);
                }

                else if (command.ToLower().Equals("print departments"))
                {
                    departmentMangaer.Print();
                }

                else if (command.ToLower().Equals("delete department"))
                {
                    Console.Write("ID:");
                    var id = int.Parse(Console.ReadLine());

                    departmentMangaer.Delete(id);
                }

                else if (command.ToLower().Equals("get department"))
                {
                    Console.Write("ID: ");
                    var id = int.Parse(Console.ReadLine());

                    departmentMangaer.Get(id);
                }

                else if (command.ToLower().Equals("update department"))
                {
                    Console.Write("ID:");
                    var id = int.Parse(Console.ReadLine());

                    var existDepartment = departmentMangaer.Get(id);

                    if (existDepartment == null)
                        continue;

                    Console.WriteLine(existDepartment);

                    var department1 = new Teacher
                    {
                        Id = 1,
                        FirstName = "Calal",
                        LastName = "Hasanli",
                        Age = 33,
                    };

                    departmentMangaer.Update(id, department1);
                }

            } while (command.ToLower() != "quit");
        }
    }
}
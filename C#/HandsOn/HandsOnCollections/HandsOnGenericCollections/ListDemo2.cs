using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace HandsOnGenericCollections
{
    class Student
    {
        public int Sid { get; set; }
        public string Sname { get; set; }
        public int Age { get; set; }
    }
    interface IStudentRepository
    {
       void AddStudent(Student item);
        List<Student> GetStudents();
        Student GetStudentById(int id);
    }
    class StudentReposiotry : IStudentRepository
    {
        List<Student> list = new List<Student>();
        public void AddStudent(Student item)
        {
            list.Add(item);
        }

        public Student GetStudentById(int id)
        {
            foreach(var item in list)
            {
                if (item.Sid == id)
                    return item;
            }
            return null;
        }

        public List<Student> GetStudents()
        {
            return list;
        }
    }
    class ListDemo2
    {
        static void Main()
        {
           //Write Menu driven code to test the StudentRepository functions
        }
    }
}

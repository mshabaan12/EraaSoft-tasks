using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace TaskLec7_school_
{//student management system
    class Student
    {
        public Student(int id, string name, int age, List<Cource> courses)
        {
            Id = id;
            Name = name;
            Age = age;
            Courses = courses;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int  Age { get; set; }
        public List<Cource> Courses { get; set;} = new List<Cource>();
        public bool Enroll(Cource cource)
        {
            if (!Courses.Contains(cource))
            {
                Courses.Add(cource);
                return true;
            }
            return false;
        }
        public string Printdetails ()
        {
            string courseList = Courses.Count > 0 ?
            string.Join(", ", Courses.Select(c => c.Title)) : "No Courses";
            return $"Student ID: {Id}, Name: {Name}, Age: {Age}, Courses: {courseList}";



        }
    
    }
    class Instractor
    {
        public Instractor(int id, string name, string specialization)
        {
            Id = id;
            Name = name;
            Specialization = specialization;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }

        public string printdetails ()
        {
            return $"Instructor ID: {Id}, Name: {Name}, Specialization: {Specialization}";
        }
    }
    class Cource
    {
        public Cource(int id, string title, Instractor instractor)
        {
            this.id = id;
            this.Title = title;
            this.instractor = instractor;
        }

        public int id { get; set; }
        public string Title  { get; set; }
        public Instractor instractor { get; set; }
        public List<Cource> printDetails()
        {

            return $"Course ID: {id}, Title: {Title}, Instructor: {Instractor.Name}";


        }

    }
    internal class Program
    {
        static void Main(string[] args)
        { Instractor inst1 = new Instractor(33, "bahaa", "c#");
            Cource cource1 = new Cource(22, "c#", inst1);
            // genereate object 
            Student student1 = null;

            List<Cource> courses = new List<Cource>
    {
        new Cource(1, "Math 101", inst1),
        new Cource(2, "Physics 101", inst1),
        new Cource(3, "Chemistry 101", inst1)
    };


            Student s1 = new Student(5, "malek", 25, courses);
            student1.Printdetails();
            

        }
    }
}

namespace training
{ 
    public class Instractor
    {
        public int InstractorId { get; set; }
        public string Name  { get; set; }
        public string Specialization { get; set; }
        public string Printdetails()
        {
            return $"InstractorId : {InstractorId},Name : {Name},Specialization : {Specialization}";
        }

    }
 public class Course
    {
       public int CourseId { get; set; }
        public string  Title { get; set; }
        public Instractor instractor { get; set; }
        public string Printdetails()
        { if (instractor.Name == null)
                return $" CourseId : {CourseId}, Title : {Title} , instractor : {"no instractor "} ";
            else return $" CourseId : {CourseId}, Title : {Title} , instractor : {instractor.Name} ";
        }
    }
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Course> Courses { get; set; } = new List<Course>();
        public bool Enroll(Course course)
        {
            if (Courses.Contains(course))
            {
                Console.WriteLine("the studente is ollready enroll");
                return false;
            }
            else
                Courses.Add(course);
            return true;
        }
        public string Printdetails()
        {
            if (Courses.Count == 0)
            {
              return $"StudentId : {StudentId}, Name :{Name}, Age : {Age} ,Courses : {"no cources yet "} ";
            }
            else
            {
                return $"StudentId : {StudentId}, Name :{Name}, Age : {Age} ,Courses : {Courses} ";
            }
        }

    }
    public class School
    {
        public List<Course> Courses { get; set; } = new List<Course>();
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Instractor> Instractors { get; set; } = new List<Instractor> { };
        public bool AddStudent(Student student)
        {
            if (Students.Contains(student))
            {
                return false;
            }
            else
            {
                Students.Add(student);
                return true;
            }
        }
        public bool AddCourse(Course course)
        {
            if (Courses.Contains(course))
            {
                return false;
            }
            else
            {
                Courses.Add(course);
                return true;
            }
        }
        public bool AAddInstructor(Instractor instructor)
        {
            if (Instractors.Contains(instructor))
            {
                return false;
            }
            else
            {
                Instractors.Add(instructor);
                return true;
            }
        }
        public Student FindStudent(int studentId)
        {
            return   
        }

    }

    internal class Program
    {
    
        
        static void Main(string[] args)
        {
            Student student1 = new Student();
            Course course1 = new Course { CourseId = 1 , Title ="c#",};
            Instractor instractor1 = new Instractor
            {
                InstractorId = 3,
                Name = "ali",
                Specialization = "c#",
            };
            student1.Name = "mo";
            student1.Age = 66;
            student1.Courses = new List<Course>();
            Console.WriteLine( instractor1.Printdetails());
            student1.Printdetails();
            



        }
    }
}

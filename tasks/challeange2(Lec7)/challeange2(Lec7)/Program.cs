namespace challeange2_Lec7_
{ 
    class Person
    {
        public Person(string name, int age, string address, string nationlity)
        {
            Name = name;
            Age = age;
            Address = address;
            Nationlity = nationlity;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Nationlity { get; set; }
    }
    class Student:Person
    {
        public Student(string name, int age, string address, string nationlity, string study_level, string specialization,
            double gpa) : base(name,age,address,nationlity) 
        {
            Study_level = study_level;
            Specialization = specialization;
            Gpa = gpa;
        }

        public string Study_level {  get; set; }
        public string Specialization {  get; set; }
        public double Gpa {  get; set; }


    }
    class Employee:Person
    {
        public Employee(string name, int age, string address, string nationlity, double salary, 
            int rank, string job):base(name,age,address,nationlity)
        {
            Salary = salary;
            Rank = rank;
            Job = job;
        }

        public double Salary {  get; set; }
        public int Rank { get; set; }
        public string Job {  get; set; }
    }
        internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("malek", 24, "sadat", "egyptin", "a", "ggg", 3.3);
            Console.WriteLine(student1.Name);
        }
    }
}

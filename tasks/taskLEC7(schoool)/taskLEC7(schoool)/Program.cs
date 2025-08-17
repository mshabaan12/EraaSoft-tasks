namespace taskLEC7.school;
using System;
using System.Collections.Generic;
using System.Linq;

// Course, Instructor, and Student classes
public class Course
{
    public int CourseId { get; set; }
    public string Title { get; set; }
    public Instructor Instructor { get; set; }

    public string PrintDetails()
    {
        return $"Course ID: {CourseId}, Title: {Title}, Instructor: {(Instructor != null ? Instructor.Name : "N/A")}";
    }
}

public class Instructor
{
    public int InstructorId { get; set; }
    public string Name { get; set; }
    public string Specialization { get; set; }

    public string PrintDetails()
    {
        return $"Instructor ID: {InstructorId}, Name: {Name}, Specialization: {Specialization}";
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
        if (course == null) return false;
        if (Courses.Any(c => c.CourseId == course.CourseId))
        {
            return false;
        }
        Courses.Add(course);
        return true;
    }

    public string PrintDetails()
    {
        string courseTitles = Courses.Count > 0 ? string.Join(", ", Courses.Select(c => c.Title)) : "No courses enrolled";
        return $"Student ID: {StudentId}, Name: {Name}, Age: {Age}, Enrolled Courses: {courseTitles}";
    }
}


public class StudentManager
{
    public List<Student> Students { get; set; } = new List<Student>();
    public List<Course> Courses { get; set; } = new List<Course>();
    public List<Instructor> Instructors { get; set; } = new List<Instructor>();

    public bool AddStudent(Student student)
    {
        if (Students.Any(s => s.StudentId == student.StudentId)) return false;
        Students.Add(student);
        return true;
    }

    public bool AddCourse(Course course)
    {
        if (Courses.Any(c => c.CourseId == course.CourseId)) return false;
        Courses.Add(course);
        return true;
    }

    public bool AddInstructor(Instructor instructor)
    {
        if (Instructors.Any(i => i.InstructorId == instructor.InstructorId)) return false;
        Instructors.Add(instructor);
        return true;
    }

    public Student FindStudent(int studentId)
    {
        return Students.FirstOrDefault(s => s.StudentId == studentId);
    }

    public Student FindStudent(string name)
    {
        return Students.FirstOrDefault(s => s.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }

    public Course FindCourse(int courseId)
    {
        return Courses.FirstOrDefault(c => c.CourseId == courseId);
    }

    public Course FindCourse(string title)
    {
        return Courses.FirstOrDefault(c => c.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
    }

    public Instructor FindInstructor(int instructorId)
    {
        return Instructors.FirstOrDefault(i => i.InstructorId == instructorId);
    }

    public bool EnrollStudentInCourse(int studentId, int courseId)
    {
        var student = FindStudent(studentId);
        var course = FindCourse(courseId);

        if (student == null || course == null) return false;

        return student.Enroll(course);
    }

    public bool IsStudentEnrolled(int studentId, int courseId)
    {
        var student = FindStudent(studentId);
        if (student == null) return false;
        return student.Courses.Any(c => c.CourseId == courseId);
    }

    public string GetInstructorNameByCourse(string courseTitle)
    {
        var course = FindCourse(courseTitle);
        return course?.Instructor?.Name ?? "Instructor not found or not assigned.";
    }

    public bool UpdateStudent(Student updatedStudent)
    {
        var student = FindStudent(updatedStudent.StudentId);
        if (student == null) return false;
        student.Name = updatedStudent.Name;
        student.Age = updatedStudent.Age;
        return true;
    }

    public bool DeleteStudent(int studentId)
    {
        var student = FindStudent(studentId);
        if (student == null) return false;
        return Students.Remove(student);
    }

    public void ViewAllStudents()
    {
        if (Students.Count == 0)
        {
            Console.WriteLine("No students to display.");
            return;
        }
        Students.ForEach(s => Console.WriteLine(s.PrintDetails()));
    }

    public void ViewAllCourses()
    {
        if (Courses.Count == 0)
        {
            Console.WriteLine("No courses to display.");
            return;
        }
        Courses.ForEach(c => Console.WriteLine(c.PrintDetails()));
    }

    public void ViewAllInstructors()
    {
        if (Instructors.Count == 0)
        {
            Console.WriteLine("No instructors to display.");
            return;
        }
        Instructors.ForEach(i => Console.WriteLine(i.PrintDetails()));
    }
}


public class Program
{
    private static StudentManager manager = new StudentManager();

    public static void Main(string[] args)
    {
        bool isRunning = true;
        while (isRunning)
        {
            ShowMenu();
            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1: AddStudent(); break;
                    case 2: AddInstructor(); break;
                    case 3: AddCourse(); break;
                    case 4: EnrollStudentInCourse(); break;
                    case 5: manager.ViewAllStudents(); break;
                    case 6: manager.ViewAllCourses(); break;
                    case 7: manager.ViewAllInstructors(); break;
                    case 8: FindStudentByIdOrName(); break;
                    case 9: FindCourseByIdOrName(); break;
                    case 10: isRunning = false; break;
                    case 11: CheckStudentEnrollment(); break;
                    case 12: GetInstructorByCourse(); break;
                    case 13: UpdateStudentInformation(); break;
                    case 14: DeleteStudent(); break;
                    default: Console.WriteLine("Invalid choice. Please try again."); break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
            Console.WriteLine();
        }
    }

    private static void ShowMenu()
    {
        Console.WriteLine("=====================================");
        Console.WriteLine("       Student Management System     ");
        Console.WriteLine("=====================================");
        Console.WriteLine("1. Add Student");
        Console.WriteLine("2. Add Instructor");
        Console.WriteLine("3. Add Course");
        Console.WriteLine("4. Enroll Student in Course");
        Console.WriteLine("5. View All Students");
        Console.WriteLine("6. View All Courses");
        Console.WriteLine("7. View All Instructors");
        Console.WriteLine("8. Find Student by ID or Name");
        Console.WriteLine("9. Find Course by ID or Name");
        Console.WriteLine("10. Exit");
        Console.WriteLine("--- Bonus ---");
        Console.WriteLine("11. Check if Student is Enrolled in a Specific Course");
        Console.WriteLine("12. Get Instructor Name by Course Name");
        Console.WriteLine("13. Update Student Information");
        Console.WriteLine("14. Delete Student");
        Console.Write("Enter your choice: ");
    }

    private static void AddStudent()
    {
        Console.Write("Enter Student ID: ");
        if (!int.TryParse(Console.ReadLine(), out int id)) { Console.WriteLine("Invalid ID."); return; }
        Console.Write("Enter Student Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Student Age: ");
        if (!int.TryParse(Console.ReadLine(), out int age)) { Console.WriteLine("Invalid Age."); return; }

        var newStudent = new Student { StudentId = id, Name = name, Age = age };
        if (manager.AddStudent(newStudent))
        {
            Console.WriteLine("Student added successfully.");
        }
        else
        {
            Console.WriteLine("Failed to add student. A student with this ID already exists.");
        }
    }

    private static void AddInstructor()
    {
        Console.Write("Enter Instructor ID: ");
        if (!int.TryParse(Console.ReadLine(), out int id)) { Console.WriteLine("Invalid ID."); return; }
        Console.Write("Enter Instructor Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Specialization: ");
        string specialization = Console.ReadLine();

        var newInstructor = new Instructor { InstructorId = id, Name = name, Specialization = specialization };
        if (manager.AddInstructor(newInstructor))
        {
            Console.WriteLine("Instructor added successfully.");
        }
        else
        {
            Console.WriteLine("Failed to add instructor. An instructor with this ID already exists.");
        }
    }

    private static void AddCourse()
    {
        Console.Write("Enter Course ID: ");
        if (!int.TryParse(Console.ReadLine(), out int courseId)) { Console.WriteLine("Invalid ID."); return; }
        Console.Write("Enter Course Title: ");
        string title = Console.ReadLine();
        Console.Write("Enter Instructor ID (optional, leave blank if none): ");
        string instructorIdInput = Console.ReadLine();

        Instructor instructor = null;
        if (!string.IsNullOrEmpty(instructorIdInput) && int.TryParse(instructorIdInput, out int instructorId))
        {
            instructor = manager.FindInstructor(instructorId);
            if (instructor == null)
            {
                Console.WriteLine("Instructor not found. Course will be created without an instructor.");
            }
        }

        var newCourse = new Course { CourseId = courseId, Title = title, Instructor = instructor };
        if (manager.AddCourse(newCourse))
        {
            Console.WriteLine("Course added successfully.");
        }
        else
        {
            Console.WriteLine("Failed to add course. A course with this ID already exists.");
        }
    }

    private static void EnrollStudentInCourse()
    {
        Console.Write("Enter Student ID: ");
        if (!int.TryParse(Console.ReadLine(), out int studentId)) { Console.WriteLine("Invalid Student ID."); return; }
        Console.Write("Enter Course ID: ");
        if (!int.TryParse(Console.ReadLine(), out int courseId)) { Console.WriteLine("Invalid Course ID."); return; }

        if (manager.EnrollStudentInCourse(studentId, courseId))
        {
            Console.WriteLine("Student enrolled in course successfully.");
        }
        else
        {
            Console.WriteLine("Failed to enroll student. Check if student or course IDs are correct or if the student is already enrolled.");
        }
    }

    private static void FindStudentByIdOrName()
    {
        Console.Write("Enter Student ID or Name: ");
        string input = Console.ReadLine();
        Student student = null;
        if (int.TryParse(input, out int id))
        {
            student = manager.FindStudent(id);
        }
        else
        {
            student = manager.FindStudent(input);
        }

        if (student != null)
        {
            Console.WriteLine("Student found:");
            Console.WriteLine(student.PrintDetails());
        }
        else
        {
            Console.WriteLine("Student not found.");
        }
    }

    private static void FindCourseByIdOrName()
    {
        Console.Write("Enter Course ID or Title: ");
        string input = Console.ReadLine();
        Course course = null;
        if (int.TryParse(input, out int id))
        {
            course = manager.FindCourse(id);
        }
        else
        {
            course = manager.FindCourse(input);
        }

        if (course != null)
        {
            Console.WriteLine("Course found:");
            Console.WriteLine(course.PrintDetails());
        }
        else
        {
            Console.WriteLine("Course not found.");
        }
    }

    private static void CheckStudentEnrollment()
    {
        Console.Write("Enter Student ID: ");
        if (!int.TryParse(Console.ReadLine(), out int studentId)) { Console.WriteLine("Invalid Student ID."); return; }
        Console.Write("Enter Course ID: ");
        if (!int.TryParse(Console.ReadLine(), out int courseId)) { Console.WriteLine("Invalid Course ID."); return; }

        if (manager.IsStudentEnrolled(studentId, courseId))
        {
            Console.WriteLine("Yes, the student is enrolled in this course.");
        }
        else
        {
            Console.WriteLine("No, the student is not enrolled in this course or the IDs are incorrect.");
        }
    }

    private static void GetInstructorByCourse()
    {
        Console.Write("Enter Course Title: ");
        string courseTitle = Console.ReadLine();
        string instructorName = manager.GetInstructorNameByCourse(courseTitle);
        Console.WriteLine($"Instructor Name: {instructorName}");
    }

    private static void UpdateStudentInformation()
    {
        Console.Write("Enter Student ID to update: ");
        if (!int.TryParse(Console.ReadLine(), out int id)) { Console.WriteLine("Invalid ID."); return; }

        var studentToUpdate = manager.FindStudent(id);
        if (studentToUpdate == null)
        {
            Console.WriteLine("Student not found.");
            return;
        }

        Console.WriteLine($"Updating Student: {studentToUpdate.Name}");
        Console.Write($"Enter new name (current: {studentToUpdate.Name}, leave blank to keep): ");
        string newName = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(newName))
        {
            studentToUpdate.Name = newName;
        }

        Console.Write($"Enter new age (current: {studentToUpdate.Age}, leave blank to keep): ");
        string newAgeInput = Console.ReadLine();
        if (int.TryParse(newAgeInput, out int newAge))
        {
            studentToUpdate.Age = newAge;
        }

        if (manager.UpdateStudent(studentToUpdate))
        {
            Console.WriteLine("Student information updated successfully.");
        }
        else
        {
            Console.WriteLine("Failed to update student information.");
        }
    }

    private static void DeleteStudent()
    {
        Console.Write("Enter Student ID to delete: ");
        if (!int.TryParse(Console.ReadLine(), out int id)) { Console.WriteLine("Invalid ID."); return; }

        if (manager.DeleteStudent(id))
        {
            Console.WriteLine("Student deleted successfully.");
        }
        else
        {
            Console.WriteLine("Failed to delete student. Student not found.");
        }
    }
} 

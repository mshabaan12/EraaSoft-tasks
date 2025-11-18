// See https://aka.ms/new-console-template for more information
using ahmedmohamdytrainig.Model;
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Hello, World!");
using var db = new AppDbContext();
var department = new Department();
{
    department.Name = "mo";
  department.Des = "1234567";
}
var context = new ValidationContext(department);
var errors  = new List<ValidationResult>();
if(!Validator.TryValidateObject(department,context,errors,true))
{
    foreach(var error in errors)
    {
        Console.WriteLine(error);
    }
}
else
{
   db.Add(department);
   db.SaveChanges();
}



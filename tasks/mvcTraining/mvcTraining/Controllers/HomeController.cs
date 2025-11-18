using Microsoft.AspNetCore.Mvc;
using mvcTraining.Models;
using mvcTraining.Models.ViewModel;
using System.Diagnostics;
using mvcTraining.Views;
namespace mvcTraining.Controllers

{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger; 
       

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public ViewResult Welcome()
        {
            return View();
        }
        public ViewResult PersonalInfo(FilterPersonVm filter )
        {
            var Persons = new List<Person>()
            {new Person(){ Id =1,Age =10,Name="ahmed",Email="a@10"},
             new Person(){ Id =2,Age =20,Name="mohamed",Email="m@20"},
             new Person(){ Id =3,Age =30,Name="mona",Email="mon@30"}
            };
            var personsDB = Persons.AsQueryable();
            personsDB = personsDB.Where(p => p.Id == filter.Id && p.Name==filter.Name);
            var personVM = new PersonVM()
            {
                Persons = personsDB.ToList(),
                count = personsDB.ToList().Count
            };


            return View(personVM);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    internal class ApplicationDbContext
    {
        public object Products { get; internal set; }
    }
}

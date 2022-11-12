using Group3Web2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Group3Web2.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            Studenti stud1 = new Studenti("Kastriot", "Gjojka");

            return View(stud1);
        }
        public IActionResult Index1()
        {
            return View();
        }

        public IActionResult MesoHtml()
        {
            return View();
        }

        public IActionResult ParaqitListen()
        {
            List<Studenti> studentet = new List<Studenti>();
            Studenti stud1 = new Studenti("Blend", "Krasniqi");
            Studenti stud2 = new Studenti("Arbresha", "Alickaj");
            Studenti stud3 = new Studenti("Kastriot", "Gjoka");
            var stud4 = new Studenti("A", "B");

            studentet.Add(stud1);
            studentet.Add(stud2);
            studentet.Add(stud3);
            studentet.Add( new Studenti("X","Y"));
            studentet.Add(stud4);

            return View(studentet);
        }
    }
}

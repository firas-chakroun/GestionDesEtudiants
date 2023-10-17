using GestionDesEtudiants.Models;
using GestionDesEtudiants.Models.Repostries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestionDesEtudiants.Controllers
{
    public class StudentController : Controller
    {
        readonly IStudentRepository StudentRepositry;
        private readonly IWebHostEnvironment hostingEnvironment;

        public StudentController(IStudentRepository StdRepositry, IWebHostEnvironment hostingEnvironment)
        {
            StudentRepositry = StdRepositry;
            this.hostingEnvironment = hostingEnvironment;
        }
        // GET: StudentController
        public ActionResult Index()
        {
            var students = StudentRepositry.GetAll();
            return View(students);
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            var student = StudentRepositry.GetById(id);
            return View(student);
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

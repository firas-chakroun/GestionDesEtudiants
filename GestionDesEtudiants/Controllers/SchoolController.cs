using GestionDesEtudiants.Models;
using GestionDesEtudiants.Models.Repostries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestionDesEtudiants.Controllers
{
    public class SchoolController : Controller
    {
        readonly ISchoolRepository SchoolRepositry;
        private readonly IWebHostEnvironment hostingEnvironment;
        public SchoolController(ISchoolRepository SchRepositry, IWebHostEnvironment hostingEnvironment)
        {
            SchoolRepositry = SchRepositry;
            this.hostingEnvironment = hostingEnvironment;
        }

        // GET: SchoolController
        public ActionResult Index()
        {
            var schools = SchoolRepositry.GetAll();
            return View(schools);
        }

        // GET: SchoolController/Details/5
        public ActionResult Details(int id)
        {
            var school = SchoolRepositry.GetById(id);
            return View(school);
        }

        // GET: SchoolController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SchoolController/Create
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

        // GET: SchoolController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SchoolController/Edit/5
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

        // GET: SchoolController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SchoolController/Delete/5
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

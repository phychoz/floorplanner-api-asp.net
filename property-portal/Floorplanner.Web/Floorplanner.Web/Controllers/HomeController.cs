using System;
using System.Web.Mvc;
using Floorplanner.Web.Models.Repository;

namespace Floorplanner.Web.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        private readonly UserRepository _userRepository;
        private readonly ProjectRepository _projectRepository;

        public HomeController()
        {
            _userRepository = new UserRepository();
            _projectRepository = new ProjectRepository();
        }

        public ActionResult Index()
        {
            var users = _userRepository.ListAll();
            return View(users);
        }

        [AcceptVerbs("Post")]
        [ActionName("Index")]
        public ActionResult LoginAsAdministrator()
        {
            return RedirectToAction("LoggedInAsAdministrator", "Home");
        }

        [AcceptVerbs("Post")]
        public ActionResult LoginAsPro(FormCollection collection)
        {
            var userId = Convert.ToInt32(collection["ProUserId"]);
            return RedirectToAction("Index", "Project", new { id = userId });
        }

        public ActionResult LoggedInAsAdministrator()
        {
            var users = _userRepository.ListAll();
            var projects = _projectRepository.ListAll();

            ViewData["Users"] = users;
            ViewData["Projects"] = projects;

            return View();
        }
    }
}

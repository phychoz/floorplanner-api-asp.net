using System;
using System.Collections;
using System.Web.Mvc;
using Floorplanner.Web.Models.Entity;
using Floorplanner.Web.Models.Repository;

namespace Floorplanner.Web.Controllers
{
    public class ProjectController : Controller
    {
        private readonly ProjectRepository _projectRepository;
        private readonly UserRepository _userRepository;

        public ProjectController()
        {
            _projectRepository = new ProjectRepository();
            _userRepository = new UserRepository();
        }

        public ActionResult Index(int id)
        {
            var projects = _projectRepository.GetPorjects(id);

            ViewData["UserId"] = id;
            ViewData["Projects"] = projects;

            return View();
        }

        public ActionResult Add(int userId)
        {
            var project = new Models.Entity.Project();
            return View(project);
        }

        [AcceptVerbs("Post")]
        public ActionResult Add(int userId, FormCollection collection)
        {
            var floorsCount = Convert.ToInt32(collection["NumberOfFloors"]);
            var floors = new Floor[floorsCount];

            for (var i = 1; i < floorsCount + 1; i++)
            {
                var fieldName = string.Format("Floor{0}", i);
                var levelFieldName = string.Format("Level{0}", i);
                var heightFieldName = string.Format("Height{0}", i);
                var floor = new Floor { CreatedAt = DateTime.Now.ToString("s"), Name = collection[fieldName], Level = Convert.ToInt32(collection[levelFieldName]), Height = Convert.ToDecimal(collection[heightFieldName]) };
                floors[i - 1] = floor;
            }

            var floorsCollection = new FloorCollection { Floors = floors };

            _projectRepository.Add(DateTime.Now, collection["Description"], collection["Name"], collection["ExternalIdentifier"], floorsCount, userId, floorsCollection);

            return RedirectToAction("Index", "Project", new { id = userId });
        }

        public ActionResult Delete(int id, int userId)
        {
            _projectRepository.Delete(id);

            return RedirectToAction("Index", "Project", new { id = userId });
        }

        public ActionResult Edit(int id, int userId)
        {
            var project = _projectRepository.GetProject(id);
            return View(project);
        }

        [AcceptVerbs("Post")]
        public ActionResult Edit(int userId, int id, FormCollection collection)
        {
            var project = _projectRepository.GetProject(id);
            var floorsCount = Convert.ToInt32(collection["NumberOfFloors"]);
            var floors = new Floor[floorsCount];

            for (var i = 1; i < floorsCount + 1; i++)
            {
                var fieldName = string.Format("Floor{0}", i);
                var designCollection = new DesignCollection {Type = "array"};

                var floor = new Floor { CreatedAt = DateTime.Now.ToString("s"), Name = collection[fieldName], Designs = designCollection };
                floors[i - 1] = floor;
            }

            var floorsCollection = new FloorCollection { Floors = floors };

            _projectRepository.Edit(id, DateTime.Now, collection["Description"], collection["Name"], collection["ExternalIdentifier"], floorsCount, floorsCollection);
            return RedirectToAction("Index", "Project", new { id = project.UserId });
        }

        public ActionResult Details(int id, int userId)
        {
            var project = _projectRepository.GetProject(id);
            var token = _userRepository.GetUserToken(userId);
            ViewData["Token"] = token;
            ViewData["Project"] = project;

            return View(ViewData);
        }

    }
}

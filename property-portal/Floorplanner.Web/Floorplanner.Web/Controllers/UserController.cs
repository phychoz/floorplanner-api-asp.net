using System.Web.Mvc;
using Floorplanner.Web.Models.Repository;

namespace Floorplanner.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly UserRepository _userRepository;

        public UserController()
        {
            _userRepository = new UserRepository();    
        }

        public ActionResult Add()
        {
            var user = new Models.Entity.User();
            return View(user);
        }

        [AcceptVerbs("Post")]
        public ActionResult Add(FormCollection collection)
        {
            _userRepository.Add(collection["Company"], collection["Email"], collection["ExternalIdentifier"]);
            return RedirectToAction("LoggedInAsAdministrator", "Home");
        }

        public ActionResult Delete(int id, int userId)
        {
            _userRepository.Delete(id);

            return RedirectToAction("LoggedInAsAdministrator", "Home");
        }

        public ActionResult Edit(int id)
        {
            var user = _userRepository.GetUser(id);

            return View(user);
        }

        [AcceptVerbs("Post")]
        public ActionResult Edit(int id, FormCollection collection)
        {
            _userRepository.Edit(id, collection["Company"], collection["Email"], collection["ExternalIdentifier"]);

            return RedirectToAction("LoggedInAsAdministrator", "Home");
        }
    }
}

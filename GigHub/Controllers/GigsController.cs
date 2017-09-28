using System.Linq;
using System.Web.Mvc;
using GigHub.Models;
using GigHub.ViewModels;

namespace GigHub.Controllers {
    public class GigsController : Controller {
        private readonly ApplicationDbContext Context;

        public GigsController() {
            Context = new ApplicationDbContext();
        }
        [Authorize]
        public ActionResult Create() {
            var viewModel = new GigFormViewModel {
                Genres = Context.Genres.ToList()
            };
            return View(viewModel);
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Razor;
using MvcMusicStore.Business.Repository;
using MvcMusicStore.Business.Repository.Interface;
using MvcMusicStore.Models;
using MvcMusicStore.Models.ViewModels;

namespace MvcMusicStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMusicRepository _musicRepository;
        public HomeController(IMusicRepository musicRepository)
        {
            _musicRepository = musicRepository;
        }
        
        // GET: Home
        public ActionResult Index()
        {
            var albums = _musicRepository.GetAlbums();
            return View(albums);
        }

        [HttpGet]
        public ActionResult Create(Genre genre, Artist artist)
        {
            var viewModel = new CreateViewModel();

            viewModel.GenreItems = new List<SelectListItem>
            {
                new SelectListItem { Value = genre.Name, Text = genre.Name}
            };

            viewModel.ArtItems = new List<SelectListItem>
            {
                new SelectListItem {Value = artist.Name, Text = artist.Name}
            };

            //ViewBag.Genre = new SelectList(_musicRepository.GetGenres(), "GenreId", "Name");

            return View(viewModel);
        }

        //[HttpPost]
        //public ActionResult Create()
        //{
        //    return View();
        //}

    }
}
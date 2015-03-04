using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Models.ViewModels
{
    public class CreateViewModel
    {
        public Album Album { get; set; }
        public Genre Genre { get; set; }
        public List<SelectListItem> GenreItems { get; set; }
        public Artist Artist { get; set; }
        public List<SelectListItem> ArtItems { get; set; }
        


    }
}
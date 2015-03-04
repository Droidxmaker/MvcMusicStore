using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{
    public class Album
    {
        [ScaffoldColumn(false)]
        public int AlbumId { get; set; }

        public int GenreId { get; set; }
        public int ArtistId { get; set; }

        [Required(ErrorMessage = "It needs a Title")]
        [StringLength(100)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Price needed, Between 0.01 and 100.00")]
        [Range(0.01, 100.00)]
        public decimal Price { get; set; }

        public string AlbumArtUrl { get; set; }
        public virtual Artist Artist { get; set; }
        public virtual Genre Genre { get; set; }
    }
}
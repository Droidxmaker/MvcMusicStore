using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcMusicStore.Models;
using MvcMusicStore.Models.ViewModels;

namespace MvcMusicStore.Business.Repository.Interface
{
   public interface IMusicRepository
   {
       IEnumerable<Album> GetAlbums();
       IEnumerable<Artist> GetArtists();
       IEnumerable<Genre> GetGenres();
       void Update(Album album);
       void Delete(int id);
       void Save();


   }
}

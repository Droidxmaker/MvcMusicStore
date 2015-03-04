using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MvcMusicStore.Business.Repository.Interface;
using MvcMusicStore.Models;
using MvcMusicStore.Models.ViewModels;

namespace MvcMusicStore.Business.Repository
{
    public class MusicRepository : IMusicRepository
    {
        private MusicStoreEntities _db = new MusicStoreEntities();

        public IEnumerable<Album> GetAlbums()
        {
            return _db.Albums.Include(x => x.Artist).Include(x => x.Genre).ToList();
        }
        public IEnumerable<Artist> GetArtists()
        {
            return _db.Artists.ToList();
        }

        public IEnumerable<Genre> GetGenres()
        {
            return _db.Genres.ToList();
        }
        public void Update(Album album)
        {
            _db.Entry(album).State = EntityState.Modified;
        }
        public void Delete(int id)
        {
            Album exist = _db.Albums.Find(id);
            _db.Albums.Remove(exist);
        }
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
namespace IRunesWebApp.Controllers
{
    using IRunesWebApp.Models;
    using IRunesWebApp.ViewModels.Track;
    using SIS.HTTP.Responses;
    using SIS.MvcFramework;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class TrackController : BaseController
    {
        [HttpGet("/Tracks/Create")]
        public IHttpResponse Create(string albumId)
        {
            if (this.User == null)
            {
                return this.BadRequestError("Please login frist.");
            }
            var album = this.Db.Albums.FirstOrDefault(x => x.Id == albumId);

            return this.View("Tracks/Create", album);
        }

        [HttpPost("/tracks/create")]
        public IHttpResponse DoCreate(DoTrackInputModelView model, string albumId)
        {
            if (this.User == null)
            {
                return this.BadRequestError("Please login frist.");
            }
            var track = new Track
            {
                Name = model.Name,
                Link = model.Link,
                Price = model.Price,
            };

            this.Db.Tracks.Add(track);
            this.Db.SaveChanges();

            var trackToAlbum = Db.Tracks.FirstOrDefault(x => x.Name == track.Name);
            var trackAlbum = new TrackAlbum
            {
                AlbumId = albumId,
                TrackId = trackToAlbum.Id
            };
            this.Db.TracksAlbums.Add(trackAlbum);
            this.Db.SaveChanges();

            var albums = this.Db.Albums.ToList();
            
            return this.View("/All", albums);
        }
    }
}

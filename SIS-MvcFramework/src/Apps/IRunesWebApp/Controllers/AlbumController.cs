namespace IRunesWebApp.Controllers
{
    using IRunesWebApp.Models;
    using IRunesWebApp.ViewModels.Album;
    using SIS.HTTP.Responses;
    using SIS.MvcFramework;
    using SIS.MvcFramework.Services;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class AlbumController : BaseController
    {
        private IHashService hashService;

        public AlbumController(IHashService hashService)
        {
            this.hashService = hashService;
        }

        [HttpGet("/all")]
        public IHttpResponse Albums()
        {
            if (User == null)
            {
                return this.BadRequestError("Please login first!");
            }

            var albums = this.Db.Albums.ToArray();

            return this.View("All", albums);
        }

        [HttpGet("/create")]
        public IHttpResponse Create()
        {
            if (User == null)
            {
                return this.BadRequestError("Please login first!");
            }

            return this.View("Create");
        }

        [HttpPost("/create")]
        public IHttpResponse DoCreate(DoInputAlbumModel model)
        {
            if (User == null)
            {
                return this.BadRequestError("Please login first!");
            }

            var album = new Album
            {
                Cover = model.Cover,
                Name = model.Name
            };

            this.Db.Albums.Add(album);

            try
            {
                this.Db.SaveChanges();
            }
            catch (Exception e)
            {

                return this.ServerError(e.Message);
            }


            return this.Albums();
        }

        [HttpGet("/details")]
        public IHttpResponse Details(string id)
        {
            var album = this.Db.Albums.FirstOrDefault(x => x.Id == id);
            return this.View("Details", album);
        }
    }
}

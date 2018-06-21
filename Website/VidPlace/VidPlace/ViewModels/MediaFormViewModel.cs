using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidPlace.Models;

namespace VidPlace.ViewModels
{
    public class MediaFormViewModel
    {
        public Media Media { get; set; }
        public IEnumerable<MediaType> MediaTypes { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Kalafina.Models
{
    public class Song : Musique
    {
        [Range(0, 100)]
        public int TrackNo { get; set; }

        public int AlbumID { get; set; }
        public Album Album { get; set; }
        public ICollection<ConcertList> ConcertList { get; set; }
    }
}
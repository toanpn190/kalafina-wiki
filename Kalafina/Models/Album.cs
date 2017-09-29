using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Kalafina.Models
{
    public class Album : Musique
    {
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        [DataType(DataType.ImageUrl)]
        public string ImageUrl { get; set; }

        public virtual ICollection<Song> Songs { get; set; }
    }
}
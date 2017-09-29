using System;
using System.ComponentModel.DataAnnotations;

namespace Kalafina.Models
{
    public class Musique
    {
        public int ID { get; set; }

        [StringLength(50, MinimumLength = 1)]
        public string Title { get; set; }
    }
}
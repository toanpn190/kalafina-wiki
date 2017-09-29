using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Kalafina.Models
{
    public class Concert : Musique
    {
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public string Place { get; set; }

        public virtual ICollection<ConcertList> ConcertList { get; set; }
    }
}
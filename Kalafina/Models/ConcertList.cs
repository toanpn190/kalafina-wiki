using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kalafina.Models
{
    public class ConcertList
    {
        public int ID { get; set; }
        public int SongID { get; set; }
        public int ConcertID { get; set; }
        
        public virtual Song Song { get; set; }
        public virtual Concert Concert { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DenchikSportsRu.Models.Db
{
    public class DbFootball
    {
        public int id { get; set; }

        public string league_url { get; set; }
        public string leaguetop { get; set; }

        public string league_news  { get; set; }
        public string league_photo { get; set; }
        public string league_img { get; set; }
    }
}

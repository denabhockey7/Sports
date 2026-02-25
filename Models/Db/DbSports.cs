using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DenchikSportsRu.Models.Db
{
    public class DbSports
    {
        public int id { get; set; }

        public string sports_url { get; set; }

        public string sports_name { get; set; }
        public string sports_photo { get; set; }
        public string sports_img { get; set; }
        public string position { get; set; }

    }
}

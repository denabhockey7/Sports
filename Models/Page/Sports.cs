using DenchikSportsRu.Models.Db;

namespace DenchikSportsRu.Models.Page
{
    public class Sports
    {
        public List<DbSports> List { get; set; }
        public int id { get; set; }
        public string sports_url { get; set; }

        public string sports_name { get; set; }
        public string sports_photo { get; set; }
        public string sports_img { get; set; }
        public string position { get; set; }
    }
}

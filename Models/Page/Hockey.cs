using DenchikSportsRu.Models.Db;

namespace DenchikSportsRu.Models.Page
{
    public class Hockey
    {
        public List<DbHockey> List { get; set; }
        public int id { get; set; }
        public string league_url { get; set; }

        public string league_name { get; set; }
        public string league_news { get; set; }
        public string league_photo { get; set; }
        public string league_img { get; set; }
    }
}

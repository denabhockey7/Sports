using DenchikSportsRu.Models.Db;

namespace DenchikSportsRu.Models.Page
{
    public class Tennis
    {
        public List<DbTennis> List { get; set; }
        public string id { get; set; }
        public string tennis_name { get; set; }
        public string tennis_news { get; set; }
        public string tennis_photo { get; set; }
        public string tennis_img { get; set; }
        public string tennis_url { get; set; }
    }
}

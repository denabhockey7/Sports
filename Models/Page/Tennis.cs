using DenchikSportsRu.Models.Db;

namespace DenchikSportsRu.Models.Page
{
    public class Tennis
    {
        public List<DbTennis> List { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string photo { get; set; }
        public int points { get; set; }
        public string url { get; set; }

    }
}

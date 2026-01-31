using DenchikSportsRu.Models.Db;

namespace DenchikSportsRu.Models.Page
{
    public class Hockey
    {
        public List<DbHockey> List { get; set; }
        public int id { get; set; }
        public string league_url { get; set; }

        public string league_name { get; set; }
    }
}

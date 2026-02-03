using DenchikSportsRu.Models.Db;

namespace DenchikSportsRu.Models.Page
{
    public class ATP
    {
        public List<DbATP> List { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public int points { get; set; }
        public string sex { get; set; }
        public string country { get; set; }
        public string photo { get; set; }
        public string img { get; set; }
    }
}

using DenchikSportsRu.Models.Db;

namespace DenchikSportsRu.Models.Page
{
    public class Clubs
    {
        public List<DbClubs> List { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public int points { get; set; }
        public int wins { get; set; }
        public int otwins { get; set; }
        public int wb { get; set; }
        public int loses { get; set; }
        public int otloses { get; set; }
        public int lb { get; set; }
        public int goals { get; set; }
        public int misses { get; set; }
        public string league { get; set; }
        public string conference { get; set; }
        public string division { get; set; }
        public string logo { get; set; }
    }
    

}

using DenchikSportsRu.Models.Db;

namespace DenchikSportsRu.Models.Page
{
    public class Formula
    {
        public List<DbFormula> List { get; set; }
        public string id { get; set; }
        public string racer_name { get; set; }
        public string racer_surname { get; set; }
        public string racer_photo { get; set; }
        public int points { get; set; }
        public string racer_url { get; set; }
        public string racer_team_photo { get; set; }

        public string racer_team_name { get; set; }
    }
}

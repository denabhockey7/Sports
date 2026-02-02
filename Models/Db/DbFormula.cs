namespace DenchikSportsRu.Models.Db
{
    public class DbFormula
    {
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

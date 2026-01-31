namespace DenchikSportsRu.Models.Db
{
    public class DbTeams
    {
        public int id { get; set; }

        public string team_url { get; set; }

        public string team_name { get; set; }
        public int points { get; set; }
        public int wins { get; set; }
        public int draws { get; set; }
        public int loses { get; set; }
        public int goals { get; set; }
        public int misses { get; set; }
        public string team_league { get; set; }
        public string team_photo { get; set; }
    }
}

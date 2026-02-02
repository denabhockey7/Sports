using Microsoft.AspNetCore.Mvc;
using Dapper;
using Npgsql;
using System.Text.RegularExpressions;
using DenchikSportsRu.Models;
using DenchikSportsRu.Models.Page;
using DenchikSportsRu.Models.Db;



namespace DenchikSportsRu.Core
{
    public class SiteBL
    {
        public static Clubs GetHLeague(Clubs frm, string league)
        {
            try
            {
                using (var conn = new NpgsqlConnection(Consts.ConnectionString))
                {
                    conn.Open();

                    var allclubs = conn.Query<DbClubs>(
                        @"SELECT * FROM ""clubs"" WHERE ""league"" = League ORDER BY ""points""",
                        new { League = league }).ToList();

                    var Club = allclubs.FirstOrDefault();

                    return new Clubs
                    {
                        logo = Club?.logo,
                        url = Club?.url,
                        name = Club?.name,
                        points = Club?.points ?? 0,
                        wins = Club?.wins ?? 0,
                        otwins = Club?.otwins ?? 0,
                        wb = Club?.wb ?? 0,
                        loses = Club?.loses ?? 0,
                        otloses = Club?.otloses ?? 0,
                        lb = Club?.lb ?? 0,
                        goals = Club?.goals ?? 0,
                        misses = Club?.misses ?? 0,
                        conference = Club?.conference,
                        division = Club?.division,
                        List = allclubs
                    };
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting {league}: {ex.Message}");
                return new Clubs { List = new List<DbClubs>() };
            }
        }

        public static Clubs GetKHL(Clubs frm) => GetHLeague(frm, "KHL");
        public static Clubs GetNHL(Clubs frm) => GetHLeague(frm, "NHL");
        

        public static Hockey GetHockey(Hockey frm)
        {
            try
            {
                using (var conn = new NpgsqlConnection(Consts.ConnectionString))
                {
                    conn.Open();

                    var league = conn.QueryFirstOrDefault<DbHockey>(
                        @"SELECT * FROM ""hockey"" WHERE ""id"" = @id",
                        new { id = frm.id });

                    var allLeague = conn.Query<DbHockey>(
                        @"SELECT * FROM ""hockey"" ORDER BY ""league_name""").ToList();

                    return new Hockey
                    {
                        league_url = league?.league_url,
                        league_name = league?.league_name,
                        List = allLeague
                    };
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return new Hockey { List = new List<DbHockey>() };
            }
        }


        public static NBA GetNBA(NBA frm)
        {
            try
            {
                using (var conn = new NpgsqlConnection(Consts.ConnectionString))
                {
                    conn.Open();

                    var allNBA = conn.Query<DbNBA>(
                 @"SELECT * FROM ""nba"" ORDER BY ""wins"" DESC, ""club_name""").ToList();

                    var nba = allNBA.FirstOrDefault();

                    return new NBA
                    {
                        club_url = nba?.club_url,
                        club_name = nba?.club_name,
                        wins = nba?.wins ?? 0,
                        losses = nba?.losses ?? 0,
                        conference =nba?.conference,
                        List = allNBA
                    };
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return new NBA { List = new List<DbNBA>() };
            }
        }

        public static Formula GetFormula(Formula frm)
        {
            try
            {
                using (var conn = new NpgsqlConnection(Consts.ConnectionString))
                {
                    conn.Open();

                    var allF1 = conn.Query<DbFormula>(
                 @"SELECT * FROM ""formula"" ORDER BY ""racer_points"" DESC, ""racer_name""").ToList();

                    var f1 = allF1.FirstOrDefault();

                    return new Formula
                    {
                        racer_url = f1?.racer_url,
                        racer_name = f1?.racer_name,
                        racer_surname = f1?.racer_surname,
                        racer_team_name = f1?.racer_team_name,
                        racer_photo = f1?.racer_photo,
                        racer_team_photo = f1?.racer_team_photo,
                        points = f1?.points ?? 0,
                        List = allF1
                    };
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return new Formula { List = new List<DbFormula>() };
            }
        }

        public static Tennis GetTennis(Tennis frm)
        {
            try
            {
                using (var conn = new NpgsqlConnection(Consts.ConnectionString))
                {
                    conn.Open();

                    var allTennis = conn.Query<DbTennis>(
                 @"SELECT * FROM ""tennis"" ORDER BY ""points"" DESC, ""name""").ToList();

                    var tennis = allTennis.FirstOrDefault();

                    return new Tennis
                    {
                        url = tennis?.url,
                        name = tennis?.name,
                        surname = tennis?.surname,
                        photo = tennis?.photo,
                        points = tennis?.points ?? 0,
                        List = allTennis
                    };
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return new Tennis { List = new List<DbTennis>() };
            }
        }



        public static Teams GetLeague(Teams frm, string league)
        {
            try
            {
                using (var conn = new NpgsqlConnection(Consts.ConnectionString))
                {
                    conn.Open();

                    var allteams = conn.Query<DbTeams>(
                        @"SELECT * FROM ""teams"" WHERE ""team_league"" = @League ORDER BY ""points"" DESC, ""team_name""",
                        new { League = league }).ToList();

                    var firstTeam = allteams.FirstOrDefault();

                    return new Teams
                    {
                        team_photo = firstTeam?.team_photo,
                        team_url = firstTeam?.team_url,
                        team_name = firstTeam?.team_name,
                        points = firstTeam?.points ?? 0,
                        wins = firstTeam?.wins ?? 0,
                        draws = firstTeam?.draws ?? 0,
                        loses = firstTeam?.loses ?? 0,
                        goals = firstTeam?.goals ?? 0,
                        misses = firstTeam?.misses ?? 0,
                        List = allteams
                    };
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting {league}: {ex.Message}");
                return new Teams { List = new List<DbTeams>() };
            }
        }

        public static Teams GetEPL(Teams frm) => GetLeague(frm, "EPL");
        public static Teams GetBundes(Teams frm) => GetLeague(frm, "bundes");
        public static Teams GetRPL(Teams frm) => GetLeague(frm, "RPL");
        public static Teams GetLL(Teams frm) => GetLeague(frm, "laliga");
        public static Teams GetL1(Teams frm) => GetLeague(frm, "l1");
        public static Teams GetSA(Teams frm) => GetLeague(frm, "sa");

        public static Football GetFootball(Football frm)
        {
            try
            {
                using (var conn = new NpgsqlConnection(Consts.ConnectionString))
                {
                    conn.Open();

                    var league = conn.QueryFirstOrDefault<DbFootball>(
                        @"SELECT * FROM ""football"" WHERE ""id"" = @id",
                        new { id = frm.id });

                    var allLeague = conn.Query<DbFootball>(
                        @"SELECT * FROM ""football"" ORDER BY ""league_name""").ToList();

                    return new Football
                    {
                        league_url = league?.league_url,
                        league_name = league?.league_name,
                        List = allLeague
                    };
                }

               
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return new Football { List = new List<DbFootball>() };
            }
        }

        public static Sports GetSports(Sports frm)
        {
            try
            {
                using (var conn = new NpgsqlConnection(Consts.ConnectionString))
                {
                    conn.Open();

                    var sport = conn.QueryFirstOrDefault<DbSports>(
                        @"SELECT * FROM ""sports"" WHERE ""id"" = @id",
                        new { id = frm.id });

                    var allSports = conn.Query<DbSports>(
                        @"SELECT * FROM ""sports"" ORDER BY ""sports_name""").ToList();

                    return new Sports
                    {
                        sports_url = sport?.sports_url,
                        sports_name = sport?.sports_name,
                        List = allSports
                    };
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return new Sports { List = new List<DbSports>() };
            }
        }
    };

    
}


using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Google_Classroom.Week_5.Day_2._01_02_Submission_of_JSON
{
    internal class IPL_and_Censorship_Analyzer
    {
        public static void Main(string[] args)
        {
            string jsonIn = "ipl_matches.json";
            string csvIn = "ipl_matches.csv";
            string jsonOut = "censored_ipl.json";
            string csvOut = "censored_ipl.csv";
            if (!File.Exists(jsonIn))
            {
                File.WriteAllText(jsonIn, @"[
  {
    ""match_id"": 101,
    ""team1"": ""Mumbai Indians"",
    ""team2"": ""Chennai Super Kings"",
    ""score"": {
      ""Mumbai Indians"": 178,
      ""Chennai Super Kings"": 182
    },
    ""winner"": ""Chennai Super Kings"",
    ""player_of_match"": ""MS Dhoni""
  },
  {
    ""match_id"": 102,
    ""team1"": ""Royal Challengers Bangalore"",
    ""team2"": ""Delhi Capitals"",
    ""score"": {
      ""Royal Challengers Bangalore"": 200,
      ""Delhi Capitals"": 190
    },
    ""winner"": ""Royal Challengers Bangalore"",
    ""player_of_match"": ""Virat Kohli""
  }
]");
            }
            if (!File.Exists(csvIn))
            {
                File.WriteAllLines(csvIn, new string[] {
                    "match_id,team1,team2,score_team1,score_team2,winner,player_of_match",
                    "101,Mumbai Indians,Chennai Super Kings,178,182,Chennai Super Kings,MS Dhoni",
                    "102,Royal Challengers Bangalore,Delhi Capitals,200,190,Royal Challengers Bangalore,Virat Kohli"
                });
            }
            ProcessJson(jsonIn, jsonOut);
            ProcessCsv(csvIn, csvOut);
            Console.WriteLine(File.ReadAllText(jsonOut));
            Console.WriteLine(File.ReadAllText(csvOut));
        }
        static void ProcessJson(string inputPath, string outputPath)
        {
            string json = File.ReadAllText(inputPath);
            JArray matches = JArray.Parse(json);
            foreach (JObject m in matches)
            {
                string t1 = (string)m["team1"];
                string t2 = (string)m["team2"];
                string win = (string)m["winner"];
                string maskedT1 = MaskTeamName(t1);
                string maskedT2 = MaskTeamName(t2);
                string maskedWin = MaskTeamName(win);
                m["team1"] = maskedT1;
                m["team2"] = maskedT2;
                m["winner"] = maskedWin;
                m["player_of_match"] = "REDACTED";
                JObject oldScore = (JObject)m["score"];
                if (oldScore != null)
                {
                    JObject newScore = new JObject();
                    foreach (var prop in oldScore.Properties())
                        newScore[MaskTeamName(prop.Name)] = prop.Value;
                    m["score"] = newScore;
                }
            }
            File.WriteAllText(outputPath, matches.ToString(Formatting.Indented));
        }
        static void ProcessCsv(string inputPath, string outputPath)
        {
            string[] lines = File.ReadAllLines(inputPath);
            List<string> outLines = new List<string>();
            outLines.Add(lines[0]);
            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(',');
                parts[1] = MaskTeamName(parts[1]);
                parts[2] = MaskTeamName(parts[2]);
                parts[5] = MaskTeamName(parts[5]);
                parts[6] = "REDACTED";
                outLines.Add(string.Join(",", parts));
            }
            File.WriteAllLines(outputPath, outLines);
        }
        static string MaskTeamName(string team)
        {
            if (string.IsNullOrEmpty(team)) return team;
            if (team.Equals("Mumbai Indians", StringComparison.OrdinalIgnoreCase)) return "Mumbai ***";
            if (team.Equals("Chennai Super Kings", StringComparison.OrdinalIgnoreCase)) return "Chennai ***";
            if (team.Equals("Royal Challengers Bangalore", StringComparison.OrdinalIgnoreCase)) return "Royal *** Bangalore";
            if (team.Equals("Delhi Capitals", StringComparison.OrdinalIgnoreCase)) return "Delhi ***";
            string[] words = team.Split(' ');
            if (words.Length == 1) return words[0] + " ***";
            if (words.Length == 2) return words[0] + " ***";
            if (words.Length >= 3) return words[0] + " *** " + words[words.Length - 1];
            return team;
        }
    }
}

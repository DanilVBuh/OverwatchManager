using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchInfo
{
	public class Stage
	{
		public Tournament Tournament { get; set; }
		public int Number { get; set; }
		public string Name { get; set; }
		public int CountOfMatches { get; set; }

		public ICollection<Match> Matches = new List<Match>();
		public ICollection<Team> Teams = new List<Team>();

		public Dictionary<string, ICollection<Map>> PullOfMaps { get; set; } = new Dictionary<string, ICollection<Map>>
		{
			["control"] = new List<Map>(),
			["assault"] = new List<Map>(),
			["escort"] = new List<Map>(),
			["hybrid"] = new List<Map>()
		};

		public Stage(Tournament tournament, int number, int countOfMatches)
		{
			this.Tournament = tournament;
			this.Number = number;
			this.Teams = tournament.Teams;
			this.CountOfMatches = Math.Min(Teams.Count * (Teams.Count - 1) / 2, countOfMatches);
			this.Name = "Stage " + number.ToString();
			this.PullOfMaps["control"].Add(new ControlMap("Nepal"));
			this.PullOfMaps["assault"].Add(new ControlMap("Hanamura"));
			this.PullOfMaps["escort"].Add(new ControlMap("Rialtto"));
			this.PullOfMaps["hybrid"].Add(new ControlMap("Numbani"));
			this.PullOfMaps["control"].Add(new ControlMap("Busan"));
			this.PullOfMaps["assault"].Add(new ControlMap("Paris"));
			this.PullOfMaps["escort"].Add(new ControlMap("Junkertown"));
			this.PullOfMaps["hybrid"].Add(new ControlMap("Hollywood"));
			GenerateSchedule();
		}
		private Team PickRandomTeam()
		{
			Random rnd = new Random();
			int r = rnd.Next(Teams.Count);
			return Teams.ElementAt(r);
		}

		public void AddMatch(Team t1, Team t2)
		{
			Match match = new Match(t1, t2, this);
			Matches.Add(match);
		}

		public void GenerateSchedule()
		{
			int i = 0;
			while (i < CountOfMatches)
			{
				Team team1 = PickRandomTeam();
				Team team2 = PickRandomTeam();
				if (team1 != team2 && Matches.All(m =>
				!(m.HomeTeam == team1 && m.VisitingTeam == team2)
				&& !(m.HomeTeam == team2 && m.VisitingTeam == team1)))
				{
					Match match = new Match(team1, team2, this);
					Matches.Add(match);
					i++;
				}
				else
				{
					continue;
				}
			}
		}

	}
}

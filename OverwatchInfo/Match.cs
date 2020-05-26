using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchInfo
{
	public class Match
	{
		public Stage Stage { get; set; }
		public ICollection<Game> Games = new List<Game>();
		public int ScoreForWin { get; set; }
		public Team HomeTeam { get; }
		public Team VisitingTeam { get; }
		public MatchScore Score { get; set; } = new MatchScore();
		public Match(Team team1, Team team2, Stage stage)
		{
			this.HomeTeam = team1;
			this.VisitingTeam = team2;
			this.Stage = stage;
			GenerateMatch();
			this.ScoreForWin = 3;
			
		}
		public void GenerateMatch()
		{
			AddControlGame();
			AddAssaultGame();
			AddEscortGame();
			AddHybridGame();
		}

		public void AddControlGame()
		{
			Game g = new ControlGame(PickRandomMap("control"),this);
			//g.Match = this;
			this.Games.Add(g);
		}
		public void AddAssaultGame()
		{
			Game g = new AssaultGame(PickRandomMap("assault"), this);
			//g.Match = this;
			this.Games.Add(g);
		}
		public void AddEscortGame()
		{
			Game g = new EscortGame(PickRandomMap("escort"), this);
			//g.Match = this;
			this.Games.Add(g);
		}
		public void AddHybridGame()
		{
			Game g = new HybridGame(PickRandomMap("hybrid"), this);
			//g.Match = this;
			this.Games.Add(g);
		}
		private Map PickRandomMap(string type)
		{
			Random rnd = new Random();
			int r = rnd.Next(this.Stage.PullOfMaps[type].Count);
			return this.Stage.PullOfMaps[type].ElementAt(r);
		}

		public void UpdateScore()
		{
			
		}

	}
}

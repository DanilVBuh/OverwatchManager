using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchInfo
{
	public class Team
	{
		public ICollection<Player> Players = new List<Player>();

		public Team(string name)
		{
			this.Name = name;
		}

		public string Name { get; set; }
		public TotalScore TotalScore { get; set; } = new TotalScore();

		public void AddPlayer(string nick)
		{
			Player p = new Player(nick);
			p.Team = this;
			Players.Add(p);
		}

	}
}

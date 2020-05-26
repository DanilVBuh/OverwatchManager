using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchInfo
{
	public class GameScore
	{
		public int HomeTeamWins { get; set; } = 0;
		public int VisitingTeamWins { get; set; } = 0;
		public Game Game { get; set; }

		public void SetScore(int ht, int vt)
		{
			HomeTeamWins = ht;
			VisitingTeamWins = vt;
		}
	}
}

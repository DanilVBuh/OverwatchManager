using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchInfo
{
	public class MatchScore
	{
		public Match Match { get; set; }
		public int HomeTeamWins { get; set; } = 0;
		public int VisitingTeamWins { get; set; } = 0;
		public void SetScore(int ht, int vt)
		{
			HomeTeamWins = ht;
			VisitingTeamWins = vt;
		}
		public void AddWinHome()
		{
			this.HomeTeamWins++;
		}
		public void AddWinVisiting()
		{
			this.VisitingTeamWins++;
		}
		public bool IsEqual()
		{
			if (HomeTeamWins == VisitingTeamWins)
				return true;
			return false;
		}
	}
}

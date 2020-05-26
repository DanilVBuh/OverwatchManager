using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchInfo
{
	public class Tournament
	{
		public ICollection<Stage> Stages = new List<Stage>();
		public ICollection<Team> Teams = new List<Team>();
		public int StagesCount { get; set; }
		private int CurrentStage = 1;
		public void SetStagesCount(int stagesCount)
		{
			StagesCount = stagesCount;
		}
		public bool AddTeam(string name)
		{
			if (name != "" && Teams.All(t => t.Name != name))
			{
				Team team = new Team(name);
				Teams.Add(team);
				return true;
			}
			else
			{
				return false;
			}

		}
		public void AddStage(int countOfMatches)
		{
			if (CurrentStage < StagesCount)
			{
				Stage stage = new Stage(this, CurrentStage, countOfMatches);
				Stages.Add(stage);
				CurrentStage++;
			}
		}
	}
}

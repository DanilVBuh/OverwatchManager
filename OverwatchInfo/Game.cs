using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchInfo
{
	public abstract class Game
	{
		public Match Match { get; set; }
		public ICollection<Round> Rounds = new List<Round>();
		public ICollection<Event> Events = new List<Event>();
		public Team HomeTeam { get; set; }
		public Team VisitingTeam { get; set; }
		public GameScore Score { get; set; } = new GameScore();
		public Map Map { get; set; }
		public bool IsOvered { get; set; } = false;
		public string Type { get; set; }
		private string tank = "tank";
		private string damage = "damage";
		private string support = "support";
		public int Number { get; set; }
		public Dictionary<string, ICollection<Hero>> Heroes { get; set; } = new Dictionary<string, ICollection<Hero>>
		{
			["tank"] = new List<Hero>(),
			["damage"] = new List<Hero>(),
			["support"] = new List<Hero>()
		};
		public Dictionary<string, ICollection<Pick>> HomePick { get; set; } = new Dictionary<string, ICollection<Pick>>
		{
			["tank"] = new List<Pick>(),
			["damage"] = new List<Pick>(),
			["support"] = new List<Pick>()
		};
		public Dictionary<string, ICollection<Pick>> VisitingPick { get; set; } = new Dictionary<string, ICollection<Pick>>
		{
			["tank"] = new List<Pick>(),
			["damage"] = new List<Pick>(),
			["support"] = new List<Pick>()
		};
		public void SetHero(Player player, Hero hero)
		{
			if (player.Team == HomeTeam)
			{
				HomePick[hero.Role].Add(new Pick(player, hero));
			}
			else
			{
				VisitingPick[hero.Role].Add(new Pick(player, hero));
			}
		}
		public Game(Map map, Match match)
		{
			this.Match = match;
			this.HomeTeam = match.HomeTeam;
			this.VisitingTeam = match.VisitingTeam;
			this.Map = map;
			this.Number = match.Games.Count() + 1;

			this.Heroes[tank].Add(new TankRole("REINHARDT", 500, "ROCKET HAMMER", "BARRIER FIELD", "CHARGE", "FIRE STRIKE", "EARTHSHATTER"));
			this.Heroes[tank].Add(new TankRole("D.VA", 600, "FUSION CANNONS", "DEFFENSE MATRIX", "BOOSTERS", "MICRO MISSILES", "SELF-DESTRUCT"));
			this.Heroes[damage].Add(new DamageRole("GENJI", 200, "SHURIKEN", "SHURIKEN", "SWIFT STRIKE", "DEFLECT", "DRAGONBLADE"));
			this.Heroes[damage].Add(new DamageRole("SOMBRA", 200, "MACHINE PISTOL", "HACK", "STEALTH", "TRANSLOCATOR", "EMP"));
			this.Heroes[support].Add(new SupportRole("MOIRA", 200, "BIOTIC GRASP", "BIOTIC GRASP", "FADE", "BIOTIC ORB", "COALESCENCE"));
			this.Heroes[support].Add(new SupportRole("BAPTISTE", 200, "BIOTIC LAUNCHER", "BIOTIC LAUNCHER", "REGENERATIVE BURST", "IMMORTALITY FIELD", "AMPLIFICATION MATRIX"));
		}


	}
}

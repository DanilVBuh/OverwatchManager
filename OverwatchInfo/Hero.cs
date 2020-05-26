using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchInfo
{
	public abstract class Hero
	{
		public string Name { get; set; }
		public string Role { get; set; }
		public int Health { get; set; }
		public string PrimaryFire { get; set; }
		public string SecondaryFire { get; set; }
		public string FirstAbility { get; set; }
		public string SecondAbility { get; set; }
		public string UltimateAbility { get; set; }

		public Dictionary<string, string> Skill { get; set; } = new Dictionary<string, string>
		{
			["primary fire"] = "",
			["secondary fire"] = "",
			["first ability"] = "",
			["second ability"] = "",
			["ultimate"] = ""
		};

		public Hero(string name, int health, string pf, string sf, string fa, string sa, string ult)
		{
			this.Name = name;
			this.Health = health;
			this.PrimaryFire = pf;
			this.SecondaryFire = sf;
			this.FirstAbility = fa;
			this.SecondAbility = sa;
			this.UltimateAbility = ult;
			this.Skill["primary fire"] = pf;
			this.Skill["secondary fire"] = sf;
			this.Skill["first ability"] = fa;
			this.Skill["second ability"] = sa;
			this.Skill["ultimate"] = ult;
		}
	}
}

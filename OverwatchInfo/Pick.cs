using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchInfo
{
	public class Pick
	{
		public Pick()
		{
		}
		public Pick(Player player, Hero hero)
		{
			this.Player = player;
			this.Hero = hero;
		}
		public Player Player{ get; set; }
		public Hero Hero{ get; set; }

	}
}

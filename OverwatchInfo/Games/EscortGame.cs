using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchInfo
{
	public class EscortGame : Game
	{
		public EscortGame(Map map, Match match) : base(map, match)
		{
			Type = "escort";
		}
	}
}

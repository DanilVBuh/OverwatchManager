using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchInfo
{
	public class HybridGame : Game
	{
		public HybridGame(Map map, Match match) : base(map, match)
		{
			Type = "hybrid";
		}
	}
}

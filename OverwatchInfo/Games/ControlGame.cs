using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchInfo
{
	public class ControlGame : Game
	{
		public ControlGame(Map map, Match match) : base(map, match)
		{
			Type = "control";
		}
	}
}

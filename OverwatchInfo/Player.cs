using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchInfo
{
	public class Player
	{
		public Player(string nick)
		{
			Nick = nick;
		}

		public Team Team { get; set; }
		public string Nick { get; set; }

	}
}

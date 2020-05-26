using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchInfo
{
	public class Event
	{
		public Pick FromPick { get; set; }
		public Pick ToPick { get; set; }
		public string Act { get; set; }
		public string Time { get; set; }
		public Game Game { get; set; }
		public Event(Pick fromPick, Pick toPick, string act, string time, Game game)
		{
			this.FromPick = fromPick;
			this.ToPick = toPick;
			this.Game = game;
			this.Act = act;
			this.Time = time;
		}

	}
}

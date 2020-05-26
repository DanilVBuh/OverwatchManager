using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchInfo
{
	public class TotalScore
	{
		public int wins { get; set; } = 0;
		public int loses { get; set; } = 0;

		public void AddWin()
		{
			this.wins++;
		}
		public void AddLose()
		{
			this.loses++;
		}
	}
}

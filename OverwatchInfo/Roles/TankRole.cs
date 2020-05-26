using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchInfo
{
	public class TankRole : Hero
	{
		public TankRole(string name, int health, string pf, string sf, string fa, string sa, string ult) : base(name, health, pf, sf, fa, sa, ult)
		{
			Role = "tank";
		}
	}
}

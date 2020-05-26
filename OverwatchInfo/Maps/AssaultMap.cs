using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchInfo
{
	public class AssaultMap : Map
	{
		public AssaultMap(string name):base(name)
		{
			Type = "assault";
		}
	}
}

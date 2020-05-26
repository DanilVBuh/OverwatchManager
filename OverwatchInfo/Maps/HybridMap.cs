using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchInfo
{
	public class HybridMap : Map
	{
		public HybridMap(string name) : base(name)
		{
			Type = "hybrid";
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchInfo
{
	public class EscortMap : Map
	{
		public EscortMap(string name) : base(name)
		{
			Type = "escort";
		}
	}
}

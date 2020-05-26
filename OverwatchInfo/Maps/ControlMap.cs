using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchInfo
{
	public class ControlMap : Map
	{
		public ControlMap(string name) : base(name)
		{
			Type = "control";
		}
	}
}

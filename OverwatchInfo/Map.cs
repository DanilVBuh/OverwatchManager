using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchInfo
{
	public abstract class Map
	{
		public string Name { get; set; }
		public string Type { get; set; }
		public Map(string name)
		{
			Name = name;
		}
	}
}

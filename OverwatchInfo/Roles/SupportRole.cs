﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchInfo
{
	public class SupportRole : Hero
	{
		public SupportRole(string name, int health, string pf, string sf, string fa, string sa, string ult) : base(name, health, pf, sf, fa, sa, ult)
		{
			Role = "support";
		}
	}
}

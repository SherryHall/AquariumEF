﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AquariumEF.Models
{
	public class Ocean
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public double AvgTemp { get; set; }


		public override string ToString()
		{
			var rv = $"{Id}, {Name}, Average Temp: {AvgTemp}";
			return rv;

		}
	}
}
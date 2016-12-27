using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AquariumEF.Models
{
	public class Aquarium
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string City { get; set; }


		public override string ToString()
		{
			var rv = $"{Id}, {Name}, {City}";
			return rv;

		}
	}
}
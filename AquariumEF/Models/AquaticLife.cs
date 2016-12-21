using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AquariumEF.Models
{
	public class AquaticLife

	{
		public int Id { get; set; }
		public string Type { get; set; }
		public string Name{ get; set; }
		public string Color { get; set; }
		public double Length { get; set; }
		public double Weight { get; set; }

		public virtual ICollection<AquariumAquaticLife> AquariumAquaticLifes { get; set; } = new HashSet<AquariumAquaticLife>();
	}
}
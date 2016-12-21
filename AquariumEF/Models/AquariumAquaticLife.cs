using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AquariumEF.Models
{
	public class AquariumAquaticLife
	{
		public int Id { get; set; }

		public int Aquarium_Id { get; set; }
		public virtual Aquarium Aquarium { get; set; }

		public int? AquaticLife_Id { get; set; }
		public virtual AquaticLife AquaticLife { get; set; }

		public int? Ocean_Id { get; set; }
		public virtual Ocean Ocean { get; set; }
	}
}
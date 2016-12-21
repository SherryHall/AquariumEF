using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using AquariumEF.Models;

namespace AquariumEF
{
	class AquariumDetailsContext : DbContext
	{

		public AquariumDetailsContext() : base()
		{

		}

		public DbSet<Aquarium> Aquariums { get; set; }
		public DbSet<AquaticLife> AquaticLifes { get; set; }
		public DbSet<Ocean> Ocean { get; set; }
	}
}
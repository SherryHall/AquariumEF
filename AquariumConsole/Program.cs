using AquariumEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AquariumEF
{
	public class program
	{
		// Print Out a collection
		public static void PrintCollection<T>(string heading, IEnumerable<T> list)
		{
			Console.WriteLine(heading);
			foreach (var item in list)
			{
				Console.WriteLine(item);
			}
		}
		public static void AddAquariums()
		{
			var db = new AquariumDetailsContext();
			// *** Add Aquariums ***
			var newAquarium = new Aquarium
			{
				Name = "Monterey Bay Aquarium",
				City = "Monterey"
			};

			db.Aquariums.Add(newAquarium);
			db.SaveChanges();

			newAquarium.Name = "Georgia Aquarium";
			newAquarium.City = "Atlanta";
			db.Aquariums.Add(newAquarium);
			db.SaveChanges();

			newAquarium.Name = "National Aquarium";
			newAquarium.City = "Baltimore";
			db.Aquariums.Add(newAquarium);

			db.SaveChanges();
		}
		public static void AddOceans()
		{
			var db = new AquariumDetailsContext();
			// *** Add Oceans ***
			var newOcean = new Ocean
			{
				Name = "Atlantic",
				AvgTemp = 85
			};

			db.Oceans.Add(newOcean);
			db.SaveChanges();

			newOcean.Name = "Pacific";
			newOcean.AvgTemp = 70;
			db.Oceans.Add(newOcean);
			db.SaveChanges();

			newOcean.Name = "Indian";
			newOcean.AvgTemp = 75;
			db.Oceans.Add(newOcean);
			db.SaveChanges();

			newOcean.Name = "Arctic";
			newOcean.AvgTemp = 75;
			db.Oceans.Add(newOcean);

			db.SaveChanges();
		}

		public static void AddAquaticLife()
		{
			var db = new AquariumDetailsContext();

			// *** Add Aquatic Life ***
			var newAquaticLife = new AquaticLife
			{
				Name = "Bottle Nose",
				Type = "Dophin",
				Color = "Grey",
				Length = 10.3,
				Weight = 400
			};

			db.AquaticLifes.Add(newAquaticLife);
			db.SaveChanges();

			newAquaticLife.Name = "Coastal";
			newAquaticLife.Type = "Dophin";
			newAquaticLife.Color = "Brown";
			newAquaticLife.Length = 9;
			newAquaticLife.Weight = 300;
			db.AquaticLifes.Add(newAquaticLife);
			db.SaveChanges();

			newAquaticLife.Name = "Amazon";
			newAquaticLife.Type = "Dophin";
			newAquaticLife.Color = "White";
			newAquaticLife.Length = 11.7;
			newAquaticLife.Weight = 500;
			db.AquaticLifes.Add(newAquaticLife);
			db.SaveChanges();

			newAquaticLife.Name = "Moray";
			newAquaticLife.Type = "Eel";
			newAquaticLife.Color = "Spotted";
			newAquaticLife.Length = 6.4;
			newAquaticLife.Weight = 50;
			db.AquaticLifes.Add(newAquaticLife);
			db.SaveChanges();

			newAquaticLife.Name = "European";
			newAquaticLife.Type = "Eel";
			newAquaticLife.Color = "green";
			newAquaticLife.Length = 3.9;
			newAquaticLife.Weight = 35;
			db.AquaticLifes.Add(newAquaticLife);
			db.SaveChanges();

			newAquaticLife.Name = "Nemo";
			newAquaticLife.Type = "Clownfish";
			newAquaticLife.Color = "Orange and White";
			newAquaticLife.Length = .2;
			newAquaticLife.Weight = 1;
			db.AquaticLifes.Add(newAquaticLife);
			db.SaveChanges();

			newAquaticLife.Name = "Grouper";
			newAquaticLife.Type = "Fish";
			newAquaticLife.Color = "Green";
			newAquaticLife.Length = 2;
			newAquaticLife.Weight = 8;
			db.AquaticLifes.Add(newAquaticLife);

			db.SaveChanges();
		}

		public static void AddToAquarium(int aquariumID, int aquaticLifeID, int oceanID)
		{
			var db = new AquariumDetailsContext();
			var aquarium = db.Aquariums.First(f => f.Id == aquariumID);
			var ocean = db.Oceans.First(f => f.Id == oceanID);
			var creature = db.AquaticLifes.First(f => f.Id == aquaticLifeID);

			var newResident = new AquariumAquaticLife
			{
				Aquarium = aquarium,
				Ocean = ocean,
				AquaticLife = creature

			};

			db.AquariumAquaticLifes.Add(newResident);
			db.SaveChanges();

			/*
			var myAAL = from aal as db.AquariumAquaticLife


			Join c from db.Creature on c.id equals aal.Create_Id

				....

			select aal
			*/
		}

		public static void FillAquariums()
		{

			AddToAquarium(1, 1, 1);
			AddToAquarium(1, 3, 3);
			AddToAquarium(1, 4, 2);
			AddToAquarium(1, 6, 3);
			AddToAquarium(2, 2, 2);
			AddToAquarium(2, 5, 3);
			AddToAquarium(2, 7, 4);
			AddToAquarium(3, 1, 1);
			AddToAquarium(3, 3, 3);
			AddToAquarium(3, 1, 4);
			AddToAquarium(3, 7, 2);

		}

		static void Main(string[] args)
		{
			// *** Add data to the tables
			//AddAquariums();
			//AddOceans();
			//AddAquaticLife();
			//FillAquariums();


			var db = new AquariumDetailsContext();

			// *** Query the database

			var aquariums = db.Aquariums.ToList();
			PrintCollection("Aquariums: ", aquariums);
			Console.Write("Enter an aquarium name:  ");
			var aquarium_input = Console.ReadLine();

			// *** QUERY 1: Given an Aquarium Name, What AquaticLife is there ***

			//List<AquariumAquaticLife> residents = db.AquariumAquaticLifes.Include(i => i.Aquarium).ToList();//.Where(w => w.Aquarium.Name == aquarium_input).ToList();
			List<AquariumAquaticLife> residents = db.AquariumAquaticLifes
				.Where(w => w.Aquarium.Name == aquarium_input).ToList();
			Console.WriteLine("\nLiving in this aquarium:");
			foreach (AquariumAquaticLife resident in residents)
			{
				Console.WriteLine($"{resident.AquaticLife.Name} {resident.AquaticLife.Type}");
			}

			// *** QUERY 2: Given an Ocean, What Aquariums have fish from that ocean ***

			var oceans = db.Oceans.ToList();
			PrintCollection("\nOceans: ", oceans);
			Console.Write("Enter an ocean name:  ");
			var ocean_input = Console.ReadLine();

			var resultAquariums2 = db.AquariumAquaticLifes
			.Where(w => w.Ocean.Name == ocean_input)
				.Select(s => new { s.Aquarium.Name }).Distinct().ToList();

			Console.WriteLine("\nAquariums with Life from this Ocean:");
			foreach (var resultAquarium in resultAquariums2)
			{
				Console.WriteLine($"{resultAquarium.Name}");
			}

			// *** QUERY 3: Display Distinct Cities that have aquariums ***

			var aquariumCities = db.Aquariums
								.Select(s => s.City).Distinct();
			Console.WriteLine("\nCities with Aquariums:");
			foreach (var aquariumCity in aquariumCities)
			{
				Console.WriteLine($"{aquariumCity}");
			}

			// *** QUERY 4: Display Number of species of AquaticLife live in each Ocean ***

			var speciesInOceans = db.AquariumAquaticLifes
				.GroupBy(g => new { g.Ocean.Name, g.AquaticLife.Type });

			Console.WriteLine("\nSpecies by Ocean");
			foreach (var oceanLine in speciesInOceans)
			{
				Console.WriteLine($"{oceanLine.Key.Name} {oceanLine.Key.Type} {oceanLine.Count()}");
			}

			Console.ReadLine();

			// !!!!! MARK - IGNORE BELOW THIS LINE. JUST SOME NOTES I WANT TO LOOK OVER LATER !!!!!
			//var residents = db.AquariumAquaticLifes
			//			 .Join(db.Oceans, fk => fk.Ocean_Id, pk => pk.Id, (aql, o) =>
			//			   new (AquariumAquaticLifes = aql, ocean = o})
			//                      .Join(db.Creatures, fk => fk.AquariumAquaticLifes.CreatureID, pk => pk.Id, (a, c) =>
			//			  new { AquariumAquaticLifes = a.AquariumAquaticLifes, Ocean = a.Ocean, Creature = c });
			//                      .Join(db.Aquariums, fk=> fk.AquariumAquaticLifes.AquariumID, pk => pk.Id (a, aq) =>
			//		 new { AquariumAquaticLifes = a.AquariumAquaticLifes, Ocean = a.Ocean, Creature = a.Creature, Aquarium = aq });

			//foreach (AquariumAquaticLife resident in residents)
			//{
			//	Console.WriteLine($"{resident.Name} is from the {resdient.Aquarium.Name}.");
			//}
			//Console.WriteLine(
			//Console.WriteLine($"The Aquarium is: {myAquarium.}");

			// save the changes to the database
			//db.SaveChanges();
			//var allCustomers = db.Customers.ToList();
		}
	}
}
//using AquariumEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AquariumEF
{
	public class program
	{
		//// Print Out a collection
		//public static void PrintCollection<T>(string heading, IEnumerable<T> list) 
		//{
		//	Console.WriteLine(heading);
		//	foreach (var item in list)
		//	{
		//		Console.WriteLine(item);
		//	}
		//}
		//public static void AddAquariums()
		//{
		//	var db = new AquariumDetailsContext();
		//	// *** Add Aquariums ***
		//	var newAquarium = new Aquarium
		//	{
		//		Name = "Monterey Bay Aquarium",
		//		City = "Monterey"
		//	};

		//	db.Aquariums.Add(newAquarium);
		//	db.SaveChanges();

		//	newAquarium.Name = "Georgia Aquarium";
		//	newAquarium.City = "Atlanta";
		//	db.Aquariums.Add(newAquarium);
		//	db.SaveChanges();

		//	//newAquarium.Name = "National Aquarium";
		//	//newAquarium.City = "Baltimore";
		//	//db.Aquariums.Add(newAquarium);

		//	//db.SaveChanges();
		//}
		//public static void AddOceans()
		//{
		//	var db = new AquariumDetailsContext();
		//	// *** Add Oceans ***
		//	var newOcean = new Ocean
		//	{
		//		Name = "Atlantic",
		//		AvgTemp = 85
		//	};

		//	db.Oceans.Add(newOcean);
		//	db.SaveChanges();

		//	newOcean.Name = "Pacific";
		//	newOcean.AvgTemp = 70;
		//	db.Oceans.Add(newOcean);
		//	db.SaveChanges();

		//	newOcean.Name = "Indian";
		//	newOcean.AvgTemp = 75;
		//	db.Oceans.Add(newOcean);
		//	db.SaveChanges();

		//	//newOcean.Name = "Arctic";
		//	//newOcean.AvgTemp = 75;
		//	//db.Oceans.Add(newOcean);

		//	//db.SaveChanges();
		//}

		//public static void AddAquaticLife()
		//{
		//	var db = new AquariumDetailsContext();
		//	// *** Add Aquatic Life ***
		//	var newAquaticLife = new AquaticLife
		//	{
		//		Name = "Bottle Nose",
		//		Type = "Dophin",
		//		Color = "Grey",
		//		Length = 10.3,
		//		Weight = 400
		//	};

		//	db.AquaticLifes.Add(newAquaticLife);
		//	db.SaveChanges();

		//	newAquaticLife.Name = "Coastal";
		//	newAquaticLife.Type = "Dophin";
		//	newAquaticLife.Color = "Brown";
		//	newAquaticLife.Length = 9;
		//	newAquaticLife.Weight = 300;
		//	db.AquaticLifes.Add(newAquaticLife);
		//	db.SaveChanges();

		//	newAquaticLife.Name = "Amazon";
		//	newAquaticLife.Type = "Dophin";
		//	newAquaticLife.Color = "White";
		//	newAquaticLife.Length = 11.7;
		//	newAquaticLife.Weight = 500;
		//	db.AquaticLifes.Add(newAquaticLife);
		//	db.SaveChanges();

		//	newAquaticLife.Name = "Moray";
		//	newAquaticLife.Type = "Eel";
		//	newAquaticLife.Color = "Spotted";
		//	newAquaticLife.Length = 6.4;
		//	newAquaticLife.Weight = 50;
		//	db.AquaticLifes.Add(newAquaticLife);
		//	db.SaveChanges();

		//	newAquaticLife.Name = "European";
		//	newAquaticLife.Type = "Eel";
		//	newAquaticLife.Color = "green";
		//	newAquaticLife.Length = 3.9;
		//	newAquaticLife.Weight = 35;
		//	db.AquaticLifes.Add(newAquaticLife);
		//	db.SaveChanges();

		//	newAquaticLife.Name = "Nemo";
		//	newAquaticLife.Type = "Clownfish";
		//	newAquaticLife.Color = "Orange and White";
		//	newAquaticLife.Length = .2;
		//	newAquaticLife.Weight = 1;
		//	db.AquaticLifes.Add(newAquaticLife);
		//	db.SaveChanges();

		//	//newAquaticLife.Name = "Grouper";
		//	//newAquaticLife.Type = "Fish";
		//	//newAquaticLife.Color = "Green";
		//	//newAquaticLife.Length = 2;
		//	//newAquaticLife.Weight = 8;
		//	//db.AquaticLifes.Add(newAquaticLife);

		//	//db.SaveChanges();
		//}
		//public static void FillAquariums()
		//{
		//	var db = new AquariumDetailsContext();
		//	// *** Add Aquatic Life to Aquariums ***
		//	var newAquariumAquaticLife = new AquariumAquaticLife
		//	{
		//		Aquarium_Id = 1,
		//		AquaticLife_Id = 1,
		//		Ocean_Id = 1
		//	};
		//	db.AquariumAquaticLifes.Add(newAquariumAquaticLife);
		//	db.SaveChanges();

		//	newAquariumAquaticLife.Aquarium_Id = 1;
		//	newAquariumAquaticLife.AquaticLife_Id = 1;
		//	newAquariumAquaticLife.Ocean_Id = 1;
		//	db.AquariumAquaticLifes.Add(newAquariumAquaticLife);
		//	db.SaveChanges();

		//	newAquariumAquaticLife.Aquarium_Id = 1;
		//	newAquariumAquaticLife.AquaticLife_Id = 4;
		//	newAquariumAquaticLife.Ocean_Id = 2;
		//	db.AquariumAquaticLifes.Add(newAquariumAquaticLife);
		//	db.SaveChanges();

		//	newAquariumAquaticLife.Aquarium_Id = 1;
		//	newAquariumAquaticLife.AquaticLife_Id = 6;
		//	newAquariumAquaticLife.Ocean_Id = 3;
		//	db.AquariumAquaticLifes.Add(newAquariumAquaticLife);
		//	db.SaveChanges();

		//	newAquariumAquaticLife.Aquarium_Id = 2;
		//	newAquariumAquaticLife.AquaticLife_Id = 2;
		//	newAquariumAquaticLife.Ocean_Id = 2;
		//	db.AquariumAquaticLifes.Add(newAquariumAquaticLife);
		//	db.SaveChanges();

		//	newAquariumAquaticLife.Aquarium_Id = 2;
		//	newAquariumAquaticLife.AquaticLife_Id = 5;
		//	newAquariumAquaticLife.Ocean_Id = 3;
		//	db.AquariumAquaticLifes.Add(newAquariumAquaticLife);
		//	db.SaveChanges();

		//	newAquariumAquaticLife.Aquarium_Id = 2;
		//	newAquariumAquaticLife.AquaticLife_Id = 7;
		//	newAquariumAquaticLife.Ocean_Id = 4;
		//	db.AquariumAquaticLifes.Add(newAquariumAquaticLife);
		//	db.SaveChanges();

		//	newAquariumAquaticLife.Aquarium_Id = 3;
		//	newAquariumAquaticLife.AquaticLife_Id = 1;
		//	newAquariumAquaticLife.Ocean_Id = 1;
		//	db.AquariumAquaticLifes.Add(newAquariumAquaticLife);
		//	db.SaveChanges();

		//	newAquariumAquaticLife.Aquarium_Id = 3;
		//	newAquariumAquaticLife.AquaticLife_Id = 3;
		//	newAquariumAquaticLife.Ocean_Id = 3;
		//	db.AquariumAquaticLifes.Add(newAquariumAquaticLife);
		//	db.SaveChanges();

		//	newAquariumAquaticLife.Aquarium_Id = 7;
		//	newAquariumAquaticLife.AquaticLife_Id = 1;
		//	newAquariumAquaticLife.Ocean_Id = 4;
		//	db.AquariumAquaticLifes.Add(newAquariumAquaticLife);
		//	db.SaveChanges();

		//	//newAquariumAquaticLife.Aquarium_Id = 3;
		//	//newAquariumAquaticLife.AquaticLife_Id = 7;
		//	//newAquariumAquaticLife.Ocean_Id = 2;
		//	//db.AquariumAquaticLifes.Add(newAquariumAquaticLife);

		//	//db.SaveChanges();
		//}

		//static void Main(string[] args)
		//{
		//	// *** Add data to the tables
		//	//AddAquariums();
		//	//AddOceans();
		//	//AddAquaticLife();
		//	//FillAquariums();
			
		//	var db = new AquariumDetailsContext();

		//	// *** Query the database

		//	var aquariums = db.Aquariums.ToList();
		//	PrintCollection("Aquariums: ", aquariums);
		//	Console.Write("Enter an aquarium name:  ");
		//	var aquarium_input = Console.ReadLine();

		//	var myAquarium = db.Aquariums
		//		.Where(w => w.City == "Atlanta"  )
		//		.Select(s => new { s.Id, s.Name, s.City });

		//	PrintCollection("My Aquariums: ", myAquarium);

			//given an Aquarium Name, What AquaticLife is there

			//List<AquariumAquaticLife> residents = db.AquariumAquaticLifes.Include(i => i.Aquarium).ToList();//.Where(w => w.Aquarium.Name == aquarium_input).ToList();

			//var residents = db.AquariumAquaticLifes
			//			 .Join(db.Oceans, fk => fk.Ocean_Id, pk => pk.Id, (aql, o) =>
			//			   new (AquariumAquaticLife = aql, ocean = o})
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
		//}
	}
}
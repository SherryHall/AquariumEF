using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AquariumEF
{
	public class program
	{
		// Print Out a collection
		public static void PrintCollection(string heading, IEnumerable<Customer> list)
		{
			Console.WriteLine(heading);
			foreach (var customer in list)
			{
				Console.WriteLine(customer);
			}
		}

		static void Main(string[] args)
		{
			var db = new   ();
		}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace this_is_a_test
{
	class Program
	{
		static void Main( string[] args )
		{
			var assembly = Assembly.GetExecutingAssembly();

			Console.WriteLine( assembly.GetName().Version );
			Console.WriteLine( assembly.GetCustomAttribute<AssemblyFileVersionAttribute>().Version );
			Console.WriteLine( assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion );

			Console.Write( "done." );
			Console.ReadKey( true );
		}
	}
}

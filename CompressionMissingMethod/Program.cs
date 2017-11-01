using System;
using System.IO;
using System.IO.Compression;
using Microsoft.Build.Evaluation;
using Microsoft.Build.Exceptions;

namespace CompressionMissingMethod
{
	class Program
	{
		static void Main(string[] args)
		{
			// Do something simple with Compression
			try
			{
				ZipFile.OpenRead(Guid.NewGuid().ToString("N") + ".zip");
			}
			catch (FileNotFoundException)
			{
			}

			// Do something simple with MSBuild
			try
			{
				new Project().ToString();
			}
			catch (InvalidProjectFileException)
			{
			}

			Console.WriteLine("Everything worked, or failed as expected.");
		}
	}
}

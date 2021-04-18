using System;

namespace การบ้านครั้งที่4._2
{
	public class Program
	{
		static bool isinputValid()
		{
			string YN = Console.ReadLine();
			while ((YN != "Y") && (YN != "N"))
			{
				Console.WriteLine("Please input Y or N.");
				YN = Console.ReadLine();
			}

			if (YN == "Y")
			{
				return true;
			}

			return false;
		}

		static bool IsValidSequence(string halfDNASequence)
		{
			foreach (char nucleotide in halfDNASequence)
			{
				if (!"ATCG".Contains(nucleotide.ToString()))
				{
					return false;
				}
			}
			return true;
		}

		static string ReplicateSequence(string halfDNASequence)
		{
			string result = "";
			foreach (char nucleotide in halfDNASequence)
			{
				result += "TAGC"["ATCG".IndexOf(nucleotide)];
			}

			return result;
		}

		static void hellloop()
		{
			string halfDNASequence = Console.ReadLine();
			if (IsValidSequence(halfDNASequence))
			{
				Console.WriteLine("Current half DNA sequence : " + halfDNASequence + "\n");
				Console.WriteLine("Do you want to replicate it ? (Y/N): ");
				if (isinputValid())
				{
					Console.WriteLine("Replicated half DNA sequence : " + ReplicateSequence(halfDNASequence) + "\n");
					Console.WriteLine("Do you want to process another sequence ? (Y/N) : ");
					if (isinputValid())
					{
						hellloop();
					}
				}
				else
				{
					Console.WriteLine("Do you want to process another sequence ? (Y/N) : ");
					if (isinputValid())
					{
						hellloop();
					}
				}
			}
			else
			{
				Console.WriteLine("That half DNA sequence is invalid.");
				Console.WriteLine("Do you want to process another sequence ? (Y/N) : ");
				if (isinputValid())
				{
					hellloop();
				}
			}
		}

		public static void Main(string[] args)
		{
			hellloop();
		}
	}
}
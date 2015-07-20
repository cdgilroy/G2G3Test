using System.Text;

namespace SkeletonCode.ReversingString
{
	public class StringUtilities
	{
		public string Reverse(string input)
		{
			// Handle null input by converting it to empty string
			if (input == null)
				input = "";

			string output = string.Empty;

			// Strings in C# are immutable and cannot be changed in memory once created
			// String contatenation operations create temp strings behind the scenes
			// Using StringBuilder (which is mutable) inside the loop reduces memory allocation operations for long strings

			StringBuilder tempOutput = new StringBuilder(output);

			for(int i = input.Length - 1; i >= 0; i--)
			{
				//output += input[i];
				tempOutput.Append(input[i]);
			}

			output = tempOutput.ToString();
			return output;
		}
	}
}

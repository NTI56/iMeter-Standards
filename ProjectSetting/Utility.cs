using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTI.iMeter.ProjectSetting
{
	/// <summary>
	/// Provide extension methods. This class is static.
	/// </summary>
	internal static class Utility
	{
		/// <summary>
		/// Determine if the string contains any alternative char.
		/// </summary>
		/// <param name="value">The source string.</param>
		/// <param name="anyOf">A collection of chars to be determined.</param>
		/// <returns>If the <paramref name="value"/> contains any char in <paramref name="anyOf"/> argument, returns <c>true</c>; otherwise return <c>false</c>.</returns>
		public static bool ContainsAny(this string value, params char[] anyOf) => value.IndexOfAny(anyOf) != -1;
	}
}

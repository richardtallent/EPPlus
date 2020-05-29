using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace EPPlusExcelFormDemo {
	internal static class ConvertUtil {
		internal static bool IsNumeric(object candidate) => candidate == null
				? false
				: candidate.GetType().IsPrimitive || candidate is double || candidate is decimal || candidate is DateTime || candidate is TimeSpan || candidate is long;

		internal static bool IsNumericString(object candidate) => candidate != null ? Regex.IsMatch(candidate.ToString(), @"^[\d]+(\,[\d])?") : false;

		/// <summary>
		/// Convert an object value to a double 
		/// </summary>
		/// <param name="v"></param>
		/// <param name="ignoreBool"></param>
		/// <returns></returns>
		internal static double GetValueDouble(object v, bool ignoreBool = false) {
			double d;
			try {
				if (ignoreBool && v is bool) {
					return 0;
				}
				if (IsNumeric(v)) {
					if (v is DateTime) {
						d = ((DateTime)v).ToOADate();
					} else {
						d = v is TimeSpan ? DateTime.FromOADate(0).Add((TimeSpan)v).ToOADate() : Convert.ToDouble(v, CultureInfo.InvariantCulture);
					}
				} else {
					d = 0;
				}
			} catch {
				d = 0;
			}
			return d;
		}
	}
}

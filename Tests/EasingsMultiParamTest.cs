using System.Collections.Generic;
using System.Reflection;
using Retromono.Easings;
using Xunit;

namespace Tests
{
	public class EasingsMultiParamTest
	{
		public static IEnumerable<MethodInfo> GetEasings()
		{
			var methods = typeof(EasingsMultiParam).GetMethods();

			foreach (var methodInfo in methods)
			{
				if (!methodInfo.IsStatic || !methodInfo.IsPublic)
				{
					continue;
				}

				yield return methodInfo;
			}
		}

		public static IEnumerable<double[]> GetFromToValues()
		{
			yield return new double[] {0, 1};
			yield return new double[] {10, 100};
			yield return new double[] {100, -100};
		}

		public static IEnumerable<double> GetDurations()
		{
			yield return 1;
			yield return 100;
		}

		public static IEnumerable<object[]> GetTestParams()
		{
			foreach (var methodInfo in GetEasings())
			{
				foreach (var fromToValue in GetFromToValues())
				{
					foreach (var duration in GetDurations())
					{
						yield return new object[] {methodInfo, fromToValue[0], fromToValue[1], duration};
					}
				}
			}
		}

		[Theory]
		[MemberData(nameof(GetTestParams))]
		public void ShouldReturnZeroAtZeroTime(MethodInfo methodInfo, double from, double to, double duration)
		{
			var result = (double) methodInfo.Invoke(null, new object[] {0, from, to, duration});

			Assert.Equal(from, result, 10);
		}

		[Theory]
		[MemberData(nameof(GetTestParams))]
		public void ShouldReturnOneAtEnd(MethodInfo methodInfo, double from, double to, double duration)
		{
			var result = (double) methodInfo.Invoke(null, new object[] {duration, from, to, duration});

			Assert.Equal(to, result, 10);
		}
	}
}
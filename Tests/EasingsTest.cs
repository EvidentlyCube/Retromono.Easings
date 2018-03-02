using System;
using System.Collections.Generic;
using System.Reflection;
using Retromono.Easings;
using Xunit;

namespace Tests {
    public class EasingsTest {
        public static IEnumerable<object[]> GetEasings() {
            var methods = typeof(Easings).GetMethods();

            foreach (var methodInfo in methods) {
                if (!methodInfo.IsStatic || !methodInfo.IsPublic) {
                    continue;
                }

                yield return new object[]{methodInfo};
            }
        }

        [Theory]
        [MemberData(nameof(GetEasings))]
        public void ShouldReturnZeroAtZeroTime(MethodInfo methodInfo) {
            var result = (double)methodInfo.Invoke(null, new object[]{0});
            
            Assert.Equal(0, result, 10);
        }

        [Theory]
        [MemberData(nameof(GetEasings))]
        public void ShouldReturnOneAtEnd(MethodInfo methodInfo)
        {
            var result = (double)methodInfo.Invoke(null, new object[] { 1 });

            Assert.Equal(1, result, 10);
        }

        [Theory]
        [MemberData(nameof(GetEasings))]
        public void ShouldNeverReturnNanOrInfinityForValidValues(MethodInfo methodInfo)
        {
            for (var i = 1; i < 100; i++)
            {
                var result = (double)methodInfo.Invoke(null, new object[] { i / 100 });

                Assert.True(!double.IsNaN(result));
                Assert.True(!double.IsInfinity(result));
            }
        }

        [Theory]
        [MemberData(nameof(GetEasings))]
        public void ShouldNeverReturnAnInsaneValue(MethodInfo methodInfo)
        {
            for (var i = 1; i < 100; i++)
            {
                var result = (double)methodInfo.Invoke(null, new object[] { i / 100.0 });

                Assert.InRange(result, -1, 2);
            }
        }
    }
}
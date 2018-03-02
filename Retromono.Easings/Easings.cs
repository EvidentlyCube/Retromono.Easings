using System;

// FROM 
namespace Retromono.Easings
{
	/// <summary>
	/// Collection of easing that take 1 argument: the time between 0 and 1 (inclusive).
	/// </summary>
	/// <remarks>
	/// A set of static easing functions that all take a single parameter, time, of the value between 0 and 1 and
	/// return the transformation of the time. When always return <c>0</c> when passed <c>0</c> and <c>1</c> when
	/// passed <c>1</c>.
	/// </remarks>
	/// <see href="http://easings.net/">Visit Easings.net for visualisations.</see>
	/// <see href="https://github.com/krig/easing/blob/master/easing.hpp">Original source.</see>
	public static class Easings {
        /// <summary>
        /// Starts slower and then accelerates, creates a very soft curve.
        /// </summary>
        /// <param name="t">Time in the value between 0 and 1 (inclusive)</param>
        /// <returns>Eased time</returns>
        public static double SineIn(double t) {
            return Math.Sin((t - 1.0) * Math.PI * 0.5) + 1.0;
        }

        /// <summary>
        /// Starts faster and then decelerates, creates a very soft curve.
        /// </summary>
        /// <param name="t">Time in the value between 0 and 1 (inclusive)</param>
        /// <returns>Eased time</returns>
        public static double SineOut(double t) {
            return Math.Sin(t * Math.PI * 0.5);
        }

        /// <summary>
        /// Starts slower and then accelerates and past the middle point it starts to decelerate, creates a very soft curve.
        /// </summary>
        /// <param name="t">Time in the value between 0 and 1 (inclusive)</param>
        /// <returns>Eased time</returns>
        public static double SineInOut(double t) {
            return 0.5 * (1.0 - Math.Cos(t * Math.PI));
        }

        /// <summary>
        /// Starts slower and then accelerates, creates a slightly bigger curve than <see cref="SineIn"/>.
        /// </summary>
        /// <param name="t">Time in the value between 0 and 1 (inclusive)</param>
        /// <returns>Eased time</returns>
        public static double QuadraticIn(double t) {
            return t * t;
        }

        /// <summary>
        /// Starts faster and then decelerates, creates a slightly bigger curve than <see cref="SineOut"/>.
        /// </summary>
        /// <param name="t">Time in the value between 0 and 1 (inclusive)</param>
        /// <returns>Eased time</returns>
        public static double QuadraticOut(double t) {
            return -(t * (t - 2.0));
        }

        /// <summary>
        /// Starts slower and then accelerates and past the middle point it starts to decelerate,
        /// creates a slightly bigger curve than <see cref="SineInOut"/>.
        /// </summary>
        /// <param name="t">Time in the value between 0 and 1 (inclusive)</param>
        /// <returns>Eased time</returns>
        public static double QuadraticInOut(double t) {
            return t < 0.5 ? 2.0 * t * t : -2.0 * t * t + 4.0 * t - 1.0;
        }

        /// <summary>
        /// Starts slower and then accelerates, creates a bigger curve than <see cref="QuadraticIn"/> that is clearly visible.
        /// </summary>
        /// <param name="t">Time in the value between 0 and 1 (inclusive)</param>
        /// <returns>Eased time</returns>
        public static double CubicIn(double t) {
            return t * t * t;
        }

        /// <summary>
        /// Starts faster and then decelerates, creates a bigger curve than <see cref="QuadraticOut"/> that is clearly visible.
        /// </summary>
        /// <param name="t">Time in the value between 0 and 1 (inclusive)</param>
        /// <returns>Eased time</returns>
        public static double CubicOut(double t) {
            var f = t - 1.0;
            return f * f * f + 1.0;
        }

        /// <summary>
        /// Starts slower and then accelerates and past the middle point it starts to decelerate,
        /// creates a bigger curve than <see cref="QuadraticInOut"/> that is clearly visible.
        /// </summary>
        /// <param name="t">Time in the value between 0 and 1 (inclusive)</param>
        /// <returns>Eased time</returns>
        public static double CubicInOut(double t) {
            if (t < 0.5) {
                return 4.0 * t * t * t;
            }
            else {
                var f = 2.0 * t - 2.0;
                return 0.5 * f * f * f + 1.0;
            }
        }

        /// <summary>
        /// Starts slower and then accelerates, creates a bigger curve than <see cref="CubicIn"/>.
        /// </summary>
        /// <param name="t">Time in the value between 0 and 1 (inclusive)</param>
        /// <returns>Eased time</returns>
        public static double QuarticIn(double t) {
            return t * t * t * t;
        }

        /// <summary>
        /// Starts faster and then decelerates, creates a bigger curve than <see cref="CubicOut"/>.
        /// </summary>
        /// <param name="t">Time in the value between 0 and 1 (inclusive)</param>
        /// <returns>Eased time</returns>
        public static double QuarticOut(double t) {
            var f = t - 1.0;
            return f * f * f * (1.0 - t) + 1.0;
        }

        /// <summary>
        /// Starts slower and then accelerates and past the middle point it starts to decelerate,
        /// creates a bigger curve than <see cref="CubicInOut"/>.
        /// </summary>
        /// <param name="t">Time in the value between 0 and 1 (inclusive)</param>
        /// <returns>Eased time</returns>
        public static double QuarticInOut(double t) {
            if (t < 0.5) {
                return 8.0 * t * t * t * t;
            }

            var f = t - 1.0;
            return -8.0 * f * f * f * f + 1.0;
        }

        /// <summary>
        /// Starts slower and then accelerates, creates a bigger curve than <see cref="QuarticIn"/>.
        /// </summary>
        /// <param name="t">Time in the value between 0 and 1 (inclusive)</param>
        /// <returns>Eased time</returns>
        public static double QuinticIn(double t) {
            return t * t * t * t * t;
        }

        /// <summary>
        /// Starts faster and then decelerates, creates a bigger curve than <see cref="QuarticOut"/>.
        /// </summary>
        /// <param name="t">Time in the value between 0 and 1 (inclusive)</param>
        /// <returns>Eased time</returns>
        public static double QuinticOut(double t) {
            var f = t - 1.0;
            return f * f * f * f * f + 1.0;
        }

        /// <summary>
        /// Starts slower and then accelerates and past the middle point it starts to decelerate,
        /// creates a bigger curve than <see cref="QuarticInOut"/>.
        /// </summary>
        /// <param name="t">Time in the value between 0 and 1 (inclusive)</param>
        /// <returns>Eased time</returns>
        public static double QuinticInOut(double t) {
            if (t < 0.5) {
                return 16.0 * t * t * t * t * t;
            }

            var f = 2.0 * t - 2.0;
            return 0.5 * f * f * f * f * f + 1.0;
        }

        /// <summary>
        /// Starts slower and then accelerates, creates a bigger curve than <see cref="QuinticIn"/>.
        /// </summary>
        /// <param name="t">Time in the value between 0 and 1 (inclusive)</param>
        /// <returns>Eased time</returns>
        public static double ExponentialIn(double t) {
            return t <= 0 ? t : Math.Pow(2.0, 10.0 * (t - 1.0));
        }

        /// <summary>
        /// Starts faster and then decelerates, creates a bigger curve than <see cref="QuinticOut"/>.
        /// </summary>
        /// <param name="t">Time in the value between 0 and 1 (inclusive)</param>
        /// <returns>Eased time</returns>
        public static double ExponentialOut(double t) {
            return t >= 1.0 ? t : 1.0 - Math.Pow(2.0, -10.0 * t);
        }

        /// <summary>
        /// Starts slower and then accelerates and past the middle point it starts to decelerate,
        /// creates a bigger curve than <see cref="QuinticInOut"/>.
        /// </summary>
        /// <param name="t">Time in the value between 0 and 1 (inclusive)</param>
        /// <returns>Eased time</returns>
        public static double ExponentialInOut(double t) {
	        if (t <= 0 || t >= 1.0) {
		        return t;
	        }

	        if (t < 0.5) {
                return 0.5 * Math.Pow(2.0, 20.0 * t - 10.0);
            }
            else {
                return -0.5 * Math.Pow(2.0, -20.0 * t + 10.0) + 1.0;
            }
        }

        /// <summary>
        /// Starts slower and then starts accelerating fast, creating a very sharp curve that visually is similar to a quarter of a circle.
        /// </summary>
        /// <param name="t">Time in the value between 0 and 1 (inclusive)</param>
        /// <returns>Eased time</returns>
        public static double CircularIn(double t) {
            return 1.0 - Math.Sqrt(1.0 - t * t);
        }

        /// <summary>
        /// Starts super faster and then decelerates quickly, creating a very sharp curve that visually is similar to a quarter of a circle.
        /// </summary>
        /// <param name="t">Time in the value between 0 and 1 (inclusive)</param>
        /// <returns>Eased time</returns>
        public static double CircularOut(double t) {
            return Math.Sqrt((2.0 - t) * t);
        }

        /// <summary>
        /// Starts slower and then starts accelerating fast and past the middle point it starts to decelerate fast, creating a very sharp curve.
        /// creates a bigger curve than <see cref="QuinticInOut"/>.
        /// </summary>
        /// <param name="t">Time in the value between 0 and 1 (inclusive)</param>
        /// <returns>Eased time</returns>
        public static double CircularInOut(double t) {
            if (t < 0.5) {
                return 0.5 * (1 - Math.Sqrt(1 - 4.0 * (t * t)));
            }
            else {
                return 0.5 * (Math.Sqrt(-(2.0 * t - 3.0) * (2.0 * t - 1.0)) + 1.0);
            }
        }

        /// <summary>
        /// Starts with a backwards swing and then accelerates.
        /// </summary>
        /// <param name="t">Time in the value between 0 and 1 (inclusive)</param>
        /// <returns>Eased time</returns>
        public static double BackIn(double t) {
            return t * t * t - t * Math.Sin(t * Math.PI);
        }

        /// <summary>
        /// Starts fast and then ends with a swing past the end point.
        /// </summary>
        /// <param name="t">Time in the value between 0 and 1 (inclusive)</param>
        /// <returns>Eased time</returns>
        public static double BackOut(double t) {
            var f = 1.0 - t;
            return 1.0 - (f * f * f - f * Math.Sin(f * Math.PI));
        }

        /// <summary>
        /// Starts with a backwards swing and ends with a swing past the end point.
        /// </summary>
        /// <param name="t">Time in the value between 0 and 1 (inclusive)</param>
        /// <returns>Eased time</returns>
        public static double BackInOut(double t) {
            if (t < 0.5) {
                var f = 2.0 * t;
                return 0.5 * (f * f * f - f * Math.Sin(f * Math.PI));
            }
            else {
                var f = 1.0 - (2.0 * t - 1.0);
                return 0.5 * (1.0 - (f * f * f - f * Math.Sin(f * Math.PI))) + 0.5;
            }
        }

        /// <summary>
        /// Starts swinging back and forth and then very quickly runs to the endpoint.
        /// </summary>
        /// <param name="t">Time in the value between 0 and 1 (inclusive)</param>
        /// <returns>Eased time</returns>
        public static double ElasticIn(double t) {
            return Math.Sin(13.0 * Math.PI * 0.5 * t) * Math.Pow(2.0, 10.0 * (t - 1.0));
        }

        /// <summary>
        /// Gets to the end point very quickly and swings to the place like a spring.
        /// </summary>
        /// <param name="t">Time in the value between 0 and 1 (inclusive)</param>
        /// <returns>Eased time</returns>
        public static double ElasticOut(double t) {
            return Math.Sin(-13.0 * Math.PI * 0.5 * (t + 1.0)) * Math.Pow(2.0, -10.0 * t) + 1.0;
        }

        /// <summary>
        /// Starts with multiple swings back and forth and ends with multiple swings back and forth with really fast
        /// transition through the middle.
        /// </summary>
        /// <param name="t">Time in the value between 0 and 1 (inclusive)</param>
        /// <returns>Eased time</returns>
        public static double ElasticInOut(double t) {
            if (t < 0.5) {
                return 0.5 * Math.Sin(13.0 * Math.PI * 0.5 * (2.0 * t)) * Math.Pow(2.0, 10.0 * (2.0 * t - 1.0));
            }
            else {
                return 0.5 * (Math.Sin(-13.0 * Math.PI * 0.5 * (2.0 * t - 1 + 1)) * Math.Pow(2.0, -10.0 * (2.0 * t - 1.0)) + 2.0);
            }
        }
        
        /// <summary>
        /// Performs a set of 4 bounces where the midpoint of the fourth is the final position.
        /// </summary>
        /// <param name="t">Time in the value between 0 and 1 (inclusive)</param>
        /// <returns>Eased time</returns>
        public static double BounceOut(double t) {
            if (t < 4.0 / 11.0) {
                return 121.0 * t * t / 16.0;
            }
            else if (t < 8.0 / 11.0) {
                return 363.0 / 40.0 * t * t - 99 / 10.0 * t + 17 / 5.0;
            }
            else if (t < 9.0 / 10.0) {
                return 4356.0 / 361.0 * t * t - 35442.0 / 1805.0 * t + 16061.0 / 1805.0;
            }
            else {
                return 54.0 / 5.0 * t * t - 513.0 / 25.0 * t + 268.0 / 25.0;
            }
        }

        /// <summary>
        /// Starts from the midpoint of a bounce and then does 3 more bounces that get progressively weaker.
        /// </summary>
        /// <param name="t">Time in the value between 0 and 1 (inclusive)</param>
        /// <returns>Eased time</returns>
        public static double BounceIn(double t) {
            return 1.0 - BounceOut(1.0 - t);
        }

        /// <summary>
        /// Starts with a set of 4 bounces where the midpoint of the fourth one is in the midpoint of the ease
        /// and then continues as if starting from a middle of a bounce then does 3 more bounces that get progressively weaker.
        /// </summary>
        /// <param name="t">Time in the value between 0 and 1 (inclusive)</param>
        /// <returns>Eased time</returns>
        public static double BounceInOut(double t) {
            if (t < 0.5) {
                return 0.5 * BounceIn(t * 2.0);
            }
            else {
                return 0.5 * BounceOut(t * 2.0 - 1.0) + 0.5;
            }
        }

        /// <summary>
        /// Dynamically accelerates until the middle point and then decelerates.
        /// </summary>
        /// <param name="t">Time in the value between 0 and 1 (inclusive)</param>
        /// <returns>Eased time</returns>
        public static double PerlinInOut(double t) {
            var t3 = t * t * t;
            var t4 = t3 * t;
            var t5 = t4 * t;
            return 6.0 * t5 - 15.0 * t4 + 10.0 * t3;
        }
    }
}
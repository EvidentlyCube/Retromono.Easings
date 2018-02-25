using System;

// FROM https://github.com/krig/easing/blob/master/easing.hpp
namespace Retromono.Easings {
    /// <summary>
    /// A set of static easing functions that all take four parameters, current time, starting and final value and
    /// the duration. When time is <c>0</c> it returns the starting value, when time is equal to duration it
    /// returns the target value. 
    /// For a visualisation visit <a href="http://easings.net/">Easings.net</a>
    /// </summary>
    public static class EasingsMultiParam {
        /// <summary>
        /// Starts slower and then accelerates, creates a very soft curve.
        /// </summary>
        /// <param name="t">Time in the value between 0 and duration (inclusive)</param>
        /// <param name="from">Starting value from the ease</param>
        /// <param name="to">Target value to ease</param>
        /// <param name="duration">Duration of the ease</param>
        /// <returns>Eased value</returns>
        public static double SineIn(double t, double from, double to, double duration) {
            return from + (to - from) * Easings.SineIn(t / duration);
        }

        /// <summary>
        /// Starts slower and then accelerates and past the middle point it starts to decelerate, creates a very soft curve.
        /// </summary>
        /// <param name="t">Time in the value between 0 and duration (inclusive)</param>
        /// <param name="from">Starting value from the ease</param>
        /// <param name="to">Target value to ease</param>
        /// <param name="duration">Duration of the ease</param>
        /// <returns>Eased value</returns>
        public static double SineOut(double t, double from, double to, double duration) {
            return from + (to - from) * Easings.SineOut(t / duration);
        }

        /// <summary>
        /// Starts slower and then accelerates and past the middle point it starts to decelerate, creates a very soft curve.
        /// </summary>
        /// <param name="t">Time in the value between 0 and duration (inclusive)</param>
        /// <param name="from">Starting value from the ease</param>
        /// <param name="to">Target value to ease</param>
        /// <param name="duration">Duration of the ease</param>
        /// <returns>Eased value</returns>
        public static double SineInOut(double t, double from, double to, double duration) {
            return from + (to - from) * Easings.SineInOut(t / duration);
        }

        /// <summary>
        /// Starts faster and then deccelerates, creates a very soft curve.
        /// </summary>
        /// <param name="t">Time in the value between 0 and duration (inclusive)</param>
        /// <param name="from">Starting value from the ease</param>
        /// <param name="to">Target value to ease</param>
        /// <param name="duration">Duration of the ease</param>
        /// <returns>Eased value</returns>
        public static double QuadraticIn(double t, double from, double to, double duration) {
            return from + (to - from) * Easings.QuadraticIn(t / duration);
        }

        /// <summary>
        /// Starts faster and then decelerates, creates a slightly bigger curve than <see cref="SineOut"/>.
        /// </summary>
        /// <param name="t">Time in the value between 0 and duration (inclusive)</param>
        /// <param name="from">Starting value from the ease</param>
        /// <param name="to">Target value to ease</param>
        /// <param name="duration">Duration of the ease</param>
        /// <returns>Eased value</returns>
        public static double QuadraticOut(double t, double from, double to, double duration) {
            return from + (to - from) * Easings.QuadraticOut(t / duration);
        }

        /// <summary>
        /// Starts slower and then accelerates and past the middle point it starts to decelerate,
        /// creates a slightly bigger curve than <see cref="SineInOut"/>.
        /// </summary>
        /// <param name="t">Time in the value between 0 and duration (inclusive)</param>
        /// <param name="from">Starting value from the ease</param>
        /// <param name="to">Target value to ease</param>
        /// <param name="duration">Duration of the ease</param>
        /// <returns>Eased value</returns>
        public static double QuadraticInOut(double t, double from, double to, double duration) {
            return from + (to - from) * Easings.QuadraticInOut(t / duration);
        }

        /// <summary>
        /// Starts slower and then accelerates, creates a bigger curve than <see cref="QuadraticIn"/> that is clearly visible.
        /// </summary>
        /// <param name="t">Time in the value between 0 and duration (inclusive)</param>
        /// <param name="from">Starting value from the ease</param>
        /// <param name="to">Target value to ease</param>
        /// <param name="duration">Duration of the ease</param>
        /// <returns>Eased value</returns>
        public static double CubicIn(double t, double from, double to, double duration) {
            return from + (to - from) * Easings.CubicIn(t / duration);
        }

        /// <summary>
        /// Starts faster and then decelerates, creates a bigger curve than <see cref="QuadraticOut"/> that is clearly visible.
        /// </summary>
        /// <param name="t">Time in the value between 0 and duration (inclusive)</param>
        /// <param name="from">Starting value from the ease</param>
        /// <param name="to">Target value to ease</param>
        /// <param name="duration">Duration of the ease</param>
        /// <returns>Eased value</returns>
        public static double CubicOut(double t, double from, double to, double duration) {
            return from + (to - from) * Easings.CubicOut(t / duration);
        }

        /// <summary>
        /// Starts slower and then accelerates and past the middle point it starts to decelerate,
        /// creates a bigger curve than <see cref="QuadraticInOut"/> that is clearly visible.
        /// </summary>
        /// <param name="t">Time in the value between 0 and duration (inclusive)</param>
        /// <param name="from">Starting value from the ease</param>
        /// <param name="to">Target value to ease</param>
        /// <param name="duration">Duration of the ease</param>
        /// <returns>Eased value</returns>
        public static double CubicInOut(double t, double from, double to, double duration) {
            return from + (to - from) * Easings.CubicInOut(t / duration);
        }

        /// <summary>
        /// Starts slower and then accelerates, creates a bigger curve than <see cref="CubicIn"/>.
        /// </summary>
        /// <param name="t">Time in the value between 0 and duration (inclusive)</param>
        /// <param name="from">Starting value from the ease</param>
        /// <param name="to">Target value to ease</param>
        /// <param name="duration">Duration of the ease</param>
        /// <returns>Eased value</returns>
        public static double QuarticIn(double t, double from, double to, double duration) {
            return from + (to - from) * Easings.QuarticIn(t / duration);
        }

        /// <summary>
        /// Starts faster and then decelerates, creates a bigger curve than <see cref="CubicOut"/>.
        /// </summary>
        /// <param name="t">Time in the value between 0 and duration (inclusive)</param>
        /// <param name="from">Starting value from the ease</param>
        /// <param name="to">Target value to ease</param>
        /// <param name="duration">Duration of the ease</param>
        /// <returns>Eased value</returns>
        public static double QuarticOut(double t, double from, double to, double duration) {
            return from + (to - from) * Easings.QuarticOut(t / duration);
        }

        /// <summary>
        /// Starts slower and then accelerates and past the middle point it starts to decelerate,
        /// creates a bigger curve than <see cref="CubicInOut"/>.
        /// </summary>
        /// <param name="t">Time in the value between 0 and duration (inclusive)</param>
        /// <param name="from">Starting value from the ease</param>
        /// <param name="to">Target value to ease</param>
        /// <param name="duration">Duration of the ease</param>
        /// <returns>Eased value</returns>
        public static double QuarticInOut(double t, double from, double to, double duration) {
            return from + (to - from) * Easings.QuarticInOut(t / duration);
        }

        /// <summary>
        /// Starts slower and then accelerates, creates a bigger curve than <see cref="QuarticIn"/>.
        /// </summary>
        /// <param name="t">Time in the value between 0 and duration (inclusive)</param>
        /// <param name="from">Starting value from the ease</param>
        /// <param name="to">Target value to ease</param>
        /// <param name="duration">Duration of the ease</param>
        /// <returns>Eased value</returns>
        public static double QuinticIn(double t, double from, double to, double duration) {
            return from + (to - from) * Easings.QuinticIn(t / duration);
        }

        /// <summary>
        /// Starts faster and then decelerates, creates a bigger curve than <see cref="QuarticOut"/>.
        /// </summary>
        /// <param name="t">Time in the value between 0 and duration (inclusive)</param>
        /// <param name="from">Starting value from the ease</param>
        /// <param name="to">Target value to ease</param>
        /// <param name="duration">Duration of the ease</param>
        /// <returns>Eased value</returns>
        public static double QuinticOut(double t, double from, double to, double duration) {
            return from + (to - from) * Easings.QuinticOut(t / duration);
        }

        /// <summary>
        /// Starts slower and then accelerates and past the middle point it starts to decelerate,
        /// creates a bigger curve than <see cref="QuarticInOut"/>.
        /// </summary>
        /// <param name="t">Time in the value between 0 and duration (inclusive)</param>
        /// <param name="from">Starting value from the ease</param>
        /// <param name="to">Target value to ease</param>
        /// <param name="duration">Duration of the ease</param>
        /// <returns>Eased value</returns>
        public static double QuinticInOut(double t, double from, double to, double duration) {
            return from + (to - from) * Easings.QuinticInOut(t / duration);
        }

        /// <summary>
        /// Starts slower and then accelerates, creates a bigger curve than <see cref="QuinticIn"/>.
        /// </summary>
        /// <param name="t">Time in the value between 0 and duration (inclusive)</param>
        /// <param name="from">Starting value from the ease</param>
        /// <param name="to">Target value to ease</param>
        /// <param name="duration">Duration of the ease</param>
        /// <returns>Eased value</returns>
        public static double ExponentialIn(double t, double from, double to, double duration) {
            return from + (to - from) * Easings.ExponentialIn(t / duration);
        }

        /// <summary>
        /// Starts faster and then decelerates, creates a bigger curve than <see cref="QuinticOut"/>.
        /// </summary>
        /// <param name="t">Time in the value between 0 and duration (inclusive)</param>
        /// <param name="from">Starting value from the ease</param>
        /// <param name="to">Target value to ease</param>
        /// <param name="duration">Duration of the ease</param>
        /// <returns>Eased value</returns>
        public static double ExponentialOut(double t, double from, double to, double duration) {
            return from + (to - from) * Easings.ExponentialOut(t / duration);
        }

        /// <summary>
        /// Starts slower and then accelerates and past the middle point it starts to decelerate,
        /// creates a bigger curve than <see cref="QuinticInOut"/>.
        /// </summary>
        /// <param name="t">Time in the value between 0 and duration (inclusive)</param>
        /// <param name="from">Starting value from the ease</param>
        /// <param name="to">Target value to ease</param>
        /// <param name="duration">Duration of the ease</param>
        /// <returns>Eased value</returns>
        public static double ExponentialInOut(double t, double from, double to, double duration) {
            return from + (to - from) * Easings.ExponentialInOut(t / duration);
        }

        /// <summary>
        /// Starts slower and then starts accelerating fast, creating a very sharp curve that visually is similar to a quarter of a circle.
        /// </summary>
        /// <param name="t">Time in the value between 0 and duration (inclusive)</param>
        /// <param name="from">Starting value from the ease</param>
        /// <param name="to">Target value to ease</param>
        /// <param name="duration">Duration of the ease</param>
        /// <returns>Eased value</returns>
        public static double CircularIn(double t, double from, double to, double duration) {
            return from + (to - from) * Easings.CircularIn(t / duration);
        }

        /// <summary>
        /// Starts super faster and then decelerates quickly, creating a very sharp curve that visually is similar to a quarter of a circle.
        /// </summary>
        /// <param name="t">Time in the value between 0 and duration (inclusive)</param>
        /// <param name="from">Starting value from the ease</param>
        /// <param name="to">Target value to ease</param>
        /// <param name="duration">Duration of the ease</param>
        /// <returns>Eased value</returns>
        public static double CircularOut(double t, double from, double to, double duration) {
            return from + (to - from) * Easings.CircularOut(t / duration);
        }

        /// <summary>
        /// Starts slower and then starts accelerating fast and past the middle point it starts to decelerate fast, creatig a very sharp curve.
        /// creates a bigger curve than <see cref="QuinticInOut"/>.
        /// </summary>
        /// <param name="t">Time in the value between 0 and duration (inclusive)</param>
        /// <param name="from">Starting value from the ease</param>
        /// <param name="to">Target value to ease</param>
        /// <param name="duration">Duration of the ease</param>
        /// <returns>Eased value</returns>
        public static double CircularInOut(double t, double from, double to, double duration) {
            return from + (to - from) * Easings.CircularInOut(t / duration);
        }

        /// <summary>
        /// Starts with a backwards swing and then accelerates.
        /// </summary>
        /// <param name="t">Time in the value between 0 and duration (inclusive)</param>
        /// <param name="from">Starting value from the ease</param>
        /// <param name="to">Target value to ease</param>
        /// <param name="duration">Duration of the ease</param>
        /// <returns>Eased value</returns>
        public static double BackIn(double t, double from, double to, double duration) {
            return from + (to - from) * Easings.BackIn(t / duration);
        }

        /// <summary>
        /// Starts fast and then ends with a swing past the end point.
        /// </summary>
        /// <param name="t">Time in the value between 0 and duration (inclusive)</param>
        /// <param name="from">Starting value from the ease</param>
        /// <param name="to">Target value to ease</param>
        /// <param name="duration">Duration of the ease</param>
        /// <returns>Eased value</returns>
        public static double BackOut(double t, double from, double to, double duration) {
            return from + (to - from) * Easings.BackOut(t / duration);
        }

        /// <summary>
        /// Starts with a backwards swing and ends with a swing past the end point.
        /// </summary>
        /// <param name="t">Time in the value between 0 and duration (inclusive)</param>
        /// <param name="from">Starting value from the ease</param>
        /// <param name="to">Target value to ease</param>
        /// <param name="duration">Duration of the ease</param>
        /// <returns>Eased value</returns>
        public static double BackInOut(double t, double from, double to, double duration) {
            return from + (to - from) * Easings.BackInOut(t / duration);
        }

        /// <summary>
        /// Starts swinging back and forth and then very quickly runs to the endpoint.
        /// </summary>
        /// <param name="t">Time in the value between 0 and duration (inclusive)</param>
        /// <param name="from">Starting value from the ease</param>
        /// <param name="to">Target value to ease</param>
        /// <param name="duration">Duration of the ease</param>
        /// <returns>Eased value</returns>
        public static double ElasticIn(double t, double from, double to, double duration) {
            return from + (to - from) * Easings.ElasticIn(t / duration);
        }

        /// <summary>
        /// Gets to the end point very quickly and swings to the place like a spring.
        /// </summary>
        /// <param name="t">Time in the value between 0 and duration (inclusive)</param>
        /// <param name="from">Starting value from the ease</param>
        /// <param name="to">Target value to ease</param>
        /// <param name="duration">Duration of the ease</param>
        /// <returns>Eased value</returns>
        public static double ElasticOut(double t, double from, double to, double duration) {
            return from + (to - from) * Easings.ElasticOut(t / duration);
        }

        /// <summary>
        /// Starts with multiple swings back and forth and ends with multiple swings back and forth with really fast
        /// transition through the middle.
        /// </summary>
        /// <param name="t">Time in the value between 0 and duration (inclusive)</param>
        /// <param name="from">Starting value from the ease</param>
        /// <param name="to">Target value to ease</param>
        /// <param name="duration">Duration of the ease</param>
        /// <returns>Eased value</returns>
        public static double ElasticInOut(double t, double from, double to, double duration) {
            return from + (to - from) * Easings.ElasticInOut(t / duration);
        }

        /// <summary>
        /// Performs a set of 4 bounces where the midpoint of the fourth is the fial position.
        /// </summary>
        /// <param name="t">Time in the value between 0 and duration (inclusive)</param>
        /// <param name="from">Starting value from the ease</param>
        /// <param name="to">Target value to ease</param>
        /// <param name="duration">Duration of the ease</param>
        /// <returns>Eased value</returns>
        public static double BounceOut(double t, double from, double to, double duration) {
            return from + (to - from) * Easings.BounceOut(t / duration);
        }

        /// <summary>
        /// Starts from the midpoint of a bounce and then does 3 more bounces that get progressively weaker.
        /// </summary>
        /// <param name="t">Time in the value between 0 and duration (inclusive)</param>
        /// <param name="from">Starting value from the ease</param>
        /// <param name="to">Target value to ease</param>
        /// <param name="duration">Duration of the ease</param>
        /// <returns>Eased value</returns>
        public static double BounceIn(double t, double from, double to, double duration) {
            return from + (to - from) * Easings.BounceIn(t / duration);
        }

        /// <summary>
        /// Starts with a set of 4 bounces where the midpoint of the fourth one is in the midpoint of the ease
        /// and then continues as if starting from a middle of a bounce then does 3 more bounces that get progressively weaker.
        /// </summary>
        /// <param name="t">Time in the value between 0 and duration (inclusive)</param>
        /// <param name="from">Starting value from the ease</param>
        /// <param name="to">Target value to ease</param>
        /// <param name="duration">Duration of the ease</param>
        /// <returns>Eased value</returns>
        public static double BounceInOut(double t, double from, double to, double duration) {
            return from + (to - from) * Easings.BounceInOut(t / duration);
        }

        /// <summary>
        /// Dynamicly accelerates until the middle point and then decelerates.
        /// </summary>
        /// <param name="t">Time in the value between 0 and duration (inclusive)</param>
        /// <param name="from">Starting value from the ease</param>
        /// <param name="to">Target value to ease</param>
        /// <param name="duration">Duration of the ease</param>
        /// <returns>Eased value</returns>
        public static double PerlinInOut(double t, double from, double to, double duration) {
            return from + (to - from) * Easings.PerlinInOut(t / duration);
        }
    }
}
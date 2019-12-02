using System;

namespace Samples.ReadOnlyMembers
{
    public struct Point
    {
        public double X { get; set; }

        public double Y { get; set; }

        public readonly double Distance => Math.Sqrt(this.X * this.X + this.Y * this.Y);

        public override readonly string ToString()
        {
            return $"({this.X}, {this.Y}) is {this.Distance} from the origin";
        }
    }
}
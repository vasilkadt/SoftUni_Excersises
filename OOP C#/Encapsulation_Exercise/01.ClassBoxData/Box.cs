using System;
using System.Collections.Generic;
using System.Text;

namespace _01.ClassBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;
        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }
        public double Length
        {
            get { return length; }
            private set
            {
                if (value > 0)
                    length = value;
                else throw new ArgumentException($"{nameof(this.Length)} cannot be zero or negative.");
            }
        }
        public double Width
        {
            get { return width; }
            private set
            {
                if (value > 0)
                    width = value;
                else throw new ArgumentException($"{nameof(this.Width)} cannot be zero or negative.");
            }
        }
        public double Height
        {
            get { return height; }
            private set
            {
                if (value > 0)
                    height = value;
                else throw new ArgumentException($"{nameof(this.Height)} cannot be zero or negative.");
            }
        }

        public double SurfaceArea()
           => (2 * Length * Width) + (2 * Length * Height) + (2 * Width * Height);
        public double LateralSurfaceArea()
            => (2 * Length * Height) + (2 * Width * Height);
        public double Volume()
            => Length * Width * Height;
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Surface Area - {SurfaceArea():f2}");
            sb.AppendLine($"Lateral Surface Area - {LateralSurfaceArea():f2}");
            sb.AppendLine($"Volume - {Volume():f2}");
            return sb.ToString().TrimEnd();
        }
    }
}

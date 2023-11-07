using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _01.ClassBoxData.Models
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
            get => length;
            private set
            {
                //PropertyInfo length = typeof(Box).GetProperty(nameof(this.Length)); -> length.Name

                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Length)} cannot be zero or negative.");
                }

                length = value;
            }
        }

        public double Width
        {
            get => width;
            private set
            {
                //PropertyInfo width = typeof(Box).GetProperty(nameof(this.Width)); -> width.Name

                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Width)} cannot be zero or negative.");
                }

                width = value;
            }
        }

        public double Height
        {
            get => height;
            private set
            {
                //PropertyInfo height = typeof(Box).GetProperty(nameof(this.Height)); -> height.Name

                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Height)} cannot be zero or negative.");
                }

                height = value;
            }
        }

        public double SurfaceArea()
        {
            return 2 * (Length * Width + Length * Height + Width * Height); // Surface Area -> 2lw + 2lh + 2wh
        }

        public double LateralSurfaceArea()
        {
            return 2 * (Length * Height + Width * Height); // Lateral Surface Area -> 2lh + 2wh
        }

        public double Volume()
        {
            return Length * Width * Height; // Volume -> l * w * h
        }
    }
}
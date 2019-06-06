using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Sphere
    {
        private int radius;

        public Sphere()
        { }
        public Sphere(int radius)
        {
            if (radius < 0)
            {
                radius = 0;
            }
            this.radius = radius;
        }
        public void SetRadius(int radius)
        {
            if (radius < 0)
            {
                radius = 0;
            }
            this.radius = radius;
        }
        public int GetRadius()
        {
            return this.radius;
        }
        public double CalculateVolume()
        {
            double volume;

            //volume = this.radius * this.radius;
            volume = 4 * Math.PI * Math.Pow(this.radius, 3) / 3;

            return volume;
        }
    }
}

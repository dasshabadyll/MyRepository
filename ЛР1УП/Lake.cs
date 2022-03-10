using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    class Lake
    {
        public string Name;
        public double Area;
        public double Length;
        public void SetName(string Name)
        {
            this.Name = Name;
        }
        public void SetArea(double Area)
        {
            this.Area = Area;
        }
        public void SetLength(double Length)
        {
            this.Length = Length;
        }
        public string GetName()
        {
            return this.Name;
        }
        public double GetArea()
        {
            return this.Area;
        }
        public double GetLength()
        {
            return this.Length;
        }
        public Lake(string Name, double Area, double Length)
        {
            this.Name = Name;
            this.Area = Area;
            this.Length = Length;
        }
        public Lake()
        { }
    }
}

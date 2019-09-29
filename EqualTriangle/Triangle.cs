using System;

namespace EqualTriangle
{
    class Triangle
    {
        Points point1;
        Points point2;
        Points point3;
        
        public Triangle(Points point1,Points point2,Points point3)
        {
            this.point1 = point1;
            this.point2 = point2;
            this.point3 = point3;
        }
       
        public override bool Equals(object obj)
        {
            double epsilon = 1E-10;
            if (obj is Triangle)
            {
                Triangle triangle = (Triangle)obj;
                double firstSideOfTheFirstTriangle = Math.Sqrt(Math.Pow(this.point2.x - this.point1.x, 2) + Math.Pow(this.point2.y - this.point1.y, 2));
                double secondSideOfTheFistTriangle = Math.Sqrt(Math.Pow(this.point3.x - this.point2.x, 2) + Math.Pow(this.point3.y - this.point2.y, 2));
                double thirdSideOfTheFirstTriangle = Math.Sqrt(Math.Pow(this.point3.x - this.point1.x, 2) + Math.Pow(this.point3.y - this.point1.y, 2));
                double firstSideOfTheSecondTriangle = Math.Sqrt(Math.Pow(triangle.point2.x - triangle.point1.x, 2) + Math.Pow(triangle.point2.y - triangle.point1.y, 2));
                double secondSideOfTheSecondTriangle = Math.Sqrt(Math.Pow(triangle.point3.x - triangle.point2.x, 2) + Math.Pow(triangle.point3.y - triangle.point2.y, 2));
                double thirdSideOfTheSecondTriangle = Math.Sqrt(Math.Pow(triangle.point3.x - triangle.point1.x, 2) + Math.Pow(triangle.point3.y - triangle.point1.y, 2));
                Console.WriteLine($"The first triangle: sides = {firstSideOfTheFirstTriangle}; {secondSideOfTheFistTriangle}; {thirdSideOfTheFirstTriangle}");
                Console.WriteLine($"The second triangle: sides = {firstSideOfTheSecondTriangle}; {secondSideOfTheSecondTriangle}; {thirdSideOfTheSecondTriangle}");
                Console.WriteLine();
                return (Math.Abs(firstSideOfTheFirstTriangle - firstSideOfTheSecondTriangle) < epsilon && Math.Abs(secondSideOfTheFistTriangle - secondSideOfTheSecondTriangle) < epsilon && Math.Abs(thirdSideOfTheFirstTriangle - thirdSideOfTheSecondTriangle) < epsilon);
            }
            else
                return false;
        }
    }
}

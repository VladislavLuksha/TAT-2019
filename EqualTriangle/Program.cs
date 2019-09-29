using System;

namespace EqualTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int amouthOfPoints = 15;
            int amouthOfTriangle = 5;
            Random random = new Random();
            Points[] points = new Points[amouthOfPoints];
            points[0] = new Points(2, 2);
            points[1] = new Points(4, 6);
            points[2] = new Points(6, 6);
            points[3] = new Points(2, 2);
            points[4] = new Points(4, 6);
            points[5] = new Points(6, 6);
            for(int i = 6; i < amouthOfPoints; i++)
            {
                points[i] = new Points(random.Next(1, 10), random.Next(1, 10));
            }
            Triangle[] triangles = new Triangle[amouthOfTriangle];
            int triangleCounter = 0;
            for (int i = 0; i < amouthOfPoints; i++)
            {
                if(triangleCounter < amouthOfTriangle)
                {
                    triangles[triangleCounter] = new Triangle(points[i], points[i + 1], points[i + 2]);
                    triangleCounter ++;
                    i += 2;
                }
            }
            bool trianglesComparison;
            triangleCounter = 1;
            int numberOfIdeticalTriangles = 2;
            int counterOfTriangle = 0;
            for (int j = 0; j < amouthOfTriangle; j++)
            {   
                for (int i = triangleCounter; i < amouthOfTriangle; i++)
                {
                    trianglesComparison = triangles[j].Equals(triangles[i]);
                    if (trianglesComparison == true)
                    {
                        counterOfTriangle += numberOfIdeticalTriangles;
                    }
                }
                triangleCounter ++;
            }
            if(counterOfTriangle >= 2)
            {
                trianglesComparison = true;
            }
            else
            {
                trianglesComparison = false;
            }
            Console.WriteLine(trianglesComparison);
        }
    }
}

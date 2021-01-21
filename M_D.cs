using System;
using System.Numerics;

namespace Midpoint_And_Distance
{
    // Graham Joonsar
    class M_D
    {

        static void Main(String[] args)
        {
            // For the midpoint between two 2D points 
            Vector2 Midpoint2D(Vector2 pointOne, Vector2 pointTwo)
            {
                return (pointOne + pointTwo) / 2;
            }
            // Example
            Console.WriteLine("Midpoint 2D: " + Midpoint2D(new Vector2(1f, 1f), new Vector2(1f, 2f)));
            
            // For the distance between two 2D points
            double Distance2D(Vector2 pointOne, Vector2 pointTwo)
            {
                return Math.Sqrt(Math.Pow(pointOne.X - pointTwo.X, 2) + Math.Pow(pointOne.Y - pointTwo.Y, 2));
            }
            // Example
            Console.WriteLine("Distance 2D: " + Distance2D(new Vector2(1f, 1f), new Vector2(1f, 2f)));

            // For the midpoint between two 3D points 
            Vector3 Midpoint3D(Vector3 pointOne, Vector3 pointTwo)
            {
                return (pointOne + pointTwo) / 2;
            }
            // Example
            Console.WriteLine("Midpoint 3D: " + Midpoint3D(new Vector3(1f, 1f, 1f), new Vector3(1f, 2f, 4f)));

            // For the distance between two 3D points
            double Distance3D(Vector3 pointOne, Vector3 pointTwo)
            {
                return Math.Sqrt(Math.Pow(pointOne.X - pointTwo.X, 2) + Math.Pow(pointOne.Y - pointTwo.Y, 2) + Math.Pow(pointOne.Z - pointTwo.Z, 2));
            }
            // Example
            Console.WriteLine("Distance 3D: " + Distance3D(new Vector3(1f, 1f, 1f), new Vector3(1f, 2f, 1f)));
        }

    }
}

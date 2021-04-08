using System;

namespace _785A_Anton_and_Polyhedrons
{
    class Program
    {
        static void Main(string[] args)
        {
            int n =Convert.ToInt32(Console.ReadLine());
            int faces = 0;

            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();

                if (s == "Tetrahedron")
                {
                    faces += 4;
                }
                else if (s == "Cube")
                {
                    faces += 6;
                }
                else if (s == "Octahedron")
                {
                    faces += 8;
                }
                else if (s == "Dodecahedron")
                {
                    faces += 12;
                }
                else if (s == "Icosahedron")
                {
                    faces += 20;
                }
            }
            Console.WriteLine(faces);
        }
    }
}

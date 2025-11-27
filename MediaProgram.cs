using System;

namespace SWE201_235060006
{
    class MediaProgram
    {
        static void Main(string[] args)
        {
            // Empty constructor
            Media m1 = new Media();
            m1.Title = "Breaking Bad";
            m1.Type = "Dizi";
            m1.ReleaseYear = 2008;

            // Parameterized constructor
            Media m2 = new Media("Inception", "Film", 2010);
            Media m3 = new Media("Dark", "Dizi", 2017);
            Media m4 = new Media("Interstellar", "Film", 2014);

            Console.WriteLine(m1.GetDetails());
            Console.WriteLine(m2.GetDetails());
            Console.WriteLine(m3.GetDetails());
            Console.WriteLine(m4.GetDetails());

            // ToString example
            Console.WriteLine(m4.ToString());
        }
    }
}


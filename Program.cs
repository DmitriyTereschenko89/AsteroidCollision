// See https://aka.ms/new-console-template for more information
using AsteroidCollision;

CollisionAsteroid asteroidCollision = new();
Console.WriteLine(string.Join(", ", asteroidCollision.AsteroidCollision(new int[] { 5, 10, -5 })));
Console.WriteLine(string.Join(", ", asteroidCollision.AsteroidCollision(new int[] { 8, -8 })));
Console.WriteLine(string.Join(", ", asteroidCollision.AsteroidCollision(new int[] { 10, 2, -5 })));
Console.WriteLine(string.Join(", ", asteroidCollision.AsteroidCollision(new int[] { -2, -2, 1, -2 })));
Console.WriteLine(string.Join(", ", asteroidCollision.AsteroidCollision(new int[] { -2, -1, 1, 2 })));
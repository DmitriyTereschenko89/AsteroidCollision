namespace AsteroidCollision
{
	internal class CollisionAsteroid
	{
		public int[] AsteroidCollision(int[] asteroids)
		{
			Stack stack = new();
			foreach(int asteroid in asteroids)
			{
				bool isAddAsteroid = true;
				while(stack.Count() > 0 && (stack.Peek() > 0 && asteroid < 0))
				{
					if (stack.Peek() < Math.Abs(asteroid))
					{
						stack.Pop();
						continue;
					}
					if (stack.Peek() == Math.Abs(asteroid))
					{
						stack.Pop();
					}
					isAddAsteroid = false;
					break;
				}
				if (isAddAsteroid)
				{
					stack.Push(asteroid);
				}
			}
			int[] asteroidCollision = new int[stack.Count()];
			int index = stack.Count() - 1;
			while(stack.Count() > 0)
			{
				asteroidCollision[index--] = stack.Pop();
			}
			return asteroidCollision;
		}
	}
}

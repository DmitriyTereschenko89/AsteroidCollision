namespace AsteroidCollision
{
	internal class StackNode
	{
		public int value;
		public StackNode next;

		public StackNode(int value, StackNode next = null)
		{
			this.value = value;
			this.next = next;
		}
	}
}

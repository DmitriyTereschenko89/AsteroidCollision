namespace AsteroidCollision
{
	internal class Stack
	{
		private StackNode head;
		private int count;

		public void Push(int value)
		{
			++count;
			if (head is null)
			{
				head = new StackNode(value);
				return;
			}
			StackNode newNode = new(value, head);
			head = newNode;
		}

		public int Pop()
		{
			--count;
			int removedValue = head.value;
			head = head.next;
			return removedValue;
		}

		public int Peek()
		{
			return head.value;
		}

		public int Count()
		{
			return count;
		}
	}
}

using System;
using System.Threading;

namespace Lock
{
	class Program
	{
		// Creating a reference type object
		static readonly object obj = new object();
		static void Sample()
		{

			// lock statement block
			lock (obj)
			{

				// Sleeping the thread
				System.Threading.Thread.Sleep(20);

				// Printing the count
				Console.WriteLine(Environment.TickCount);
			}
		}
		static public void Main()
		{
			// Iterating using a for-loop
			for (int i = 0; i < 5; i++)
			{
				// Creating a new thread
				ThreadStart begin = new ThreadStart(Sample);
				// Executing the thread
				new Thread(begin).Start();
			}
		}
	}
}
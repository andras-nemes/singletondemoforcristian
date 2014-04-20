using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SingletonMVC.SingletonExample
{
	public class ThreadSafeSingleton
	{
		private ThreadSafeSingleton()
		{
		}

		public Guid Guid { get; set; }

		public static ThreadSafeSingleton Instance
		{
			get { return Nested.instance; }
		}

		private class Nested
		{
			static Nested()
			{
			}

			internal static readonly ThreadSafeSingleton instance = new ThreadSafeSingleton() { Guid = Guid.NewGuid() };
		}
	}
}
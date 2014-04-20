using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SingletonMVC.SingletonExample
{
	public class DemoService
	{
		public ThreadSafeSingleton GetThreadSafeSingleton()
		{
			return ThreadSafeSingleton.Instance;
		}
	}
}
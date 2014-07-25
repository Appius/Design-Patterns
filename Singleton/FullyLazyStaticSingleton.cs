// Version 5: Fully lazy instantiation
using System;

namespace FullyLazyStaticSingleton {
	public class Singleton {
		private Singleton() {}
		public static Singleton Instance {
			get {
				return InstanceSingleton.Instance;
			}
		}

		private static class InstanceSingleton {
			static InstanceSingleton(){}
			public static Singleton Instance = new Singleton();
		}
	}
}
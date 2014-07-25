// Version 4: Not quite as lazy, but thread-safe without using locks
using System;

namespace NotQuiteLazyStaticSingleton {
	public class Singleton {
		private Singleton() {}
		static Singleton(){}
		private static Singleton _instance = new Singleton();

		public static Singleton Instance {
			get {
				return _instance;
			}
		}
	}
}
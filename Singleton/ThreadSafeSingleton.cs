// Version 2: Simple thread-safety
using System;

namespace ThreadSafeSingleton {
	public class Singleton {
		private Singleton() {}
		private static Singleton _instance;
		private static object obj = new object();

		public static Singleton Instance {
			get {
				lock (obj) {
					if (_instance==null) {
						_instance = new Singleton();
					}
					return _instance;
				}
			}
		}
	}
}
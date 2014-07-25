// Version 3: Attempted thread-safety using double-check locking
using System;

namespace ThreadSafeDoubleCheckSingleton {
	public class Singleton {
		private Singleton() {}
		private static Singleton _instance;
		private static object obj = new object();

		public static Singleton Instance {
			get {
				if (_instance==null) {
					lock (obj) {
						if (_instance==null) {
							_instance = new Singleton();
						}
					}
				}
				return _instance;
			}
		}
	}
}
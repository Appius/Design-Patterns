// Version 1: Not thread-safe
using System;

namespace NotThreadSafeSingleton {
	public class Singleton {
		private Singleton() {}
		private static Singleton _instance;

		public static Singleton Instance {
			get {
				if (_instance==null) {
					_instance = new Singleton();
				}
				return _instance;
			}
		}
	}
}
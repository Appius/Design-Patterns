// Version 6: Using .NET 4's Lazy<T> type
using System;

namespace FullyLazySingleton {
	public class Singleton {
		static Singleton() {}
		private Singleton() {}
		private static Lazy<Singleton> _instance = new Lazy<Singleton>(() => new Singleton());
		
		public static Singleton Instance {
			get {
				return _instance.Value;
			}
		}
	}
}
using System;

namespace AbstractFactory {
	public class ProductB1: IProductB {
		public ProductB1() {
			System.Console.WriteLine("Creation Product B1");
		}
	}
}
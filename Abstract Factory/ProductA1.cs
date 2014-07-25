using System;

namespace AbstractFactory {
	public class ProductA1: IProductA {
		public ProductA1() {
			System.Console.WriteLine("Creation Product A1");
		}
	}
}
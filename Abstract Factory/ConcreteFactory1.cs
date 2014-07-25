using System;

namespace AbstractFactory {
	class ConcreteFactory1: IAbstractFactory {
		public IProductA CreateProductA() {
			System.Console.WriteLine("Product A from ConcreteFactory 1");
			return new ProductA1();
		}

		public IProductB CreateProductB() {
			System.Console.WriteLine("Product B from ConcreteFactory 1");
			return new ProductB1();
		}
	}
}
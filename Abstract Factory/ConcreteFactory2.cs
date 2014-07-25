using System;

namespace AbstractFactory {
	class ConcreteFactory2: IAbstractFactory {
		public IProductA CreateProductA() {
			System.Console.WriteLine("Product A from ConcreteFactory 2");
			return new ProductA2();
		}

		public IProductB CreateProductB() {
			System.Console.WriteLine("Product B from ConcreteFactory 2");
			return new ProductB2();
		}
	}
}
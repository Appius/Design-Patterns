using System;
using AbstractFactory;

namespace AbstractFactoryRun {
	internal class Program {
		public static void Main() {
			IAbstractFactory factory = new ConcreteFactory1();
			factory.CreateProductA();
			factory.CreateProductB();

			factory = new ConcreteFactory2();
			factory.CreateProductA();
			factory.CreateProductB();

			return;
		}
	}
}
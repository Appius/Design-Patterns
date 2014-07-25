using System;

namespace AbstractFactory {
	interface IAbstractFactory {
		IProductA CreateProductA();
		IProductB CreateProductB();
	}
}
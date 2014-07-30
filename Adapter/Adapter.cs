using System;

namespace Adapter {
	internal class Adapter: ITarget {
		private Adaptee adaptee = null;

		public Adapter() {
			adaptee = new Adaptee();
		}

		public void DoSomething() {
			adaptee.DoSpecificWork();
		}
	}
}
using System;

namespace FactoryMethod {
	internal class WindowsPhone: Phone {
		public WindowsPhone(string name, Battery battery, ScreenType screenType, Stylus stylus): base(name, battery, screenType, stylus) {
			_os = OperationSystem.WINDOWS_PHONE;
		}
	}
}
using System;

namespace FactoryMethod {
	internal class AndroidPhone: Phone {
		public AndroidPhone(string name, Battery battery, ScreenType screenType, Stylus stylus): base(name, battery, screenType, stylus) {
			_os = OperationSystem.ANDROID;
		}
	}
}
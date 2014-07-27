using System;

namespace FactoryMethod {
	internal static class PhoneFactory {
		public static Phone CreatePhone (string name, OperationSystem os, Battery battery, ScreenType screenType, Stylus stylus) {
			switch (os) {
				case OperationSystem.ANDROID:
					return new AndroidPhone(name, battery, screenType, stylus);
				case OperationSystem.WINDOWS_PHONE:
					return new WindowsPhone(name, battery, screenType, stylus);
				default:
					return new Phone(name, battery, os, screenType, stylus);
			}
		}
	}
}
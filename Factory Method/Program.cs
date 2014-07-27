using System;
using FactoryMethod;

namespace FactoryMethodRun {
	internal class Program {
		public static void Main() {
			Phone phone = null;

			phone = PhoneFactory.CreatePhone("Nexus 1", OperationSystem.ANDROID, Battery.MAH_2000, ScreenType.TOUCH_CAPACITIVE, Stylus.YES);
			System.Console.WriteLine(phone.ToString());

			phone = PhoneFactory.CreatePhone("Lumia 3", OperationSystem.WINDOWS_PHONE, Battery.MAH_1500, ScreenType.TOUCH_RESISTIVE, Stylus.YES);
			System.Console.WriteLine(phone.ToString());

			phone = PhoneFactory.CreatePhone("Redhotchiken 5", OperationSystem.SYMBIAN, Battery.MAH_1000, ScreenType.TOUCH_RESISTIVE, Stylus.NO);
			System.Console.WriteLine(phone.ToString());

			return;
		}
	}
}
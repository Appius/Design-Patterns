using System;

namespace Builder {
	internal class WindowsMobilePhoneBuilder: IPhoneBuilder {
		public WindowsMobilePhoneBuilder() {
			_phone = new Phone ("Windows Phone");
		}
		
		Phone _phone;

		public Phone Phone {
			get {
				return _phone;
			}
		}

		public void BuildScreen() {
			_phone.Screen = ScreenType.TOUCH_CAPACITIVE;
		}

		public void BuildOs() {
			_phone.Os = OperationSystem.WINDOWS_MOBILE;
		}

		public void BuildStylus() {
			_phone.Stylus = Stylus.YES;
		}

		public void BuildBattery() {
			_phone.Battery = Battery.MAH_1500;
		}
	}
}
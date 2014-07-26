using System;

namespace Builder {
	internal class AndroidPhoneBuilder: IPhoneBuilder {
		public AndroidPhoneBuilder() {
			_phone = new Phone ("Andoid Phone");
		}
		
		Phone _phone;

		public Phone Phone {
			get {
				return _phone;
			}
		}

		public void BuildScreen() {
			_phone.Screen = ScreenType.TOUCH_RESISTIVE;
		}

		public void BuildOs() {
			_phone.Os = OperationSystem.ANDROID;
		}

		public void BuildStylus() {
			_phone.Stylus = Stylus.YES;
		}

		public void BuildBattery() {
			_phone.Battery = Battery.MAH_2000;
		}
	}
}
using System;

namespace Prototype {
	internal class WindowsPhone: Phone {
		
		public WindowsPhone() {
			Os = OperationSystem.WINDOWS_PHONE;
		}

		public WindowsPhone(string name, Battery battery, ScreenType screenType, Stylus stylus): this() {
			Name = name;
			Battery = battery;
			ScreenType = screenType;
			Stylus = stylus;
		}

		private object ShallowCopy() {
			return this.MemberwiseClone();
		}

		private object DeepCopy() {
			Phone cloned = this.MemberwiseClone() as WindowsPhone;
			cloned.Details = new AdditionalDetails();
			cloned.Details.Color = Details.Color;
			cloned.Details.Thickness = Details.Thickness;
			return cloned;
		}

		public override object Clone() {
			return ShallowCopy();
		}
	}
}
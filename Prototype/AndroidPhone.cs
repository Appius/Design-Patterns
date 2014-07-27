using System;

namespace Prototype {
	internal class AndroidPhone: Phone {
		
		public AndroidPhone() {
			Os = OperationSystem.ANDROID;
		}

		public AndroidPhone(string name, Battery battery, ScreenType screenType, Stylus stylus): this() {
			Name = name;
			Battery = battery;
			ScreenType = screenType;
			Stylus = stylus;
		}

		private object ShallowCopy() {
			return this.MemberwiseClone();
		}

		private object DeepCopy() {
			Phone cloned = this.MemberwiseClone() as AndroidPhone;
			cloned.Details = new AdditionalDetails();
			cloned.Details.Color = Details.Color;
			cloned.Details.Thickness = Details.Thickness;
			return cloned;
		}

		public override object Clone() {
			return DeepCopy();
		}
	}
}
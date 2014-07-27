using System;

namespace FactoryMethod {
	internal class Phone {
		protected Phone(string name, Battery battery, ScreenType screenType, Stylus stylus) {
			_name = name;
			_battery = battery;
			_screenType = screenType;
			_stylus = stylus;
		}

		public Phone(string name, Battery battery, OperationSystem os, ScreenType screenType, Stylus stylus): this(name, battery, screenType, stylus) {
			_os = os;
		}

		private string _name;
		private Battery _battery;
		private ScreenType _screenType;
		private Stylus _stylus;
		protected OperationSystem _os;
		
		public override string ToString() {
			return string.Format("This phone has:{0} - Name: {1},{0} - Battery: {2},{0} - OperationSystem: {3},{0} - ScreenType: {4},{0} - Stylus: {5}{0}[DEBUG INFO] GetType(): `{6}`{0}",
				Environment.NewLine, _name, _battery, _os, _screenType, _stylus, this.GetType().Name);
		}
	}
}
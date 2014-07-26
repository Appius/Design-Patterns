using System;

namespace Builder {
	internal interface IPhoneBuilder {
		void BuildScreen();
		void BuildOs();
		void BuildStylus();
		void BuildBattery();

		Phone Phone { get; }
	}
}
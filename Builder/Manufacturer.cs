namespace Builder {
	internal class Manufacturer {
		public void Construct(IPhoneBuilder builder) {
			builder.BuildOs();
			builder.BuildBattery();
			builder.BuildScreen();
			builder.BuildStylus();
		}
	}
}
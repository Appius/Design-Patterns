using System;
using Builder;

namespace BuilderRun {
	internal class Program {
		public static void Main() {
			Manufacturer manufacturer = new Manufacturer();
			IPhoneBuilder phoneBuilder = null;

			// Building WindowsPhone
			phoneBuilder = new WindowsMobilePhoneBuilder();
			manufacturer.Construct(phoneBuilder);
			Console.WriteLine("A new phone is:{0}{1}{0}", Environment.NewLine, phoneBuilder.Phone.ToString());

			// Building Android Phone
			phoneBuilder = new AndroidPhoneBuilder();
			manufacturer.Construct(phoneBuilder);
			Console.WriteLine("A new phone is:{0}{1}{0}",  Environment.NewLine, phoneBuilder.Phone.ToString());
		}
	}
}
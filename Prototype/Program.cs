using System;
using Prototype;

namespace PrototypeRun {
	internal class Program {
		public static void Main() {
			Phone phone = new WindowsPhone("Lumia xxx", Battery.MAH_2000, ScreenType.TOUCH_CAPACITIVE, Stylus.YES);
			System.Console.WriteLine (phone.ToString());

			Phone clonedPhone = phone.Clone() as WindowsPhone;
			phone.Details.Color = Color.WHITE;
			phone.Details.Thickness = 10;

			System.Console.WriteLine (phone.ToString());
			System.Console.WriteLine (clonedPhone.ToString());
		}
	}
}
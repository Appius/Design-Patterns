using Bridge;
using System;

namespace BridgeRun {
	internal class Program {
		public static void Main() {
			SmartTV tv = new SmartTV(new LocalCabelTV());
			tv.PlayVideo();
			tv.GetTVGuide();

			System.Console.WriteLine();
			tv.SetSource(new LocalDishTV());
			tv.PlayVideo();
			tv.GetTVGuide();

			return;
		}
	}
}
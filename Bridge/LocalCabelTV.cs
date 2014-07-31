using System;

namespace Bridge {
	internal class LocalCabelTV: IVideoSource {
		public void PlayVideo() {
			System.Console.WriteLine("Playing video from {0}", this.GetType().Name);
		}

		public void GetTVGuide() {
			System.Console.WriteLine("This is TV guid from {0}", this.GetType().Name);
		}
	}
}
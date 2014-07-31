namespace Bridge {
	internal class SmartTV {
		private IVideoSource _videoSource = null;

		public SmartTV() {}

		public SmartTV(IVideoSource source) {
			_videoSource = source;
		}

		public void SetSource(IVideoSource source) {
			_videoSource = source;
		}

		public void PlayVideo() {
			_videoSource.PlayVideo();
		}

		public void GetTVGuide() {
			_videoSource.GetTVGuide();
		}
	}
}
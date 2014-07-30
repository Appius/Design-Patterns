using Adapter;

namespace AdapterRun {
	internal static class Program {
		public static void Main() {
			ITarget target = new Adapter.Adapter();

			target.DoSomething();
		}
	}
}
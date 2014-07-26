using System;

namespace Builder {
	internal class Phone {
		public Phone(string name) {
			_name = name;
		}

		private string _name;
		
		public string Name { 
			get {
				return _name;
			}
		}

		public ScreenType Screen { set; get; }
		public Battery Battery  { set; get; }
		public OperationSystem Os  { set; get; }
		public Stylus Stylus  { set; get; }

		public override string ToString () {
			return string.Format("Name: {0},{1}Screen: {2},{1}Battery: {3},{1}Os: {4},{1}Stylus: {5}",
				_name, Environment.NewLine, Screen, Battery, Os, Stylus);
		}
	}
}
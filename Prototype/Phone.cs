using System;

namespace Prototype {
	internal abstract class Phone: ICloneable {
		public string Name { protected set; get; }
		public Battery Battery { protected set; get; }
		public ScreenType ScreenType {protected set; get; }
		public Stylus Stylus { protected set; get; }
		public OperationSystem Os { protected set; get; }

		private AdditionalDetails _addDetails = new AdditionalDetails();
		public AdditionalDetails Details {
			get {
				return _addDetails;
			}
			set {
				_addDetails = value;
			}
		}

		public override string ToString() {
			return string.Format("This phone has:{0} - Name: {1},{0} - Battery: {2},{0} - OperationSystem: {3},{0} - ScreenType: {4},{0} - Stylus: {5},{0} - AdditionalDetails:{0}   - Color: {6},{0}   - Thickness: {7}mm{0}[DEBUG INFO] GetType(): `{8}`{0}",
				Environment.NewLine, Name, Battery, Os, ScreenType, Stylus, Details.Color, Details.Thickness, this.GetType().Name);
		}

		public abstract object Clone();
	}
}
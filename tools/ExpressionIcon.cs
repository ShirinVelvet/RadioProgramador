using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace RadioProgramador.tools {
	
	public class ExpressionIcon {

		private static Element incidentTriangle = new Element("\xE814", (SolidColorBrush) new BrushConverter().ConvertFrom("#faff62"));
		private static Element exclamation = new Element("\xE783", (SolidColorBrush) new BrushConverter().ConvertFrom("#ffffff"));
		private static Element completed = new Element("\xE930", (SolidColorBrush) new BrushConverter().ConvertFrom("#80ff67"));
		private static Element info = new Element("\xE946", (SolidColorBrush) new BrushConverter().ConvertFrom("#5093ff"));
		private static Element question = new Element("\xE9CE", (SolidColorBrush) new BrushConverter().ConvertFrom("#5093ff"));
		private static Element error = new Element("\xEA39", (SolidColorBrush) new BrushConverter().ConvertFrom("#ff5e5e"));

		public static Element IncidentTriangle { get => incidentTriangle; }
		public static Element Exclamation { get => exclamation; }
		public static Element Completed { get => completed; }
		public static Element Info { get => info; }
		public static Element Question { get => question; }
		public static Element Error { get => error; }

		public class Element {

			private string icon;
			private SolidColorBrush color;

			public Element(string icon, SolidColorBrush color) {
				this.icon = icon;
				this.color = color;
			}

			public SolidColorBrush Color { get => color; }
			public string Icon { get => icon; }
		}

	}
}

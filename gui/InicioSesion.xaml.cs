using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RadioProgramador.gui {
	/// <summary>
	/// Interaction logic for InicioSesion.xaml
	/// </summary>
	public partial class InicioSesion : Window {

		public InicioSesion() {
			InitializeComponent();
		}

		private void Cerrar_click(object sender, RoutedEventArgs e) {
			Application.Current.Shutdown();
		}

		private void Minimizar_click(object sender, RoutedEventArgs e) {
			WindowState = WindowState.Minimized;
		}

		private void Ventana_mover(object sender, MouseButtonEventArgs e) {
			if (e.ChangedButton == MouseButton.Left) {
				DragMove();
			}
		}
	}
}

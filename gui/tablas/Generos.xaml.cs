using RadioProgramador.gui.formularios;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RadioProgramador.gui.tablas {
	/// <summary>
	/// Interaction logic for Generos.xaml
	/// </summary>
	public partial class Generos : Page {
		public Generos() {
			InitializeComponent();
		}

		private void Agregar_click(object sender, RoutedEventArgs e) {
			((MainWindow)App.Current.MainWindow).frame_panel2.Content = new GeneroForm();
		}
	}
}

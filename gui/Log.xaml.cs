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

namespace RadioProgramador.gui {
	/// <summary>
	/// Interaction logic for Log.xaml
	/// </summary>
	public partial class Log : Page {
		public Log() {
			InitializeComponent();
		}

		private void Minimizar_click(object sender, RoutedEventArgs e) {
			((MainWindow)App.Current.MainWindow).frame_log.Visibility = Visibility.Collapsed;
		}

		private void Anclar_click(object sender, RoutedEventArgs e) {
			if (((MainWindow)App.Current.MainWindow).logPinned) {
				((MainWindow)App.Current.MainWindow).logPinned = false;
				button_anclar.Content = "\xE718";
			} else {
				((MainWindow)App.Current.MainWindow).logPinned = true;
				button_anclar.Content = "\xE840";
			}
		}
	}
}
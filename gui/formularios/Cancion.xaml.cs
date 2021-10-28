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

namespace RadioProgramador.gui.formularios {
	/// <summary>
	/// Interaction logic for Cancion.xaml
	/// </summary>
	public partial class Cancion : Page {

		private int prioridad;

		public Cancion() {
			InitializeComponent();
			prioridad = 1;
		}

		private void Prioridad_menos(object sender, RoutedEventArgs e) {
			if (prioridad > 0) {
				prioridad--;
				tb_prioridad.Text = prioridad.ToString();
			}
		}

		private void Prioridad_mas(object sender, RoutedEventArgs e) {
			prioridad++;
			tb_prioridad.Text = prioridad.ToString();
		}
	}
}

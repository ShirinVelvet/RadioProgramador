using RadioProgramador.gui.formularios;
using RadioProgramador.model.dao;
using RadioProgramador.model.poco;
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

		private List<Genero> generos = new List<Genero>();

		public Generos() {
			InitializeComponent();
			CargarGeneros();
		}

		private void CargarGeneros() {
			generos = GeneroDAO.GetAll();
			dg_generos.ItemsSource = generos;
		}

		private void Agregar_click(object sender, RoutedEventArgs e) {
			((MainWindow)App.Current.MainWindow).frame_panel2.Content = new GeneroForm();
		}

		private void Buscar_textChanged(object sender, TextChangedEventArgs e) {
			List<Genero> generosFiltrados = (from genero in generos
											   where genero.Nombre.ToLower().Contains(tb_buscar.Text.ToLower())
											   select genero).ToList();
			dg_generos.ItemsSource = generosFiltrados;
		}

		private void Tabla_seleccion(object sender, SelectionChangedEventArgs e) {
			Genero genero = (Genero)dg_generos.SelectedItem;
			if (genero != null) {
				((MainWindow)App.Current.MainWindow).frame_panel2.Content = new GeneroForm(genero);
			}
		}

		public void ActualizarTabla() {
			CargarGeneros();
			string texto = tb_buscar.Text;
			tb_buscar.Text = "";
			tb_buscar.Text = texto;
		}
	}
}

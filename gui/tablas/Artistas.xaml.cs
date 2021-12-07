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
	/// Interaction logic for Artistas.xaml
	/// </summary>
	public partial class Artistas : Page {

		private List<Artista> artistas = new List<Artista>();

		public Artistas() {
			InitializeComponent();
			CargarArtistas();
		}

		private void CargarArtistas() {
			artistas = ArtistaDAO.GetAll();
			dg_artistas.ItemsSource = artistas;
		}

		private void Agregar_click(object sender, RoutedEventArgs e) {
			((MainWindow)App.Current.MainWindow).frame_panel2.Content = new ArtistaForm();
		}

		private void Buscar_textChanged(object sender, TextChangedEventArgs e) {
			List<Artista> artistasFiltrados = (from artista in artistas
													where artista.Nombre.ToLower().Contains(tb_buscar.Text.ToLower())
													select artista).ToList();
			dg_artistas.ItemsSource = artistasFiltrados;
		}

		private void Tabla_seleccion(object sender, SelectionChangedEventArgs e) {
			Artista artista = (Artista) dg_artistas.SelectedItem;
			if (artista != null) {
				((MainWindow)App.Current.MainWindow).frame_panel2.Content = new ArtistaForm(artista);
			}
		}

		public void ActualizarTabla() {
			CargarArtistas();
			string texto = tb_buscar.Text;
			tb_buscar.Text = "";
			tb_buscar.Text = texto;
		}
	}
}

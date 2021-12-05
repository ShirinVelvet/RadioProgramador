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
	/// Interaction logic for Canciones.xaml
	/// </summary>
	public partial class Canciones : Page {

		private List<Cancion> canciones = new List<Cancion>();
		private List<Cancion> cancionesFiltradas = new List<Cancion>();

		public Canciones() {
			InitializeComponent();
			CargarCombo();
			CargarCanciones();
		}

		private void CargarCanciones() {
			canciones = CancionDAO.GetAll();
			dg_canciones.ItemsSource = canciones;
		}

		private void CargarCombo() {
			List<string> filtros = new List<string>();
			filtros.Add("Todo");
			filtros.Add("Cancion");
			filtros.Add("Artista");
			filtros.Add("Genero");
			filtros.Add("Categoria");
			combo_filtro.ItemsSource = filtros;
			combo_filtro.SelectedIndex = 0;
		}

		private void Agregar_click(object sender, RoutedEventArgs e) {
			((MainWindow)App.Current.MainWindow).frame_panel2.Content = new CancionForm();
		}

		private async void Buscar_textChanged(object sender, TextChangedEventArgs e) {
			await Task.Delay(300); // Atrasa el if, si no da lag al escribir en el textbox de búsqueda
			if (combo_filtro.SelectedIndex == 0) {
				BuscarTodo();
			} else if (combo_filtro.SelectedIndex == 1) {
				BuscarCancion();
			} else if (combo_filtro.SelectedIndex == 2) {
				BuscarArtista();
			} else if (combo_filtro.SelectedIndex == 3) {
				BuscarGenero();
			} else if (combo_filtro.SelectedIndex == 4) {
				BuscarCategoria();
			}
		}

		private void BuscarTodo() {
			cancionesFiltradas = (from cancion in canciones
								  where cancion.Titulo.ToLower().Contains(tb_buscar.Text.ToLower())
								  || cancion.Artista.ToLower().Contains(tb_buscar.Text.ToLower())
								  || cancion.Genero.ToLower().Contains(tb_buscar.Text.ToLower())
								  || cancion.Categoria.ToLower().Contains(tb_buscar.Text.ToLower())
								  select cancion).ToList();
			dg_canciones.ItemsSource = cancionesFiltradas;
		}

		private void BuscarCancion() {
			cancionesFiltradas = (from cancion in canciones
								  where cancion.Titulo.ToLower().Contains(tb_buscar.Text.ToLower())
								  select cancion).ToList();
			dg_canciones.ItemsSource = cancionesFiltradas;
		}

		private void BuscarArtista() {
			cancionesFiltradas = (from cancion in canciones
								  where cancion.Artista.ToLower().Contains(tb_buscar.Text.ToLower())
								  select cancion).ToList();
			dg_canciones.ItemsSource = cancionesFiltradas;
		}

		private void BuscarGenero() {
			cancionesFiltradas = (from cancion in canciones
								  where cancion.Genero.ToLower().Contains(tb_buscar.Text.ToLower())
								  select cancion).ToList();
			dg_canciones.ItemsSource = cancionesFiltradas;
		}

		private void BuscarCategoria() {
			cancionesFiltradas = (from cancion in canciones
								  where cancion.Categoria.ToLower().Contains(tb_buscar.Text.ToLower())
								  select cancion).ToList();
			dg_canciones.ItemsSource = cancionesFiltradas;
		}

		private void Filtro_selectionChanged(object sender, SelectionChangedEventArgs e) {
			if (combo_filtro.SelectedIndex == 0) {
				BuscarTodo();
			} else if (combo_filtro.SelectedIndex == 1) {
				BuscarCancion();
			} else if (combo_filtro.SelectedIndex == 2) {
				BuscarArtista();
			} else if (combo_filtro.SelectedIndex == 3) {
				BuscarGenero();
			} else if (combo_filtro.SelectedIndex == 4) {
				BuscarCategoria();
			}
		}
	}
}

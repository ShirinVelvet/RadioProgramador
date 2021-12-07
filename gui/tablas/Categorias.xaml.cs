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
	/// Interaction logic for Categorias.xaml
	/// </summary>
	public partial class Categorias : Page {

		private List<Categoria> categorias = new List<Categoria>();

		public Categorias() {
			InitializeComponent();
			CargarCategorias();
		}

		private void CargarCategorias() {
			categorias = CategoriaDAO.GetAll();
			dg_categorias.ItemsSource = categorias;
		}

		private void Agregar_click(object sender, RoutedEventArgs e) {
			((MainWindow)App.Current.MainWindow).frame_panel2.Content = new CategoriaForm();
		}

		private void Buscar_textChanged(object sender, TextChangedEventArgs e) {
			List<Categoria> categoriasFiltrados = (from categoria in categorias
											   where categoria.Nombre.ToLower().Contains(tb_buscar.Text.ToLower())
											   select categoria).ToList();
			dg_categorias.ItemsSource = categoriasFiltrados;
		}

		private void Tabla_seleccion(object sender, SelectionChangedEventArgs e) {
			Categoria categoria = (Categoria)dg_categorias.SelectedItem;
			if (categoria != null) {
				((MainWindow)App.Current.MainWindow).frame_panel2.Content = new CategoriaForm(categoria);
			}
		}

		public void ActualizarTabla() {
			CargarCategorias();
			string texto = tb_buscar.Text;
			tb_buscar.Text = "";
			tb_buscar.Text = texto;
		}
	}
}

using RadioProgramador.gui.tablas;
using RadioProgramador.model.dao;
using RadioProgramador.model.poco;
using RadioProgramador.tools;
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
	/// Interaction logic for Categoria.xaml
	/// </summary>
	public partial class CategoriaForm : Page {

		private bool editando;
		private Categoria categoria;

		public CategoriaForm() {
			InitializeComponent();
		}

		public CategoriaForm(Categoria categoria) : this() {
			this.categoria = categoria;
			label_titulo.Content = categoria.Nombre;
			editando = true;
			CargarCategoria();
			CambiarEstado();
		}

		private void CargarCategoria() {
			tb_nombre.Text = categoria.Nombre;
		}

		private void Editar_click(object sender, RoutedEventArgs e) {
			CambiarEstado();
		}

		private void Guardar_click(object sender, RoutedEventArgs e) {

			if (CamposVacios()) {
				PopupMessage.ShowAndWait("Campos vacios", "Rellena todos los campos", 2);
				return;
			}

			if (editando) {
				Modificar();
			} else {
				Guardar();
			}

			label_titulo.Content = tb_nombre.Text;

			Categorias categorias = (Categorias)((MainWindow)App.Current.MainWindow).frame_panel1.Content;
			categorias.ActualizarTabla();

		}

		private void Cerrar_click(object sender, RoutedEventArgs e) {
			((MainWindow)App.Current.MainWindow).frame_panel2.Content = null;
		}

		private void Guardar() {
			Categoria categoria = CrearCategoria();
			bool guardado = CategoriaDAO.GuardarCategoria(categoria);
			if (guardado) {
				CambiarEstado();
			} else {
				PopupMessage.ShowAndWait("Error", "No se pudo guardar", 3);
			}
		}

		private void Modificar() {
			ModificarCategoria();
			bool guardado = CategoriaDAO.ModificarCategoria(categoria);
			if (guardado) {
				CambiarEstado();
			} else {
				PopupMessage.ShowAndWait("Error", "No se pudo guardar", 3);
			}
		}

		//***************************************//
		//                                       //
		//     **** Métodos auxiliares ****      //
		//                                       //
		//***************************************//

		private bool CamposVacios() {
			bool camposVacios = false;
			if (tb_nombre.Text.Length < 1) {
				camposVacios = true;
			}
			return camposVacios;
		}

		private Categoria CrearCategoria() {
			string nombre = tb_nombre.Text;
			Categoria categoria = new Categoria(0, nombre);
			return categoria;
		}

		private void ModificarCategoria() {
			string nombre = tb_nombre.Text;
			categoria.Nombre = nombre;
		}

		private void CambiarEstado() {
			if (editando) {
				editando = false;
				button_guardar.IsEnabled = false;
				button_editar.IsEnabled = true;
				tb_nombre.IsReadOnly = true;
			} else {
				editando = true;
				button_guardar.IsEnabled = true;
				button_editar.IsEnabled = false;
				tb_nombre.IsReadOnly = false;
			}
		}
	}
}

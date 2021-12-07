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
	/// Interaction logic for Artista.xaml
	/// </summary>
	public partial class ArtistaForm : Page {

		private bool editando;
		private Artista artista;

		public ArtistaForm() {
			InitializeComponent();
			editando = false;
		}

		public ArtistaForm(Artista artista) : this() {
			this.artista = artista;
			editando = true;
			CargarArtista();
			CambiarEstado();
		}

		private void CargarArtista() {
			tb_nombre.Text = artista.Nombre;
			label_titulo.Content = artista.Nombre;
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

			label_titulo.Content = artista.Nombre;

			Artistas artistas = (Artistas) ((MainWindow)App.Current.MainWindow).frame_panel1.Content;
			artistas.ActualizarTabla();

		}

		private void Cerrar_click(object sender, RoutedEventArgs e) {
			((MainWindow)App.Current.MainWindow).frame_panel2.Content = null;
		}

		private void Guardar() {
			Artista artista = CrearArtista();
			bool guardado = ArtistaDAO.GuardarArtista(artista);
			if (guardado) {
				CambiarEstado();
			} else {
				PopupMessage.ShowAndWait("Error", "No se pudo guardar", 3);
			}
		}

		private void Modificar() {
			ModificarArtista();
			bool guardado = ArtistaDAO.ModificarArtista(artista);
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

		private Artista CrearArtista() {
			string nombre = tb_nombre.Text;
			Artista artista = new Artista(0, nombre);
			return artista;
		}

		private void ModificarArtista() {
			string nombre = tb_nombre.Text;
			artista.Nombre = nombre;
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

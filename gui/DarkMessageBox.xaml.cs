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
using System.Windows.Shapes;

namespace RadioProgramador.gui {
	/// <summary>
	/// Iconos: 0=Nada, 1=Info, 2=Exclamacion, 3=Error, 4=TrianguloExclamacion, 5=Interrogacion, 6=Completado
	/// Botones: 0=Nada, 1=Aceptar, 2=Cancelar, 3=Sí, 4=No
	/// ShowAndWait regresa true para Aceptar y Sí, y false para Cancelar y No
	/// Si no se especifican botones, se agrega por defecto Aceptar
	/// </summary>
	public partial class DarkMessageBox : Window {

		private static bool respuesta;

		public DarkMessageBox() {
			InitializeComponent();
		}

		public DarkMessageBox(string titulo, string contenido, int icono, int boton1, int boton2, int boton3) : this() {
			tb_titulo.Text = titulo;
			tb_contenido.Text = contenido;
			SeleccionarIcono(icono);
			MostrarBoton(boton1);
			MostrarBoton(boton2);
			MostrarBoton(boton3);
			if (SinBotones()) {
				button_aceptar.Visibility = Visibility.Visible;
			}
		}

		public static bool ShowAndWait(string titulo, string contenido, int icono = 0, int boton1 = 0, int boton2 = 0, int boton3 = 0) {
			DarkMessageBox darkMessageBox = new DarkMessageBox(titulo, contenido, icono, boton1, boton2, boton3);
			darkMessageBox.ShowDialog();
			return respuesta;
		}

		private void Ventana_mover(object sender, MouseButtonEventArgs e) {
			if (e.ChangedButton == MouseButton.Left) {
				this.DragMove();
			}
		}

		private void Aceptar(object sender, RoutedEventArgs e) {
			respuesta = true;
			Close();
		}

		private void Cancelar(object sender, RoutedEventArgs e) {
			respuesta = false;
			Close();
		}

		private void SeleccionarIcono(int icono) {
			switch (icono) {
				case 1:
					label_icono.Content = ExpressionIcon.Info.Icon;
					label_icono.Foreground = ExpressionIcon.Info.Color;
					break;
				case 2:
					label_icono.Content = ExpressionIcon.Exclamation.Icon;
					label_icono.Foreground = ExpressionIcon.Exclamation.Color;
					break;
				case 3:
					label_icono.Content = ExpressionIcon.Error.Icon;
					label_icono.Foreground = ExpressionIcon.Error.Color;
					break;
				case 4:
					label_icono.Content = ExpressionIcon.IncidentTriangle.Icon;
					label_icono.Foreground = ExpressionIcon.IncidentTriangle.Color;
					break;
				case 5:
					label_icono.Content = ExpressionIcon.Question.Icon;
					label_icono.Foreground = ExpressionIcon.Question.Color;
					break;
				case 6:
					label_icono.Content = ExpressionIcon.Completed.Icon;
					label_icono.Foreground = ExpressionIcon.Completed.Color;
					break;
				default:
					label_icono.Content = "";
					break;
			}
		}

		private void MostrarBoton(int boton) {
			switch (boton) {
				case 1:
					button_aceptar.Visibility = Visibility.Visible;
					break;
				case 2:
					button_cancelar.Visibility = Visibility.Visible;
					break;
				case 3:
					button_si.Visibility = Visibility.Visible;
					break;
				case 4:
					button_no.Visibility = Visibility.Visible;
					break;
				default:
					break;
			}
		}

		private bool SinBotones() {
			if (button_aceptar.IsVisible || button_cancelar.IsVisible || button_si.IsVisible || button_no.IsVisible) {
				respuesta = false;
			}
			return true;
		}
	}
}

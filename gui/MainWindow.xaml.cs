using RadioProgramador.gui.programacion;
using RadioProgramador.gui.tablas;
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
using System.Windows.Shell;

namespace RadioProgramador.gui {
	/// <summary>
	/// Ventana principal donde se mostrará todo el contenido
	/// Dividido en tres partes:
	///		Fila 0: Barra de titulo
	///		Fila 1: Contenido
	///		Fila 2: Barra de estado
	///	El contenido se divide en dos partes:
	///		Columna 0: Menu
	///		Columna 1: Contenido principal
	/// </summary>
	public partial class MainWindow : Window {

		// Para redimensionar ventana
		private bool windowMaximized;
		private int restoreHeight;
		private int restoreWidth;
		private int restoreTop;
		private int restoreLeft;

		private bool menuContraido;
		public bool logPinned;

		public MainWindow() {
			InitializeComponent();
			ConfiguracionInicial();
		}

		private void ConfiguracionInicial() {
			windowMaximized = true;
			restoreHeight = 680;
			restoreWidth = 1000;
			menuContraido = false;
			logPinned = false;
			frame_panel3.Content = new Calendario();
			frame_panel4.Content = new Grafica();
		}

		//***************************************//
		//                                       //
		//           **** Pruebas ****           //
		//                                       //
		//***************************************//

		private void Messagebox_click(object sender, RoutedEventArgs e) {
			string contenido = "Este es el contenido";
			bool respuesta = PopupMessage.ShowAndWait("Este es el título", contenido, 6, 1, 2);
			Console.WriteLine("Respuesta: " + respuesta);
			Log log = (Log) frame_log.Content;
			log.tb_sql.Text += "Se abrió PopupMessage\n";
			log.tb_sql.Text += $"Respuesta: {respuesta}\n";
		}

		//***************************************//
		//                                       //
		//  **** Selección de Menú lateral ****  //
		//                                       //
		//***************************************//

		private void Menu_seleccion(object sender, RoutedEventArgs e) {
			RadioButton radioButton = (RadioButton) sender;
			if (radioButton == rb_canciones) {
				frame_panel1.Content = new Canciones();
			} else if (radioButton == rb_artistas) {
				frame_panel1.Content = new Artistas();
			} else if (radioButton == rb_generos) {
				frame_panel1.Content = new Generos();
			} else if (radioButton == rb_categorias) {
				frame_panel1.Content = new Categorias();
			} else if (radioButton == rb_programas) {
				frame_panel1.Content = new Programas();
			} else if (radioButton == rb_patrones) {
				frame_panel1.Content = new Patrones();
			} else if (radioButton == rb_reportes) {

			} else if (radioButton == rb_config) {

			}
		}

		//***************************************//
		//                                       //
		//       **** Barra de titulo ****       //
		//                                       //
		//***************************************//

		private void Cerrar_click(object sender, RoutedEventArgs e) {
			Application.Current.Shutdown();
		}

		private void Minimizar_click(object sender, RoutedEventArgs e) {
			WindowState = WindowState.Minimized;
		}

		private void Restaurar_click(object sender, RoutedEventArgs e) {
			AjustarVentana();
		}

		//***************************************//
		//                                       //
		//  **** Ajustar tamaño de ventana ****  //
		//                                       //
		//***************************************//

		private void AjustarVentana() {
			if (windowMaximized) {
				button_restaurar.Content = "\xE922";
				windowMaximized = false;
				WindowState = WindowState.Normal;
				ResizeMode = ResizeMode.CanResize;
				Height = restoreHeight;
				Width = restoreWidth;
				Top = restoreTop;
				Left = restoreLeft;
				chrome.ResizeBorderThickness = SystemParameters.WindowResizeBorderThickness;
			} else {
				button_restaurar.Content = "\xE923";
				windowMaximized = true;
				WindowState = WindowState.Normal;
				GetRestoreSize();
				Height = SystemParameters.WorkArea.Height;
				Width = SystemParameters.WorkArea.Width;
				Top = 0;
				Left = 0;
				ResizeMode = ResizeMode.NoResize;
				chrome.ResizeBorderThickness = new System.Windows.Thickness(0);
			}
		}

		private void GetRestoreSize() {
			restoreHeight = (int) Height;
			restoreWidth = (int) Width;
			restoreTop = (int) Top;
			restoreLeft = (int) Left;
		}

		private void Ventana_mover(object sender, MouseButtonEventArgs e) {
			if (e.ChangedButton == MouseButton.Left) {
				if (e.ClickCount == 2) {
					AjustarVentana();
				} else {
					if (!windowMaximized) {
						DragMove();
					}
				}
			}
		}

		private void Ventana_cambioEstado(object sender, EventArgs e) {
			if (WindowState == WindowState.Maximized) {
				AjustarVentana();
			}
		}

		//***************************************//
		//                                       //
		//  **** Visibilidad de Menú y log ****  //
		//                                       //
		//***************************************//

		private void ContraerMenu_click(object sender, RoutedEventArgs e) {
			if (menuContraido == true) {
				ExpandirMenu();
				menuContraido = false;
			} else {
				ContraerMenu();
				menuContraido = true;
			}
		}

		private void ContraerMenu() {
			label_menu.Visibility = Visibility.Collapsed;
			label_canciones.Visibility = Visibility.Collapsed;
			label_artistas.Visibility = Visibility.Collapsed;
			label_generos.Visibility = Visibility.Collapsed;
			label_categorias.Visibility = Visibility.Collapsed;
			label_programas.Visibility = Visibility.Collapsed;
			label_patrones.Visibility = Visibility.Collapsed;
			label_reportes.Visibility = Visibility.Collapsed;
			label_config.Visibility = Visibility.Collapsed;
		}

		private void ExpandirMenu() {
			label_menu.Visibility = Visibility.Visible;
			label_canciones.Visibility = Visibility.Visible;
			label_artistas.Visibility = Visibility.Visible;
			label_generos.Visibility = Visibility.Visible;
			label_categorias.Visibility = Visibility.Visible;
			label_programas.Visibility = Visibility.Visible;
			label_patrones.Visibility = Visibility.Visible;
			label_reportes.Visibility = Visibility.Visible;
			label_config.Visibility = Visibility.Visible;
		}

		private void Log_click(object sender, RoutedEventArgs e) {
			if (frame_log.Visibility == Visibility.Collapsed) {
				frame_log.Visibility = Visibility.Visible;
			} else {
				frame_log.Visibility = Visibility.Collapsed;
			}
		}

		private void Log_clickAfuera(object sender, MouseButtonEventArgs e) {
			if (!logPinned && !frame_log.IsMouseOver) {
				frame_log.Visibility = Visibility.Collapsed;
			}
		}

	}
}

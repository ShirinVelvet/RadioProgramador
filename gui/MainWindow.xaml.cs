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
			InicializarVentana();
		}

		private void InicializarVentana() {
			windowMaximized = true;
			restoreHeight = 600;
			restoreWidth = 800;
			menuContraido = false;
			logPinned = false;
			PruebaComboTabla();
		}

		///////////////////////////////////
		//            Pruebas            //
		///////////////////////////////////

		private void Messagebox_click(object sender, RoutedEventArgs e) {
			string contenido = "Este es el contenido";
			bool respuesta = PopupMessage.ShowAndWait("Este es el título", contenido,6, 1, 2);
			Console.WriteLine("Respuesta: " + respuesta);
			Log log = (Log) frame_log.Content;
			log.tb_sql.Text += "Se abrió PopupMessage\n";
			log.tb_sql.Text += $"Respuesta: {respuesta}\n";
		}

		private void PruebaComboTabla() {
			List<string> listaCombo = new List<string>();
			List<ClasePrueba> listaTabla = new List<ClasePrueba>();
			listaCombo.Add("Oh sí");
			listaCombo.Add("Oh no");
			listaCombo.Add("Oh cielos");
			combo_prueba.ItemsSource = listaCombo;
			listaTabla.Add(new ClasePrueba("Elemento1", 1));
			listaTabla.Add(new ClasePrueba("Elemento2", 2));
			listaTabla.Add(new ClasePrueba("Elemento3", 3));
			table_prueba.ItemsSource = listaTabla;
			columnaCombo.ItemsSource = ClasePrueba.ListaOpciones;
		}

		///////////////////////////////////
		//        Barra de titulo        //
		///////////////////////////////////

		private void Cerrar_click(object sender, RoutedEventArgs e) {
			Application.Current.Shutdown();
		}

		private void Minimizar_click(object sender, RoutedEventArgs e) {
			WindowState = WindowState.Minimized;
		}

		private void Restaurar_click(object sender, RoutedEventArgs e) {
			AjustarVentana();
		}

		///////////////////////////////////
		//   Ajustar tamaño de ventana   //
		///////////////////////////////////

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

		///////////////////////////////////
		//           Menú y log          //
		///////////////////////////////////

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

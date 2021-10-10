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
		private int maxHeight;
		private int maxWidth;
		private int restoreHeight;
		private int restoreWidth;
		private int restoreTop;
		private int restoreLeft;

		public MainWindow() {
			InitializeComponent();
			InicializarVentana();
		}

		private void InicializarVentana() {
			this.windowMaximized = true;
			this.restoreHeight = 600;
			this.restoreWidth = 800;
		}

		private void VentanaCargada(object sender, RoutedEventArgs e) {
			GetMaxSize();
		}

		///////////////////////////////////
		//        Barra de titulo        //
		///////////////////////////////////

		private void Cerrar_click(object sender, RoutedEventArgs e) {
			Application.Current.Shutdown();
		}

		private void Minimizar_click(object sender, RoutedEventArgs e) {
			this.WindowState = WindowState.Minimized;
		}

		private void Restaurar_click(object sender, RoutedEventArgs e) {
			AjustarVentata();
		}

		///////////////////////////////////
		//   Ajustar tamaño de ventana   //
		///////////////////////////////////

		private void AjustarVentata() {
			if (this.windowMaximized) {
				this.windowMaximized = false;
				this.ResizeMode = ResizeMode.CanResize;
				this.Height = restoreHeight;
				this.Width = restoreWidth;
				this.Top = restoreTop;
				this.Left = restoreLeft;
			} else {
				this.windowMaximized = true;
				GetRestoreSize();
				this.Height = maxHeight;
				this.Width = maxWidth;
				this.Top = 0;
				this.Left = 0;
				this.ResizeMode = ResizeMode.NoResize;
			}
		}

		private void GetMaxSize() {
			this.maxHeight = (int) this.Height;
			this.maxWidth = (int) this.Width;
		}

		private void GetRestoreSize() {
			this.restoreHeight = (int) this.Height;
			this.restoreWidth = (int) this.Width;
			this.restoreTop = (int) this.Top;
			this.restoreLeft = (int) this.Left;
		}

		private void Ventana_mover(object sender, MouseButtonEventArgs e) {
			if (e.ChangedButton == MouseButton.Left) {
				if (e.ClickCount == 2) {
					AjustarVentata();
				} else {
					if (!windowMaximized) {
						this.DragMove();
					}
				}
			}
		}
	}
}

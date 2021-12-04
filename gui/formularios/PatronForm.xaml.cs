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
	/// Interaction logic for Patron.xaml
	/// </summary>
	public partial class PatronForm : Page {
		public PatronForm() {
			InitializeComponent();
			List<string> lista = new List<string>();
			lista.Add("Oh no");
			lista.Add("Oh sí");
			lista.Add("Oh cielos");
			dg_elementos.ItemsSource = lista;
		}
	}
}

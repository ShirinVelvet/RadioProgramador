﻿using System;
using System.Collections.Generic;
using System.Globalization;
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
using System.Windows.Threading;

namespace RadioProgramador.gui.programacion {
	/// <summary>
	/// Interaction logic for Calendario.xaml
	/// </summary>
	public partial class Calendario : Page {

		public Calendario() {
			InitializeComponent();
			ConfigurarHora();
		}

		private void ConfigurarHora() {
			DispatcherTimer hora = new DispatcherTimer();
			hora.Interval = TimeSpan.FromSeconds(1);
			hora.Tick += TimerTick;
			hora.Start();
		}

		private void TimerTick(object sender, EventArgs e) {
			label_fechaHora.Content = DateTime.Now.ToString("HH:mm:ss   dd'/'MM'/'yyyy");
		}

	}
}

﻿#pragma checksum "..\..\..\gui\DarkMessageBox.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "53EB4676BAAEA6ACF9D8B1B3FB074F099FF78A409C1CD4EAED663D9CA36EF2C2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using RadioProgramador.gui;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace RadioProgramador.gui {
    
    
    /// <summary>
    /// DarkMessageBox
    /// </summary>
    public partial class DarkMessageBox : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\gui\DarkMessageBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tb_titulo;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\gui\DarkMessageBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label_icono;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\gui\DarkMessageBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tb_contenido;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\gui\DarkMessageBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel dock_botones;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\gui\DarkMessageBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_no;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\gui\DarkMessageBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_si;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\gui\DarkMessageBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_cancelar;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\gui\DarkMessageBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_aceptar;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/RadioProgramador;component/gui/darkmessagebox.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\gui\DarkMessageBox.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 18 "..\..\..\gui\DarkMessageBox.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Ventana_mover);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tb_titulo = ((System.Windows.Controls.TextBlock)(target));
            
            #line 19 "..\..\..\gui\DarkMessageBox.xaml"
            this.tb_titulo.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Ventana_mover);
            
            #line default
            #line hidden
            return;
            case 3:
            this.label_icono = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.tb_contenido = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.dock_botones = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 6:
            this.button_no = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\gui\DarkMessageBox.xaml"
            this.button_no.Click += new System.Windows.RoutedEventHandler(this.Cancelar);
            
            #line default
            #line hidden
            return;
            case 7:
            this.button_si = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\gui\DarkMessageBox.xaml"
            this.button_si.Click += new System.Windows.RoutedEventHandler(this.Aceptar);
            
            #line default
            #line hidden
            return;
            case 8:
            this.button_cancelar = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\gui\DarkMessageBox.xaml"
            this.button_cancelar.Click += new System.Windows.RoutedEventHandler(this.Cancelar);
            
            #line default
            #line hidden
            return;
            case 9:
            this.button_aceptar = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\gui\DarkMessageBox.xaml"
            this.button_aceptar.Click += new System.Windows.RoutedEventHandler(this.Aceptar);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


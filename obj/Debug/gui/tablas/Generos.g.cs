#pragma checksum "..\..\..\..\gui\tablas\Generos.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0358F1BB012B22E864FCD46B38163C86F50076612683B2BD72ED91B73D36D80D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using RadioProgramador.gui.tablas;
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


namespace RadioProgramador.gui.tablas {
    
    
    /// <summary>
    /// Generos
    /// </summary>
    public partial class Generos : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\..\gui\tablas\Generos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_buscar;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\gui\tablas\Generos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dg_generos;
        
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
            System.Uri resourceLocater = new System.Uri("/RadioProgramador;component/gui/tablas/generos.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\gui\tablas\Generos.xaml"
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
            this.tb_buscar = ((System.Windows.Controls.TextBox)(target));
            
            #line 26 "..\..\..\..\gui\tablas\Generos.xaml"
            this.tb_buscar.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Buscar_textChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 28 "..\..\..\..\gui\tablas\Generos.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Agregar_click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.dg_generos = ((System.Windows.Controls.DataGrid)(target));
            
            #line 30 "..\..\..\..\gui\tablas\Generos.xaml"
            this.dg_generos.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Tabla_seleccion);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


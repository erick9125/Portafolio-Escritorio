﻿#pragma checksum "..\..\..\Views\NuevoMedioPago.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1E401AEBCBDA34C7E600CF8F74BC5B5358E39F56B777390EB887753DEE6BE62A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using Portafolio_Escritorio.Views;
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


namespace Portafolio_Escritorio.Views {
    
    
    /// <summary>
    /// NuevoMedioPago
    /// </summary>
    public partial class NuevoMedioPago : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\Views\NuevoMedioPago.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dg_medio_pago;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Views\NuevoMedioPago.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_nuevo_mediop;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Views\NuevoMedioPago.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_id_mediop;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Views\NuevoMedioPago.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_registrar_pago;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Views\NuevoMedioPago.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_actualizar_pago;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Views\NuevoMedioPago.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_edit_mediop;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Views\NuevoMedioPago.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_eliminar_mediop;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Views\NuevoMedioPago.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_volver_mediop;
        
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
            System.Uri resourceLocater = new System.Uri("/Portafolio-Escritorio;component/views/nuevomediopago.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\NuevoMedioPago.xaml"
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
            this.dg_medio_pago = ((System.Windows.Controls.DataGrid)(target));
            
            #line 16 "..\..\..\Views\NuevoMedioPago.xaml"
            this.dg_medio_pago.Loaded += new System.Windows.RoutedEventHandler(this.dg_medio_pago_Loaded);
            
            #line default
            #line hidden
            
            #line 16 "..\..\..\Views\NuevoMedioPago.xaml"
            this.dg_medio_pago.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dg_medio_pago_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txt_nuevo_mediop = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txt_id_mediop = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.btn_registrar_pago = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\Views\NuevoMedioPago.xaml"
            this.btn_registrar_pago.Click += new System.Windows.RoutedEventHandler(this.btn_registrar_pago_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btn_actualizar_pago = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\Views\NuevoMedioPago.xaml"
            this.btn_actualizar_pago.Click += new System.Windows.RoutedEventHandler(this.btn_actualizar_pago_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btn_edit_mediop = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\Views\NuevoMedioPago.xaml"
            this.btn_edit_mediop.Click += new System.Windows.RoutedEventHandler(this.btn_edit_mediop_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btn_eliminar_mediop = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\Views\NuevoMedioPago.xaml"
            this.btn_eliminar_mediop.Click += new System.Windows.RoutedEventHandler(this.btn_eliminar_mediop_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btn_volver_mediop = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\Views\NuevoMedioPago.xaml"
            this.btn_volver_mediop.Click += new System.Windows.RoutedEventHandler(this.btn_volver_mediop_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


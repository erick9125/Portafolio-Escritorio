﻿#pragma checksum "..\..\..\Views\UserControlEstadoDeuda.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "45BB88BFE2B693CF5EC375F3F980C73A0A36B7430FA4A60BA99B9C8BA775DB55"
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
    /// UserControlEstadoDeuda
    /// </summary>
    public partial class UserControlEstadoDeuda : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\Views\UserControlEstadoDeuda.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_buscar_deuda;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Views\UserControlEstadoDeuda.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_buscar_deuda;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Views\UserControlEstadoDeuda.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgv_buscar_deuda;
        
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
            System.Uri resourceLocater = new System.Uri("/Portafolio-Escritorio;component/views/usercontrolestadodeuda.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\UserControlEstadoDeuda.xaml"
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
            this.txt_buscar_deuda = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.btn_buscar_deuda = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\Views\UserControlEstadoDeuda.xaml"
            this.btn_buscar_deuda.Click += new System.Windows.RoutedEventHandler(this.btn_buscar_deuda_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.dgv_buscar_deuda = ((System.Windows.Controls.DataGrid)(target));
            
            #line 17 "..\..\..\Views\UserControlEstadoDeuda.xaml"
            this.dgv_buscar_deuda.Loaded += new System.Windows.RoutedEventHandler(this.dgv_buscar_deuda_Loaded);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


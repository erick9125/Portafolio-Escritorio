﻿#pragma checksum "..\..\..\Views\UserControlReporteDeudas.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CDB1655992DE464E4FA8FBF43CE6316DF1EE1EA14749EE71A8DA9ACD26021EFB"
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
    /// UserControlReporteDeudas
    /// </summary>
    public partial class UserControlReporteDeudas : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\Views\UserControlReporteDeudas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgv_reporte_deuda;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Views\UserControlReporteDeudas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_word_deuda;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Views\UserControlReporteDeudas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_excel_deuda;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Views\UserControlReporteDeudas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_pdf_deuda;
        
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
            System.Uri resourceLocater = new System.Uri("/Portafolio-Escritorio;component/views/usercontrolreportedeudas.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\UserControlReporteDeudas.xaml"
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
            this.dgv_reporte_deuda = ((System.Windows.Controls.DataGrid)(target));
            
            #line 16 "..\..\..\Views\UserControlReporteDeudas.xaml"
            this.dgv_reporte_deuda.Loaded += new System.Windows.RoutedEventHandler(this.dgv_reporte_deuda_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btn_word_deuda = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\Views\UserControlReporteDeudas.xaml"
            this.btn_word_deuda.Click += new System.Windows.RoutedEventHandler(this.btn_word_deuda_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btn_excel_deuda = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\Views\UserControlReporteDeudas.xaml"
            this.btn_excel_deuda.Click += new System.Windows.RoutedEventHandler(this.btn_excel_deuda_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btn_pdf_deuda = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\Views\UserControlReporteDeudas.xaml"
            this.btn_pdf_deuda.Click += new System.Windows.RoutedEventHandler(this.btn_pdf_deuda_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


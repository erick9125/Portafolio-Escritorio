﻿#pragma checksum "..\..\..\Views\UserControlRoles.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B0FF016988332D474B1D9D5D672583501B9B614E9D982EE3330135B780CB40E0"
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
    /// UserControlRoles
    /// </summary>
    public partial class UserControlRoles : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\Views\UserControlRoles.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_buscar_cli_rol;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Views\UserControlRoles.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_buscar_rol;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Views\UserControlRoles.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgvRoles;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Views\UserControlRoles.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cb_roles;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Views\UserControlRoles.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_guardar_rol;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Views\UserControlRoles.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_id_rol;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Views\UserControlRoles.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_id_rol_user;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Views\UserControlRoles.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_editar_rol;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Views\UserControlRoles.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_nuevo_rol;
        
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
            System.Uri resourceLocater = new System.Uri("/Portafolio-Escritorio;component/views/usercontrolroles.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\UserControlRoles.xaml"
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
            this.btn_buscar_cli_rol = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\Views\UserControlRoles.xaml"
            this.btn_buscar_cli_rol.Click += new System.Windows.RoutedEventHandler(this.btn_buscar_cli_rol_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txt_buscar_rol = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.dgvRoles = ((System.Windows.Controls.DataGrid)(target));
            
            #line 19 "..\..\..\Views\UserControlRoles.xaml"
            this.dgvRoles.Loaded += new System.Windows.RoutedEventHandler(this.dgvRoles_Loaded);
            
            #line default
            #line hidden
            
            #line 19 "..\..\..\Views\UserControlRoles.xaml"
            this.dgvRoles.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dgvRoles_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cb_roles = ((System.Windows.Controls.ComboBox)(target));
            
            #line 34 "..\..\..\Views\UserControlRoles.xaml"
            this.cb_roles.Loaded += new System.Windows.RoutedEventHandler(this.cb_roles_Loaded);
            
            #line default
            #line hidden
            
            #line 34 "..\..\..\Views\UserControlRoles.xaml"
            this.cb_roles.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cb_roles_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btn_guardar_rol = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\Views\UserControlRoles.xaml"
            this.btn_guardar_rol.Click += new System.Windows.RoutedEventHandler(this.btn_guardar_rol_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txt_id_rol = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txt_id_rol_user = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.btn_editar_rol = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\Views\UserControlRoles.xaml"
            this.btn_editar_rol.Click += new System.Windows.RoutedEventHandler(this.btn_editar_rol_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btn_nuevo_rol = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\Views\UserControlRoles.xaml"
            this.btn_nuevo_rol.Click += new System.Windows.RoutedEventHandler(this.btn_nuevo_rol_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 40 "..\..\..\Views\UserControlRoles.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


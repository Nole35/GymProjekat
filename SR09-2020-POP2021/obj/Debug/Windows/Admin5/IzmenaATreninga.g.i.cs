﻿#pragma checksum "..\..\..\..\Windows\Admin5\IzmenaATreninga.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E55BF1247C2A0E4DAA4244C61B1696826F34C1130D195D7C2BBAFFBD12889724"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SR09_2020_POP2021.Windows.Admin5;
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


namespace SR09_2020_POP2021.Windows.Admin5 {
    
    
    /// <summary>
    /// IzmenaATreninga
    /// </summary>
    public partial class IzmenaATreninga : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\..\Windows\Admin5\IzmenaATreninga.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSifra;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\Windows\Admin5\IzmenaATreninga.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtVreme;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\Windows\Admin5\IzmenaATreninga.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtInId;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\Windows\Admin5\IzmenaATreninga.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPolId;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\Windows\Admin5\IzmenaATreninga.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbStatus;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\Windows\Admin5\IzmenaATreninga.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTrajanje;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\Windows\Admin5\IzmenaATreninga.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDatum;
        
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
            System.Uri resourceLocater = new System.Uri("/SR09-2020-POP2021;component/windows/admin5/izmenaatreninga.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\Admin5\IzmenaATreninga.xaml"
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
            this.txtSifra = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtVreme = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtInId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtPolId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.cbStatus = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.txtTrajanje = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            
            #line 25 "..\..\..\..\Windows\Admin5\IzmenaATreninga.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.dodaj);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 26 "..\..\..\..\Windows\Admin5\IzmenaATreninga.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.close);
            
            #line default
            #line hidden
            return;
            case 9:
            this.txtDatum = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


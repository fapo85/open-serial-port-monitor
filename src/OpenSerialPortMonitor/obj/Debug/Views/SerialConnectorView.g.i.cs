﻿#pragma checksum "..\..\..\Views\SerialConnectorView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DA5B6EEA575AB08BB37CA94AE05F80674B41FE13CD732236B23EE3B5C2AA496D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace Whitestone.OpenSerialPortMonitor.Main.Views {
    
    
    /// <summary>
    /// SerialConnectorView
    /// </summary>
    public partial class SerialConnectorView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\..\Views\SerialConnectorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComPorts;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Views\SerialConnectorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox BaudRates;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Views\SerialConnectorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Parities;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Views\SerialConnectorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox DataBits;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Views\SerialConnectorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox StopBits;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Views\SerialConnectorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Connect;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Views\SerialConnectorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Disconnect;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\Views\SerialConnectorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LoadPorts;
        
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
            System.Uri resourceLocater = new System.Uri("/OpenSerialPortMonitor;component/views/serialconnectorview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\SerialConnectorView.xaml"
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
            this.ComPorts = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.BaudRates = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.Parities = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.DataBits = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.StopBits = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.Connect = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.Disconnect = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.LoadPorts = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "..\..\..\Org\PageOrders.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9DF0A1D2B1809B1B334C62327C70B8898735CA40DF377D6ACC94CECD4AB60010"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using WpfAppServiceCenter.Org;


namespace WpfAppServiceCenter.Org {
    
    
    /// <summary>
    /// PageOrders
    /// </summary>
    public partial class PageOrders : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\Org\PageOrders.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FIO;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Org\PageOrders.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Teleh;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Org\PageOrders.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Adres;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Org\PageOrders.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NAzvTech;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Org\PageOrders.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Opis;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Org\PageOrders.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DataRegis;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Org\PageOrders.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OfOrders;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfAppServiceCenter;component/org/pageorders.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Org\PageOrders.xaml"
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
            this.FIO = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.Teleh = ((System.Windows.Controls.TextBox)(target));
            
            #line 26 "..\..\..\Org\PageOrders.xaml"
            this.Teleh.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.Teleh_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Adres = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.NAzvTech = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Opis = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.DataRegis = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.OfOrders = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\..\Org\PageOrders.xaml"
            this.OfOrders.Click += new System.Windows.RoutedEventHandler(this.OfOrders_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "..\..\..\Windows\ModernSettings.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EDC7373469E98C601DEDC6CB895B60C6BFA1E14523BD47B5BA01F8A87C9E27CA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using RyosMKFXPanel.Windows;
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


namespace RyosMKFXPanel.Windows {
    
    
    /// <summary>
    /// ModernSettings
    /// </summary>
    public partial class ModernSettings : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 65 "..\..\..\Windows\ModernSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel TitleBar;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\Windows\ModernSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock X;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\Windows\ModernSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Y;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\Windows\ModernSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonClose;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\Windows\ModernSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBoxDevices;
        
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
            System.Uri resourceLocater = new System.Uri("/RyosMKFXPanel;component/windows/modernsettings.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\ModernSettings.xaml"
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
            this.TitleBar = ((System.Windows.Controls.DockPanel)(target));
            
            #line 65 "..\..\..\Windows\ModernSettings.xaml"
            this.TitleBar.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.MoveWindowUnlock);
            
            #line default
            #line hidden
            
            #line 65 "..\..\..\Windows\ModernSettings.xaml"
            this.TitleBar.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.MoveWindowLock);
            
            #line default
            #line hidden
            return;
            case 2:
            this.X = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.Y = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.ButtonClose = ((System.Windows.Controls.Button)(target));
            
            #line 75 "..\..\..\Windows\ModernSettings.xaml"
            this.ButtonClose.Click += new System.Windows.RoutedEventHandler(this.ButtonClose_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.comboBoxDevices = ((System.Windows.Controls.ComboBox)(target));
            
            #line 89 "..\..\..\Windows\ModernSettings.xaml"
            this.comboBoxDevices.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.comboBoxDevices_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 92 "..\..\..\Windows\ModernSettings.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonSettingsReset_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

﻿#pragma checksum "..\..\UserControlSettings.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "10642ABD56522AAAF3A40C1036D494E7893B2FAE66FAFC14CF35302C3B8D45E5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;
using MenuAnimation;
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


namespace MenuAnimation {
    
    
    /// <summary>
    /// UserControlSettings
    /// </summary>
    public partial class UserControlSettings : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\UserControlSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.Transitions.TransitioningContent TrainsitionigContentSlide;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\UserControlSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock _nameTitle;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\UserControlSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button _one;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\UserControlSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button _two;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\UserControlSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button _three;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\UserControlSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button _four;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\UserControlSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button _five;
        
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
            System.Uri resourceLocater = new System.Uri("/MenuAnimation;component/usercontrolsettings.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UserControlSettings.xaml"
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
            this.TrainsitionigContentSlide = ((MaterialDesignThemes.Wpf.Transitions.TransitioningContent)(target));
            return;
            case 2:
            this._nameTitle = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this._one = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\UserControlSettings.xaml"
            this._one.Click += new System.Windows.RoutedEventHandler(this._one_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this._two = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\UserControlSettings.xaml"
            this._two.Click += new System.Windows.RoutedEventHandler(this._two_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this._three = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\UserControlSettings.xaml"
            this._three.Click += new System.Windows.RoutedEventHandler(this._three_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this._four = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\UserControlSettings.xaml"
            this._four.Click += new System.Windows.RoutedEventHandler(this._four_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this._five = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\UserControlSettings.xaml"
            this._five.Click += new System.Windows.RoutedEventHandler(this._five_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


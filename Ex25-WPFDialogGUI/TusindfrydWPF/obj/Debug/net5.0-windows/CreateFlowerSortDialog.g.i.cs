﻿#pragma checksum "..\..\..\CreateFlowerSortDialog.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F2D195C1E820C2C261E3AA8B9232D4EC74979A84"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using TusindfrydWPF;


namespace TusindfrydWPF {
    
    
    /// <summary>
    /// CreateFlowerSortDialog
    /// </summary>
    public partial class CreateFlowerSortDialog : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\CreateFlowerSortDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Regret;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\CreateFlowerSortDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Ok;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\CreateFlowerSortDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameTB;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\CreateFlowerSortDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PicturePathTB;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\CreateFlowerSortDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ProductionTimeTB;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\CreateFlowerSortDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox HalfLifeTB;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\CreateFlowerSortDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SizeTB;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\CreateFlowerSortDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image FlowerSortImage;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.10.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/TusindfrydWPF;component/createflowersortdialog.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\CreateFlowerSortDialog.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.10.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Regret = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\..\CreateFlowerSortDialog.xaml"
            this.Regret.Click += new System.Windows.RoutedEventHandler(this.Regret_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Ok = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\CreateFlowerSortDialog.xaml"
            this.Ok.Click += new System.Windows.RoutedEventHandler(this.Ok_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.NameTB = ((System.Windows.Controls.TextBox)(target));
            
            #line 19 "..\..\..\CreateFlowerSortDialog.xaml"
            this.NameTB.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.NameTB_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.PicturePathTB = ((System.Windows.Controls.TextBox)(target));
            
            #line 20 "..\..\..\CreateFlowerSortDialog.xaml"
            this.PicturePathTB.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.PicturePathTB_TextChanged);
            
            #line default
            #line hidden
            
            #line 20 "..\..\..\CreateFlowerSortDialog.xaml"
            this.PicturePathTB.LostFocus += new System.Windows.RoutedEventHandler(this.PicturePathTB_LostFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ProductionTimeTB = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\..\CreateFlowerSortDialog.xaml"
            this.ProductionTimeTB.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.ProductionTimeTB_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.HalfLifeTB = ((System.Windows.Controls.TextBox)(target));
            
            #line 22 "..\..\..\CreateFlowerSortDialog.xaml"
            this.HalfLifeTB.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.HalfLifeTB_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.SizeTB = ((System.Windows.Controls.TextBox)(target));
            
            #line 23 "..\..\..\CreateFlowerSortDialog.xaml"
            this.SizeTB.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SizeTB_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.FlowerSortImage = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "..\..\..\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C17B625BC26B522BAEADC59DDE0D9FC7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
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


namespace SO_Widget {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label RepLabel;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ValLabel;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label DiffLabel;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LastUpdLabel;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ProfileLabel;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label RefreshLabel;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image CloseImg;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image DiscImg;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SO_Widget;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 4 "..\..\..\MainWindow.xaml"
            ((SO_Widget.MainWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 5 "..\..\..\MainWindow.xaml"
            ((SO_Widget.MainWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            
            #line 5 "..\..\..\MainWindow.xaml"
            ((SO_Widget.MainWindow)(target)).LocationChanged += new System.EventHandler(this.Window_LocationChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 8 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click);
            
            #line default
            #line hidden
            
            #line 8 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Checked += new System.Windows.RoutedEventHandler(this.MenuItem_Checked);
            
            #line default
            #line hidden
            
            #line 8 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.MenuItem_Unchecked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.RepLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.ValLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.DiffLabel = ((System.Windows.Controls.Label)(target));
            
            #line 36 "..\..\..\MainWindow.xaml"
            this.DiffLabel.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.DiffLabel_MouseUp);
            
            #line default
            #line hidden
            return;
            case 6:
            this.LastUpdLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.ProfileLabel = ((System.Windows.Controls.Label)(target));
            
            #line 39 "..\..\..\MainWindow.xaml"
            this.ProfileLabel.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.ProfileLabel_MouseUp);
            
            #line default
            #line hidden
            return;
            case 8:
            this.RefreshLabel = ((System.Windows.Controls.Label)(target));
            
            #line 40 "..\..\..\MainWindow.xaml"
            this.RefreshLabel.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.RefreshLabel_MouseUp);
            
            #line default
            #line hidden
            return;
            case 9:
            this.CloseImg = ((System.Windows.Controls.Image)(target));
            
            #line 45 "..\..\..\MainWindow.xaml"
            this.CloseImg.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.CloseImg_MouseUp);
            
            #line default
            #line hidden
            return;
            case 10:
            this.DiscImg = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


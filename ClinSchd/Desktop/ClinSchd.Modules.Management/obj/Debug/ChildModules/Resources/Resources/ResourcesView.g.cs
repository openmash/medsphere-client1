﻿#pragma checksum "..\..\..\..\..\ChildModules\Resources\Resources\ResourcesView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "49E9D9993B3BD4F13862A7F80743DCDC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ClinSchd.Infrastructure.Converters;
using ClinSchd.Infrastructure.Models;
using Microsoft.Practices.Composite.Presentation.Commands;
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
using Telerik.Windows.Controls;
using Telerik.Windows.Controls.Carousel;
using Telerik.Windows.Controls.Docking;
using Telerik.Windows.Controls.GridView;
using Telerik.Windows.Data;


namespace ClinSchd.Modules.Management.Resources {
    
    
    /// <summary>
    /// ResourcesView
    /// </summary>
    public partial class ResourcesView : Telerik.Windows.Controls.RadPane, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\..\..\..\ChildModules\Resources\Resources\ResourcesView.xaml"
        internal ClinSchd.Modules.Management.Resources.ResourcesView paneManagementResources;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\..\ChildModules\Resources\Resources\ResourcesView.xaml"
        internal System.Windows.Controls.ListBox UserListBox;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\..\ChildModules\Resources\Resources\ResourcesView.xaml"
        internal Telerik.Windows.Controls.RadButton AddClinic;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\..\ChildModules\Resources\Resources\ResourcesView.xaml"
        internal Telerik.Windows.Controls.RadButton EditClinic;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\..\ChildModules\Resources\Resources\ResourcesView.xaml"
        internal Telerik.Windows.Controls.RadButton RemoveClinic;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\..\ChildModules\Resources\Resources\ResourcesView.xaml"
        internal Telerik.Windows.Controls.RadButton AddUser;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\..\ChildModules\Resources\Resources\ResourcesView.xaml"
        internal Telerik.Windows.Controls.RadButton RemoveUser;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\..\ChildModules\Resources\Resources\ResourcesView.xaml"
        internal Telerik.Windows.Controls.RadButton RemoveAll;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\..\..\ChildModules\Resources\Resources\ResourcesView.xaml"
        internal System.Windows.Controls.ListBox ResourceListBox;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\..\..\ChildModules\Resources\Resources\ResourcesView.xaml"
        internal System.Windows.Controls.ListBox ResourceUserListBox;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\..\..\ChildModules\Resources\Resources\ResourcesView.xaml"
        internal Telerik.Windows.Controls.RadButton EditUser;
        
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
            System.Uri resourceLocater = new System.Uri("/ClinSchd.Modules.Management;component/childmodules/resources/resources/resources" +
                    "view.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\ChildModules\Resources\Resources\ResourcesView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.paneManagementResources = ((ClinSchd.Modules.Management.Resources.ResourcesView)(target));
            return;
            case 2:
            this.UserListBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 42 "..\..\..\..\..\ChildModules\Resources\Resources\ResourcesView.xaml"
            this.UserListBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.UserListBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.AddClinic = ((Telerik.Windows.Controls.RadButton)(target));
            
            #line 44 "..\..\..\..\..\ChildModules\Resources\Resources\ResourcesView.xaml"
            this.AddClinic.Click += new System.Windows.RoutedEventHandler(this.AddClinic_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.EditClinic = ((Telerik.Windows.Controls.RadButton)(target));
            
            #line 45 "..\..\..\..\..\ChildModules\Resources\Resources\ResourcesView.xaml"
            this.EditClinic.Click += new System.Windows.RoutedEventHandler(this.EditClinic_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.RemoveClinic = ((Telerik.Windows.Controls.RadButton)(target));
            
            #line 46 "..\..\..\..\..\ChildModules\Resources\Resources\ResourcesView.xaml"
            this.RemoveClinic.Click += new System.Windows.RoutedEventHandler(this.RemoveClinic_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.AddUser = ((Telerik.Windows.Controls.RadButton)(target));
            
            #line 48 "..\..\..\..\..\ChildModules\Resources\Resources\ResourcesView.xaml"
            this.AddUser.Click += new System.Windows.RoutedEventHandler(this.AddUser_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.RemoveUser = ((Telerik.Windows.Controls.RadButton)(target));
            
            #line 50 "..\..\..\..\..\ChildModules\Resources\Resources\ResourcesView.xaml"
            this.RemoveUser.Click += new System.Windows.RoutedEventHandler(this.RemoveUser_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.RemoveAll = ((Telerik.Windows.Controls.RadButton)(target));
            
            #line 52 "..\..\..\..\..\ChildModules\Resources\Resources\ResourcesView.xaml"
            this.RemoveAll.Click += new System.Windows.RoutedEventHandler(this.RemoveAll_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ResourceListBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 63 "..\..\..\..\..\ChildModules\Resources\Resources\ResourcesView.xaml"
            this.ResourceListBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.ResourceUserListBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 71 "..\..\..\..\..\ChildModules\Resources\Resources\ResourcesView.xaml"
            this.ResourceUserListBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ResourceUserListBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.EditUser = ((Telerik.Windows.Controls.RadButton)(target));
            
            #line 73 "..\..\..\..\..\ChildModules\Resources\Resources\ResourcesView.xaml"
            this.EditUser.Click += new System.Windows.RoutedEventHandler(this.EditUser_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


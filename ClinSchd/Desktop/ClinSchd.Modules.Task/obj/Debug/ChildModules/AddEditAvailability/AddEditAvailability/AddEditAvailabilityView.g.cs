﻿#pragma checksum "..\..\..\..\..\ChildModules\AddEditAvailability\AddEditAvailability\AddEditAvailabilityView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FA793943B6E61ACE0268353CD4A6E8DE"
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
using Telerik.Windows.Controls.Scheduler;
using Telerik.Windows.Data;


namespace ClinSchd.Modules.Task.AddEditAvailability {
    
    
    /// <summary>
    /// AddEditAvailabilityView
    /// </summary>
    public partial class AddEditAvailabilityView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\..\..\..\ChildModules\AddEditAvailability\AddEditAvailability\AddEditAvailabilityView.xaml"
        internal ClinSchd.Modules.Task.AddEditAvailability.AddEditAvailabilityView paneManagementAddResource;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\..\ChildModules\AddEditAvailability\AddEditAvailability\AddEditAvailabilityView.xaml"
        internal System.Windows.Controls.TextBox StartTime;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\..\ChildModules\AddEditAvailability\AddEditAvailability\AddEditAvailabilityView.xaml"
        internal System.Windows.Controls.TextBox EndTime;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\..\ChildModules\AddEditAvailability\AddEditAvailability\AddEditAvailabilityView.xaml"
        internal System.Windows.Controls.TextBox ClinicName;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\..\ChildModules\AddEditAvailability\AddEditAvailability\AddEditAvailabilityView.xaml"
        internal System.Windows.Controls.TextBox NotesTextBox;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\..\ChildModules\AddEditAvailability\AddEditAvailability\AddEditAvailabilityView.xaml"
        internal Telerik.Windows.Controls.RadComboBox AccessGroup;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\..\..\ChildModules\AddEditAvailability\AddEditAvailability\AddEditAvailabilityView.xaml"
        internal System.Windows.Controls.ListBox AccessTypeListBox;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\..\..\ChildModules\AddEditAvailability\AddEditAvailability\AddEditAvailabilityView.xaml"
        internal Telerik.Windows.Controls.RadButton CancelButton;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\..\..\ChildModules\AddEditAvailability\AddEditAvailability\AddEditAvailabilityView.xaml"
        internal Telerik.Windows.Controls.RadButton OkButton;
        
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
            System.Uri resourceLocater = new System.Uri("/ClinSchd.Modules.Task;component/childmodules/addeditavailability/addeditavailabi" +
                    "lity/addeditavailabilityview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\ChildModules\AddEditAvailability\AddEditAvailability\AddEditAvailabilityView.xaml"
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
            this.paneManagementAddResource = ((ClinSchd.Modules.Task.AddEditAvailability.AddEditAvailabilityView)(target));
            return;
            case 2:
            this.StartTime = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.EndTime = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.ClinicName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.NotesTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.AccessGroup = ((Telerik.Windows.Controls.RadComboBox)(target));
            
            #line 63 "..\..\..\..\..\ChildModules\AddEditAvailability\AddEditAvailability\AddEditAvailabilityView.xaml"
            this.AccessGroup.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.AccessGroup_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.AccessTypeListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 8:
            this.CancelButton = ((Telerik.Windows.Controls.RadButton)(target));
            
            #line 84 "..\..\..\..\..\ChildModules\AddEditAvailability\AddEditAvailability\AddEditAvailabilityView.xaml"
            this.CancelButton.Click += new System.Windows.RoutedEventHandler(this.CancelButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.OkButton = ((Telerik.Windows.Controls.RadButton)(target));
            
            #line 86 "..\..\..\..\..\ChildModules\AddEditAvailability\AddEditAvailability\AddEditAvailabilityView.xaml"
            this.OkButton.Click += new System.Windows.RoutedEventHandler(this.OkButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


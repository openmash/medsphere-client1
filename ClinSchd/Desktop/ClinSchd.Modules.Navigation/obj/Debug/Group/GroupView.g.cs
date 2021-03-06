﻿#pragma checksum "..\..\..\Group\GroupView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BC52DF623C8296A4C8C78DEBABE34456"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ClinSchd.Infrastructure.Controls;
using ClinSchd.Infrastructure.Models;
using Microsoft.Practices.Composite.Presentation.Commands;
using Microsoft.Practices.Composite.Presentation.Regions;
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


namespace ClinSchd.Modules.Navigation.Group {
    
    
    /// <summary>
    /// GroupView
    /// </summary>
    public partial class GroupView : Telerik.Windows.Controls.RadPane, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\Group\GroupView.xaml"
        internal Telerik.Windows.Controls.RadCalendar calendar;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Group\GroupView.xaml"
        internal Telerik.Windows.Controls.RadOutlookBar RadOutlookBar1;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Group\GroupView.xaml"
        internal Telerik.Windows.Controls.RadGridView AdmittedPatients;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Group\GroupView.xaml"
        internal Telerik.Windows.Controls.RadContextMenu PatientContextMenu;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\Group\GroupView.xaml"
        internal Telerik.Windows.Controls.RadComboBox ResourceComboBox;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\Group\GroupView.xaml"
        internal Telerik.Windows.Controls.RadComboBox ProviderComboBox;
        
        #line default
        #line hidden
        
        
        #line 132 "..\..\..\Group\GroupView.xaml"
        internal Telerik.Windows.Controls.RadComboBox ResourceGroupComboBox;
        
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
            System.Uri resourceLocater = new System.Uri("/ClinSchd.Modules.Navigation;component/group/groupview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Group\GroupView.xaml"
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
            this.calendar = ((Telerik.Windows.Controls.RadCalendar)(target));
            
            #line 25 "..\..\..\Group\GroupView.xaml"
            this.calendar.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.calendar_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.RadOutlookBar1 = ((Telerik.Windows.Controls.RadOutlookBar)(target));
            return;
            case 3:
            this.AdmittedPatients = ((Telerik.Windows.Controls.RadGridView)(target));
            
            #line 37 "..\..\..\Group\GroupView.xaml"
            this.AdmittedPatients.SelectionChanged += new System.EventHandler<Telerik.Windows.Controls.SelectionChangeEventArgs>(this.AdmittedPatients_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.PatientContextMenu = ((Telerik.Windows.Controls.RadContextMenu)(target));
            
            #line 44 "..\..\..\Group\GroupView.xaml"
            this.PatientContextMenu.ItemClick += new Telerik.Windows.RadRoutedEventHandler(this.PatientContextMenu_ItemClick);
            
            #line default
            #line hidden
            
            #line 44 "..\..\..\Group\GroupView.xaml"
            this.PatientContextMenu.Opened += new System.Windows.RoutedEventHandler(this.PatientContextMenu_Opened);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ResourceComboBox = ((Telerik.Windows.Controls.RadComboBox)(target));
            
            #line 75 "..\..\..\Group\GroupView.xaml"
            this.ResourceComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ClinicComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ProviderComboBox = ((Telerik.Windows.Controls.RadComboBox)(target));
            
            #line 106 "..\..\..\Group\GroupView.xaml"
            this.ProviderComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ProviderComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ResourceGroupComboBox = ((Telerik.Windows.Controls.RadComboBox)(target));
            
            #line 137 "..\..\..\Group\GroupView.xaml"
            this.ResourceGroupComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ResourceGroupComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


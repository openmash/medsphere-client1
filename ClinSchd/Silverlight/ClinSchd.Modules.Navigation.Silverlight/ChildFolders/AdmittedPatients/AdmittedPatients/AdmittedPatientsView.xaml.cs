//===================================================================================
// Microsoft patterns & practices
// Composite Application Guidance for Windows Presentation Foundation and Silverlight
//===================================================================================
// Copyright (c) Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===================================================================================
// The example companies, organizations, products, domain names,
// e-mail addresses, logos, people, places, and events depicted
// herein are fictitious.  No association with any real company,
// organization, product, domain name, email address, logo, person,
// places, or events is intended or should be inferred.
//===================================================================================
using System;
using System.Windows;
using System.Windows.Controls;

namespace ADT.Modules.Navigation.AdmittedPatients
{
    public partial class AdmittedPatientsView : UserControl, IAdmittedPatientsView
    {
        public AdmittedPatientsView()
        {
            InitializeComponent();
        }

		public event EventHandler<EventArgs> ShowNavigationAdmittedPatients;

        public AdmittedPatientsPresentationModel Model
        {
            get
            {
                return this.DataContext as AdmittedPatientsPresentationModel;
            }

            set
            {
                this.DataContext = value;
            }
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
			if (this.NavigationAdmittedPatientsList.SelectedItem != null)
            {
                VisualStateManager.GoToState(this, "Details", true);
            } 
            else
            {
                VisualStateManager.GoToState(this, "List", true);
            }
        }
    }
}
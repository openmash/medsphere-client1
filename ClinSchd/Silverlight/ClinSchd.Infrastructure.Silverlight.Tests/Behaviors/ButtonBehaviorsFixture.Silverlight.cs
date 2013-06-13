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
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ADT.Infrastructure.Behaviors;

namespace ADT.Infrastructure.Tests.Behaviors
{
    [TestClass]
    public class ButtonBehaviorsFixture
    {
        [TestMethod]
        public void ShouldCloseParentPopupOnButtonClick()
        {
            Popup parentPopup = new Popup();
            var button = new ClickableButton();
            button.SetValue(ButtonBehaviors.CloseAncestorPopupProperty, true);
            parentPopup.Child = button;

            parentPopup.IsOpen = true;

            button.RaiseClick();

            Assert.IsFalse(parentPopup.IsOpen);
        }

        [TestMethod]
        public void ShouldCloseAncestorPopupOnButtonClick()
        {
            Popup ancestorPopup = new Popup();
            var button = new ClickableButton();
            button.SetValue(ButtonBehaviors.CloseAncestorPopupProperty, true);
            var immediateParent = new ContentControl();
            immediateParent.Content = button;
            ancestorPopup.Child = immediateParent;

            ancestorPopup.IsOpen = true;

            button.RaiseClick();

            Assert.IsFalse(ancestorPopup.IsOpen);
        }

        internal class ClickableButton : ButtonBase
        {
            public void RaiseClick()
            {
                base.OnClick();
            }
        }
    }
}
   M S B A M L   `   `   `  ����R  NClinSchd.Infrastructure, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullpMclr-namespace:ClinSchd.Infrastructure.Models;assembly=ClinSchd.InfrastructureClinSchd.Infrastructure.Models  5      k gTelerik.Windows.Controls.Input, Version=2010.1.603.35, Culture=neutral, PublicKeyToken=5803cfa389c90ce7kNclr-namespace:Telerik.Windows.Controls;assembly=Telerik.Windows.Controls.InputTelerik.Windows.Controls 5      xQclr-namespace:ClinSchd.Infrastructure.Converters;assembly=ClinSchd.Infrastructure"ClinSchd.Infrastructure.Converters  5      e aTelerik.Windows.Controls, Version=2010.1.603.35, Culture=neutral, PublicKeyToken=5803cfa389c90ce7eHclr-namespace:Telerik.Windows.Controls;assembly=Telerik.Windows.ControlsTelerik.Windows.Controls 5	      n jTelerik.Windows.Controls.GridView, Version=2010.1.603.35, Culture=neutral, PublicKeyToken=5803cfa389c90ce7nQclr-namespace:Telerik.Windows.Controls;assembly=Telerik.Windows.Controls.GridViewTelerik.Windows.Controls 5
      �Zclr-namespace:Telerik.Windows.Controls.GridView;assembly=Telerik.Windows.Controls.GridView!Telerik.Windows.Controls.GridView 5      p lTelerik.Windows.Controls.Navigation, Version=2010.1.603.35, Culture=neutral, PublicKeyToken=5803cfa389c90ce7pSclr-namespace:Telerik.Windows.Controls;assembly=Telerik.Windows.Controls.NavigationTelerik.Windows.Controls 5      e aMicrosoft.Practices.Composite.Presentation, Version=2.0.1.0, Culture=neutral, PublicKeyToken=null�uclr-namespace:Microsoft.Practices.Composite.Presentation.Commands;assembly=Microsoft.Practices.Composite.Presentation3Microsoft.Practices.Composite.Presentation.Commands 6l   a ]Telerik.Windows.Data, Version=2010.1.603.35, Culture=neutral, PublicKeyToken=5803cfa389c90ce7Y@clr-namespace:Telerik.Windows.Data;assembly=Telerik.Windows.DataTelerik.Windows.Data 5       ClinSchd.Modules.ManagementB   <ClinSchd.Modules.Management.AddResource.ResourceWaitlistView   5   	   W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R	 NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\
 XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation  	 
 5      8x,http://schemas.microsoft.com/winfx/2006/xaml  	 
 5      a	infModelsMclr-namespace:ClinSchd.Infrastructure.Models;assembly=ClinSchd.Infrastructure  	 
 5      >d2http://schemas.microsoft.com/expression/blend/2008  	 
 5      Hmc;http://schemas.openxmlformats.org/markup-compatibility/2006  	 
 6B   m iTelerik.Windows.Controls.Docking, Version=2010.1.603.35, Culture=neutral, PublicKeyToken=5803cfa389c90ce7Npresentation1http://schemas.telerik.com/2008/xaml/presentation       5      dinputNclr-namespace:Telerik.Windows.Controls;assembly=Telerik.Windows.Controls.Input       5      l
ConvertersQclr-namespace:ClinSchd.Infrastructure.Converters;assembly=ClinSchd.Infrastructure       5      acontrolsHclr-namespace:Telerik.Windows.Controls;assembly=Telerik.Windows.Controls       5	      fgridQclr-namespace:Telerik.Windows.Controls;assembly=Telerik.Windows.Controls.GridView       5
      sgridViewZclr-namespace:Telerik.Windows.Controls.GridView;assembly=Telerik.Windows.Controls.GridView       5      n
navigationSclr-namespace:Telerik.Windows.Controls;assembly=Telerik.Windows.Controls.Navigation       5      �caluclr-namespace:Microsoft.Practices.Composite.Presentation.Commands;assembly=Microsoft.Practices.Composite.Presentation       6l   Udata@clr-namespace:Telerik.Windows.Data;assembly=Telerik.Windows.Data       5      -   5          �Name$  paneManagementAddResource��5   	    � Title$ Clinic Waitlist��6,   $	��574��5      $	��640��6    � Icon$0 */ClinSchd;component/Resources/ClinSchd.ico��5      ��5      � 5   
   
������� � RowDefinitions 5      �� 5      $��* �6    �� 5      $
��Auto �6    $��36��6.    � ColumnDefinitions 5      �� 5      $��* �6#   .+�5      *  $Telerik.Windows.Controls.RadGridView  ;  5Telerik.Windows.Controls.GridView.GridViewDataControl   AutoGenerateColumns .     ShowGroupPanel .  $��0��6v   $��Stretch=�6�   $��Stretch=�6�   ��. $��Visible=�6�   *  $Telerik.Windows.Controls.DataControl   ItemsSource 6   �� *WaitingList+   Columns 5      1  +Telerik.Windows.Controls.GridViewDataColumn  5      6  0Telerik.Windows.Controls.GridViewBoundColumnBase	   Header$	 Patient Name��6.   
   DataMemberBinding
 6D   �� *[PATIENT_NAME]+6s     5      $	 
Home Phone��6.   
 6B   �� *[HOME_PHONE]+6o     5       $	 
Work Phone��6.   
 6B   �� *[WORK_PHONE]+6o     5!      $	 Chart #��6.   
 6?   �� *	[CHART]+6g     5"      $	 
Date Added��6.   
 6B   �� *[DATE_ADDED]+6o     5#      $	 Reason Added��6.   
 6D   �� *
[REASON]+6m     5$      $	 Priority��6.   
 6@   �� *
[PRIORITY]+6k     5%      $	 Provider��6.   
 6@   �� *
[PROVIDER]+6k     5&      $	 Recall Date��6.   
 6C   �� *[RECALL_DATE]+6q     5'      $	 Comments��6.   
 6@   �� *	[COMMENT]+6j   5)      ]� 5+      $��1��6   .+�5,      �� $
��Left=�6    �� Orientation$ 
Horizontal=�63   $
��Left=�6L   $��Stretch=�6g   $��5,0,0,5q�6�   .+�5-      �� $��14(�6   
����  �.��6<   This clinic has a waitlist.6Y   5.      �� 5/      $��Right=�6   $ 
Horizontal=�64   $��Right=�6M   $��Stretch=�6i   $��0,0,5,5q�6�   .+�50      (  "Telerik.Windows.Controls.RadButton  -   5        $��OK��50   G   $��23��6-   $��75��69   $��Bottom=�6b   .��6}   Close6�   51      52      53      55      
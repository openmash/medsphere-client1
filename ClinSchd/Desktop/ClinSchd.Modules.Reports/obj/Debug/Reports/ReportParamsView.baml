   M S B A M L   `   `   `  ����R  NClinSchd.Infrastructure, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullbFclr-namespace:ClinSchd.Infrastructure;assembly=ClinSchd.InfrastructureClinSchd.Infrastructure  5      tOclr-namespace:ClinSchd.Infrastructure.Controls;assembly=ClinSchd.Infrastructure ClinSchd.Infrastructure.Controls  5      e aTelerik.Windows.Controls, Version=2010.1.603.35, Culture=neutral, PublicKeyToken=5803cfa389c90ce7eHclr-namespace:Telerik.Windows.Controls;assembly=Telerik.Windows.ControlsTelerik.Windows.Controls 5      pMclr-namespace:ClinSchd.Infrastructure.Models;assembly=ClinSchd.InfrastructureClinSchd.Infrastructure.Models  5	      k gTelerik.Windows.Controls.Input, Version=2010.1.603.35, Culture=neutral, PublicKeyToken=5803cfa389c90ce7kNclr-namespace:Telerik.Windows.Controls;assembly=Telerik.Windows.Controls.InputTelerik.Windows.Controls 5      e aMicrosoft.Practices.Composite.Presentation, Version=2.0.1.0, Culture=neutral, PublicKeyToken=null�uclr-namespace:Microsoft.Practices.Composite.Presentation.Commands;assembly=Microsoft.Practices.Composite.Presentation3Microsoft.Practices.Composite.Presentation.Commands 5       ClinSchd.Modules.Reports7   1ClinSchd.Modules.Reports.Reports.ReportParamsView   5      W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5      TinfFclr-namespace:ClinSchd.Infrastructure;assembly=ClinSchd.Infrastructure    5      a ]Telerik.Windows.Data, Version=2010.1.603.35, Culture=neutral, PublicKeyToken=5803cfa389c90ce7n	 jTelerik.Windows.Controls.GridView, Version=2010.1.603.35, Culture=neutral, PublicKeyToken=5803cfa389c90ce7p
 lTelerik.Windows.Controls.Navigation, Version=2010.1.603.35, Culture=neutral, PublicKeyToken=5803cfa389c90ce7m iTelerik.Windows.Controls.Docking, Version=2010.1.603.35, Culture=neutral, PublicKeyToken=5803cfa389c90ce7Npresentation1http://schemas.telerik.com/2008/xaml/presentation   	  
  5      pClinSchdcontrolsOclr-namespace:ClinSchd.Infrastructure.Controls;assembly=ClinSchd.Infrastructure   	  
  5      htelerikControlsHclr-namespace:Telerik.Windows.Controls;assembly=Telerik.Windows.Controls   	  
  5      g	infModelsMclr-namespace:ClinSchd.Infrastructure.Models;assembly=ClinSchd.Infrastructure   	  
  5	      Dd2http://schemas.microsoft.com/expression/blend/2008   	  
  5
      Nmc;http://schemas.openxmlformats.org/markup-compatibility/2006   	  
  6B   dinputNclr-namespace:Telerik.Windows.Controls;assembly=Telerik.Windows.Controls.Input   	  
  5      �caluclr-namespace:Microsoft.Practices.Composite.Presentation.Commands;assembly=Microsoft.Practices.Composite.Presentation   	  
  5      -   5        &   Telerik.Windows.Controls.RadPane   Name$  paneReportsParameters��5         CanUserClose .     CanDockInDocumentHost .     
CanUserPin .    CanFloat .     Title 5      �� *Model.ReportDisplayName+ �� Mode$ OneWay=���5      � 5   
   
������� � RowDefinitions 5      �� 5      $��* �6    �� 5      $
��Auto �6    $��36��6.    � ColumnDefinitions 5      �� 5      $��* �6#   .+�5      �� 
�������$��1q�6)   ._�5      �� $
��Auto=�6   $��0��6B   .��5      � $��0��6   ��. $��Stretch=�6M   $
��Auto��6k    5      �� 5      $
��Auto �6,   �� 5       $
��Auto �6,    5"      �� 5#      .+�5%      �� 	 �� Orientation$	 
Horizontal=�6%   $��0��6>   .+�5&      �� $
��Left=�6(   $��24(�6C   
�������$��5,5,0,5q�6g   Report Parameters:6�   �� 5'      $
��Left=�6(   $��24(�6C   $��5,5,0,5q�6Q   ��6b   �� *Model.ReportDisplayName+6�   5(      � 5)      -   5        
 �Name$
 paramControlsGrid��5)   ,   $��1��6   $	��Top=�6G   $��Stretch=�6_    5*      �� 5+   "   $
��Auto �63   �� 5,   "   $
��Auto �63   �� 5-   "   $��* �63   5/      50      51      52      ]� 53      $��1��6   
�������.+�54      �� $��Bottom=�6   $��36��65   $	 
Horizontal=�6D   $��Right=�6]   $��Stretch=�6y   $��0,0,0,5q�6�   .+�55      (  "Telerik.Windows.Controls.RadButton  -   5        $��OK��55   G   $��23��6-   $��75��69   $��Bottom=�6y   ?  9Microsoft.Practices.Composite.Presentation.Commands.Click   Command 6Q   �� *	OKCommand+.��6�   OK6�     56      -   5        $��Cancel��56   G   $��23��6-   $��75��69   $��Bottom=�6�   $��5,0,5,0q�6�    6U   �� *CancelCommand+.��6�   Cancel6�   57      58      59      5;      
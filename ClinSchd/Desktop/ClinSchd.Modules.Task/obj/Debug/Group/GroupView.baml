   M S B A M L   `   `   `  ����R  NClinSchd.Infrastructure, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullpMclr-namespace:ClinSchd.Infrastructure.Models;assembly=ClinSchd.InfrastructureClinSchd.Infrastructure.Models  5      p lTelerik.Windows.Controls.Navigation, Version=2010.1.603.35, Culture=neutral, PublicKeyToken=5803cfa389c90ce7pSclr-namespace:Telerik.Windows.Controls;assembly=Telerik.Windows.Controls.NavigationTelerik.Windows.Controls 5      e aMicrosoft.Practices.Composite.Presentation, Version=2.0.1.0, Culture=neutral, PublicKeyToken=null�tclr-namespace:Microsoft.Practices.Composite.Presentation.Regions;assembly=Microsoft.Practices.Composite.Presentation2Microsoft.Practices.Composite.Presentation.Regions 5      �uclr-namespace:Microsoft.Practices.Composite.Presentation.Commands;assembly=Microsoft.Practices.Composite.Presentation3Microsoft.Practices.Composite.Presentation.Commands 5	       ClinSchd.Modules.Task+   %ClinSchd.Modules.Task.Group.GroupView   5      W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5      a	infModelsMclr-namespace:ClinSchd.Infrastructure.Models;assembly=ClinSchd.Infrastructure    5      >d2http://schemas.microsoft.com/expression/blend/2008    5      Hmc;http://schemas.openxmlformats.org/markup-compatibility/2006    6B   k gTelerik.Windows.Controls.Input, Version=2010.1.603.35, Culture=neutral, PublicKeyToken=5803cfa389c90ce7a ]Telerik.Windows.Data, Version=2010.1.603.35, Culture=neutral, PublicKeyToken=5803cfa389c90ce7n	 jTelerik.Windows.Controls.GridView, Version=2010.1.603.35, Culture=neutral, PublicKeyToken=5803cfa389c90ce7m
 iTelerik.Windows.Controls.Docking, Version=2010.1.603.35, Culture=neutral, PublicKeyToken=5803cfa389c90ce7e aTelerik.Windows.Controls, Version=2010.1.603.35, Culture=neutral, PublicKeyToken=5803cfa389c90ce7o kTelerik.Windows.Controls.Scheduler, Version=2010.1.603.35, Culture=neutral, PublicKeyToken=5803cfa389c90ce7Ppresentation1http://schemas.telerik.com/2008/xaml/presentation   	 
    5      p
navigationSclr-namespace:Telerik.Windows.Controls;assembly=Telerik.Windows.Controls.Navigation   	 
    5      �regionstclr-namespace:Microsoft.Practices.Composite.Presentation.Regions;assembly=Microsoft.Practices.Composite.Presentation   	 
    5      �caluclr-namespace:Microsoft.Practices.Composite.Presentation.Commands;assembly=Microsoft.Practices.Composite.Presentation   	 
    5	      & 
  Telerik.Windows.Controls.RadPane    Title$  	Schedules��5         CanUserClose .  ��5      ) 
 #Telerik.Windows.Controls.RadDocking  5      -   5          Name$ TasksDocking��5         AllowUnsafeMode .    DocumentHost 5      0 
 *Telerik.Windows.Controls.RadSplitContainer  5      .@�5      + 
 %Telerik.Windows.Controls.RadPaneGroup  -   5        $��SchedulerGroup��5   �   F  @Microsoft.Practices.Composite.Presentation.Regions.RegionManager   
RegionName$ TaskGroupRegion��6!   ,  &Telerik.Windows.Controls.RadTabControl(   !PropagateItemDataContextToContent .  6�   5      .@�5           InitialPosition$ DockedBottom=�6-   $��52��6L   y�6X   �� *LegendVisibility+ �� Mode$ OneWay=�	 �� UpdateSourceTrigger$	 PropertyChanged=�.@�5         .  .@�5        
   CanFloat
 .     
CanUserPin .  ��5      �� 5      $��Bottom=�6%   ���#C2DCFF._�5   "   ��  �� Orientation$ 
Horizontal=�6.   $��1q�6G   $��Center=�6R   .+�5   &   �� $��Center=�6-   $��24��6H   $��14��6S   $��10 4 0 4q�6_   
���   �$��1,1,1,1q�6�    �� CornerRadius$ 2,2,2,2��6�   
�������6�   �� 5   &   $
��Wrap=�61   $��Stretch=�6E   $��2 0 16 0q�6d   $��13(�6v   $��Center=�6�   
���   �$	��New��6�   6�   �� 5   &   $��Center=�6-   $��24��6H   $��14��6S   $	��0 4q�6_   
���   �$��1,1,1,1q�6�   $ 2,2,2,2��6�   
����  �6�   �� 5   &   $
��Wrap=�61   $��Stretch=�6E   $��2 0 16 0q�6d   $��13(�6v   $��Center=�6�   
���   �$��Walk In��6�   6�   �� 5   &   $��Center=�6-   $��24��6H   $��14��6S   $	��0 4q�6_   
���   �$��1,1,1,1q�6�   $ 2,2,2,2��6�   
�������6�   �� 5   &   $
��Wrap=�61   $��Stretch=�6E   $��2 0 16 0q�6d   $��13(�6v   $��Center=�6�   
���   �$��No Show��6�   6�   �� 5    &   $��Center=�6-   $��24��6H   $��14��6S   $	��0 4q�6_   
���   �$��1,1,1,1q�6�   $ 2,2,2,2��6�   
��� � �6�   �� 5!   &   $
��Wrap=�61   $��Stretch=�6E   $��2 0 16 0q�6d   $��13(�6v   $��Center=�6�   
���   �$��Check In��6�   6�   �� 5"   &   $��Center=�6-   $��24��6H   $��14��6S   $	��0 4q�6_   
���   �$��1,1,1,1q�6�   $ 2,2,2,2��6�   
��� ���6�   �� 5#   &   $
��Wrap=�61   $��Stretch=�6E   $��2 0 16 0q�6c   $��13(�6u   $��Center=�6�   
���   �$��	Check Out��6�   6�   �� 5$   &   $��Center=�6-   $��24��6H   $��14��6S   $	��0 4q�6_   
���   �$��1,1,1,1q�6�   $ 2,2,2,2��6�   
�������6�   �� 5%   &   $
��Wrap=�61   $��Stretch=�6E   $��2 0 16 0q�6d   $��13(�6v   $��Center=�6�   
���   �$��	Cancelled��6�   6�   5&   #   5'      5)      5*      5+      5,      5.      
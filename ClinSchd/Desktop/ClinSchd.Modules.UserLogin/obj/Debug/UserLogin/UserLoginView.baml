   M S B A M L   `   `   `  ����R  NClinSchd.Infrastructure, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullbFclr-namespace:ClinSchd.Infrastructure;assembly=ClinSchd.InfrastructureClinSchd.Infrastructure  5       ClinSchd.Modules.UserLogin8   2ClinSchd.Modules.UserLogin.UserLogin.UserLoginView   5   	   W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5      TinfFclr-namespace:ClinSchd.Infrastructure;assembly=ClinSchd.Infrastructure    5      e aTelerik.Windows.Controls, Version=2010.1.603.35, Culture=neutral, PublicKeyToken=5803cfa389c90ce7p lTelerik.Windows.Controls.Navigation, Version=2010.1.603.35, Culture=neutral, PublicKeyToken=5803cfa389c90ce7Fpresentation1http://schemas.telerik.com/2008/xaml/presentation   5      $	��220��5      $	��250��6     � Title$  
User Login��6    � Icon$0 */ClinSchd;component/Resources/ClinSchd.ico��5      .��5	      �  � ShowGridLines .  
������� � RowDefinitions 5
      �� 5      $��25 �6   �� 5      $
��Auto �6   �� 5      $��25 �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $
��Left=�5      $��Bottom=�5      $��3,3,0,6q�6/   	Access:6I   G� 5   
   -   5        $��
AccessCode��5      $��1��6(   $
��Left=�65   $��25��6P   $	��125��6\   $��3,3,0,6q�6i   �� 5   
   $��2��6   $
��Left=�5      $��Bottom=�5      $��3,3,0,6q�60   	Verify:6J   G� 5   
   -   5        $��
VerifyCode��5      $��3��6(   $
��Left=�65   $��25��6Q   $	��125��6]   $��3,3,0,6q�6i   (  "Telerik.Windows.Controls.RadButton  5   
   -   5        $��0,6,90,6q�5   !    �� 	IsDefault . $��4��6\   $��25��6i   $��Bottom=�6u   $��Right=�6�   $��70��6�   .��6�   OK6�     5   
   -   5        $��0,6,12,6q�5   !    �� IsCancel . $��4��6`   $��25��6m   $��Bottom=�6y   $��Right=�6�   $��70��6�   .��6�   Cancel6�   5      5      
   M S B A M L   `   `   `  ����  TenantsManager    TenantsManager.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   X TXceed.Wpf.Toolkit, Version=2.4.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f47toolkit)http://schemas.xceed.com/wpf/xaml/toolkit  5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)    � 	Resources 5         btvConv��%   &	        �� 5   
   6'   5      .��5
      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��1��6   ��6.   �� *CreateTenantCommand+.��6V   
Add tenant6b   �� 5   
   $��1��62   ��6   �� *	Tenands+ �� SelectedItem 5      �� *SelectedTenant+��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6!   ��6:   �� *	IsDeleted+.+�5      �� $��*��6$   y�6-   �� *	IsDeleted+ �� 	Converter# [  �� 5      ��6$   �� *Name+�� 5      $��(��6$   �� 5      ��6$   �� *Debt+�� 5      $��)��6$   5       5!      5#      �� 5%   
   $��1��6   $��1��6%   .+�5&      �� ��6   �� *SelectedTenant.Id+�� 5'      ��6   �� *SelectedTenant.Name+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�(  "System.Windows.Controls.DatePicker  5(      	   SelectedDate	 6   �� *SelectedTenant.Birthday+$  Xceed.Wpf.Toolkit.DoubleUpDown  5)      �  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]
   Value
 6#   �� *SelectedTenant.Debt+�� 5*       d� 	IsChecked 6   �� *SelectedTenant.IsDeleted+.��6F   
Is Deleted6R   �� 5+      ��6   �� *AddNewTenantCommand+y�6=   �� *SelectedTenant.IsNew+# [    System.Windows.Visibility   	Collapsed �� FallbackValue# Z .��6�   Save6�   �� 5,      ��6   �� *DeleteTenantCommand+.��6=   Delete6E   5-      5/      50      
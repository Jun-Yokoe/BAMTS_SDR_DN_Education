   M S B A M L   `   `   `  ����  WPFPrismApp%    BAMTS.Internal.UCMSEmployeeList   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Z VPrism.Unity.Wpf, Version=8.1.97.5141, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59T PPrism.Wpf, Version=8.1.97.5141, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59&prismhttp://prismlibrary.com/   5      !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel$
  TrueX�5      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��100 �6   �� 5	      $	��50* �6   �� 5
      $	��100 �6    � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $	��50* �6   �� 5      $��30 �6   .+�5   
   �� -   5         ��Name$ 
btnDisplay��5      $��表示��6%   $	��100��62   $��Right=�6>   $��0��6Z   $��2��6g   ��6w   �� *DisplayEmployeeList_Click+&   System.Windows.Controls.DataGrid  5   
   $��1��68   $��0��6E   $��3��6U   ��6   �� *EmployeeList+6U   �� 5   
   -   5        $ 	btnUpdate��5      $��更新��6$   $	��100��61   $
��Left=�6=   $��2��6X   $��0��6e   ��6u   �� *UpdateEmployeeList_Click+5      5      
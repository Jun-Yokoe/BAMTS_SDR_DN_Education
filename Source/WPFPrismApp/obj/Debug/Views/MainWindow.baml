   M S B A M L   `   `   `  ����  WPFPrismApp    BAMTS.Internal.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Z VPrism.Unity.Wpf, Version=8.1.97.5141, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59T PPrism.Wpf, Version=8.1.97.5141, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59&prismhttp://prismlibrary.com/   5   	   e aGrapeCity.WPF.SpreadGrid, Version=3.0.4501.2015, Culture=neutral, PublicKeyToken=5c5c8ff7a6858ccc=sg4http://schemas.grapecity.com/windows/spreadgrid/2012  5   	   !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel$
  TrueX�5   	   $	��500��5   	   $	��800��5	   	    � Title 5   	   �� *Title+.��5
      �  � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $��1* �6   �� 5      $��25 �6    � ColumnDefinitions 5   
   �� 5      $	��250 �6   �� 5      $��1* �6   .+�5   
   ]� $��1��6   $��3��6%   $��0��69   $��0��6I   ��. $��Stretch=�6k   $��Stretch=�6�   .+�5      o� 
�������.@�5      m� -   5         m�Name$
 File��5   )   $
��File��6   .@�5      m� -   5        $
 Exit��5   -   $
��File��6   6-   5      m� 5      -   5        $
 Help��5   )   $
��Help��6   .@�5      m� -   5        $ About��5   -   $
��File��6   6-   5      5      5      �� 5   
   $��1��6   $��0��6%   $��Hidden=�65   $
��Auto=�6\   $��0,0,4,0q�6�   .��5      ]� .+�5       �� -   5         ��Name$ btnInformation��5    .   $	��Top=�6   
����� �$*��$Show Popup-Dialog and receive answer��6Y   $��25��6�   $
��Left=�6�   $��1,2,0,1q�6�   ��6�   �� *ShowInformation_Click+�� 5!      -   5        $ btnEmpListGCCsv��5!   .   $	��Top=�6   
���� ��$��Employee List(GCGrid:CSV)��6[   $��25��6   $
��Left=�6�   $��1,1,0,1q�6�   ��6�   �� * DisplayEmployeeGCCsvList_Click+�� 5"      -   5        $ btnEmpListGCSQL��5"   .   $	��Top=�6   
���� ��$%��Employee List(GCGrid:SQLServer)��6[   $��25��6�   $
��Left=�6�   $��1,1,0,1q�6�   ��6�   �� * DisplayEmployeeGCSqlList_Click+�� 5#      -   5        $ btnEmpListGCAPI��5#   .   $	��Top=�6   
���� ��$"��Employee List(GCGrid:WebAPI)��6[   $��25��6�   $
��Left=�6�   $��1,1,0,1q�6�   ��6�   �� *#!DisplayEmployeeGCWebAPIList_Click+�� 5$      -	   5        $ btnEmpListGCExcel��5$   .   $	��Top=�6   
���� ��$!��Employee List(GCGrid:Excel)��6]   $��25��6�   $
��Left=�6�   $��1,1,0,1q�6�   ��6�   �� *" DisplayEmployeeGCExcelList_Click+�� 5%      -
   5        $ btnEmpListMSCsv��5%   .   $	��Top=�6   
����d�$��Employee List(MSGrid:CSV)��6d   $��25��6�   $
��Left=�6�   $��1,1,0,1q�6�   ��6�   �� * DisplayEmployeeMSCsvList_Click+�� 5&      -   5        $ btnEmpListMSSQL��5&   .   $	��Top=�6   
����d�$%��Employee List(MSGrid:SQLServer)��6c   $��25��6�   $
��Left=�6�   $��1,1,0,1q�6�   ��6�   �� * DisplayEmployeeMSSqlList_Click+�� 5'      -   5        $ btnEmpListMSAPI��5'   .   $	��Top=�6   
����d�$"��Employee List(MSGrid:WebAPI)��6c   $��25��6�   $
��Left=�6�   $��1,1,0,1q�6�   ��6�   �� *#!DisplayEmployeeMSWebAPIList_Click+�� 5(      -   5        $ btnEmpListMSExcel��5(   .   $	��Top=�6   
����d�$!��Employee List(MSGrid:Excel)��6e   $��25��6�   $
��Left=�6�   $��1,1,0,1q�6�   ��6�   �� *" DisplayEmployeeMSExcelList_Click+�� 5)      -   5        $ btnExcelSheet��5)   .   $	��Top=�6   
��� � �$��
ExcelSheet��6Y   $��25��6n   $
��Left=�6z   $��1,1,0,1q�6�   ��6�   �� *DisplayMSExcelSheet_Click+�� 5*      -   5        $ btnExit��5*   1   $��Bottom=�6   
��� ���$
��Exit��6W   $��25��6f   $��Bottom=�6r   $��1,1,1,2q�6�   ��6�   �� *ApplicationExitButton_Click+5+      5,      �� 5-   
   $��1��6   $��1��6$   $��0��65   $��Stretch=�6E   $��3��6a   
�������6k   ]� 5.   
   $��1��6   $��1��6!   .+�5/      �� !  Prism.Regions.RegionManager   
RegionName$ ContentRegion��6   50      ]� 51   
   $��2��6   $��0��6!   $��3��61   
�������.+�52      �� $
��Left=�6   ��6.   �� *DisplayComment+�� 53      $��Right=�6    �� TextAlignment$ Right=�6/   $��2,0,2,0q�6�   ��6E   �� *CurrentTime+ �� StringFormat$ yyyy/MM/dd HH:mm:ss��6�   54      55      56      
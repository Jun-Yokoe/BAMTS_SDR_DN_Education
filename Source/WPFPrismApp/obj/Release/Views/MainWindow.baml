   M S B A M L   `   `   `  ����   WPFPrismApp    BAMTS.Internal.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Z VPrism.Unity.Wpf, Version=8.1.97.5141, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59T PPrism.Wpf, Version=8.1.97.5141, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59&prismhttp://prismlibrary.com/   e aGrapeCity.WPF.SpreadGrid, Version=3.0.4501.2015, Culture=neutral, PublicKeyToken=5c5c8ff7a6858ccc=sg4http://schemas.grapecity.com/windows/spreadgrid/2012  !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel$
  TrueX�$	��500��$	��800�� � Title �� *Title+.���  � RowDefinitions �� $��20 ��� $��1* ��� $��25 � � ColumnDefinitions �� $	��250 ��� $��1* �.+�]� $��1��$��3��$��0��$��0����. $��Stretch=�$��Stretch=�.+�o� 
�������.@�m� -    m�Name$
 File��$
��File��.@�m� -   $
 Exit��$
��File��m� -   $
 Help��$
��Help��.@�m� -   $ About��$
��File���� $��1��$��0��$��Hidden=�$
��Auto=�$��0,0,4,0q�.��]� .+��� -    ��Name$ btnInformation��$	��Top=�
����� �$*��$Show Popup-Dialog and receive answer��$��25��$
��Left=�$��1,2,0,1q����� *ShowInformation_Click+�� -   $ btnEmpListGCCsv��$	��Top=�
���� ��$��Employee List(GCGrid:CSV)��$��25��$
��Left=�$��1,1,0,1q����� * DisplayEmployeeGCCsvList_Click+�� -   $ btnEmpListGCSQL��$	��Top=�
���� ��$%��Employee List(GCGrid:SQLServer)��$��25��$
��Left=�$��1,1,0,1q����� * DisplayEmployeeGCSqlList_Click+�� -   $ btnEmpListGCAPI��$	��Top=�
���� ��$"��Employee List(GCGrid:WebAPI)��$��25��$
��Left=�$��1,1,0,1q����� *#!DisplayEmployeeGCWebAPIList_Click+�� -	   $ btnEmpListGCExcel��$	��Top=�
���� ��$!��Employee List(GCGrid:Excel)��$��25��$
��Left=�$��1,1,0,1q����� *" DisplayEmployeeGCExcelList_Click+�� -
   $ btnEmpListMSCsv��$	��Top=�
����d�$��Employee List(MSGrid:CSV)��$��25��$
��Left=�$��1,1,0,1q����� * DisplayEmployeeMSCsvList_Click+�� -   $ btnEmpListMSSQL��$	��Top=�
����d�$%��Employee List(MSGrid:SQLServer)��$��25��$
��Left=�$��1,1,0,1q����� * DisplayEmployeeMSSqlList_Click+�� -   $ btnEmpListMSAPI��$	��Top=�
����d�$"��Employee List(MSGrid:WebAPI)��$��25��$
��Left=�$��1,1,0,1q����� *#!DisplayEmployeeMSWebAPIList_Click+�� -   $ btnEmpListMSExcel��$	��Top=�
����d�$!��Employee List(MSGrid:Excel)��$��25��$
��Left=�$��1,1,0,1q����� *" DisplayEmployeeMSExcelList_Click+�� -   $ btnExcelSheet��$	��Top=�
��� � �$��
ExcelSheet��$��25��$
��Left=�$��1,1,0,1q����� *DisplayMSExcelSheet_Click+�� -   $ btnExit��$��Bottom=�
��� ���$
��Exit��$��25��$��Bottom=�$��1,1,1,2q����� *ApplicationExitButton_Click+�� $��1��$��1��$��0��$��Stretch=�$��3��
�������]� $��1��$��1��.+��� !  Prism.Regions.RegionManager   
RegionName$ ContentRegion��]� $��2��$��0��$��3��
�������.+��� $
��Left=����� *DisplayComment+�� $��Right=� �� TextAlignment$ Right=�$��2,0,2,0q����� *CurrentTime+ �� StringFormat$ yyyy/MM/dd HH:mm:ss��